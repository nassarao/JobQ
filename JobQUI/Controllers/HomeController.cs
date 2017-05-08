using JobQ;
using JobQUI.JobQService;
using JobQUI.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace JobQUI.Controllers
{
    public class HomeController : Controller
    {
        JobManagerClient jm = new JobManagerClient();
        ClientManagerClient cm = new ClientManagerClient();
        public ActionResult Index()
        {
            JobQViewModel vm = CreateViewModel();
            if (vm != null)
                return View(vm);

            return View();
        }

        private JobQViewModel CreateViewModel()
        {
            JobQViewModel vm = new JobQViewModel();

            try
            {
                var clients = cm.GetAllClients();
                var jobList = jm.GetAllJobs();

                if (jobList != null)
                {
                    foreach (Job job in jobList)
                    {
                        if (clients != null)
                        {
                            foreach (Machine client in clients)
                            {
                                //if (job.CreatingMachineId == client.Id)
                                //    job.CreatingMachine = client;
                                if (job.ExecutionMachineId == client.Id)
                                    job.ExecutionMachine = client;
                                   
                                
                            }
                        }
                    }

                    vm.Jobs = jobList.Where(x => x.Status == "InQueue").ToList();
                    vm.ExecutedJobs = jobList.Where(x => x.Status != "InQueue").ToList();
                }

                if (clients != null)
                    vm.Clients = clients.ToList();

                return vm;
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("errors", String.Format("Failed speaking with the server. Exception error: {0}", ex.Message));
            }
            return vm;
        }

        [HttpGet]
        public ActionResult TableData()
        {
            JobQViewModel vm = CreateViewModel();
            if (vm != null)
                return PartialView("TablePartial", vm);

            return PartialView("TablePartial");


        }

        [HttpGet]
        public ActionResult ExecutedTableData()
        {
            JobQViewModel vm = CreateViewModel();
            if (vm != null)
                return PartialView("ExecutedTablePartial", vm);

            return PartialView("ExecutedTablePartial");


        }

        [HttpPost]
        public ActionResult AddJob(string jobData, string button)
        {
            try
            {

                if (jobData != null)
                {
                    jm.CreateJob(jobData);
                    return Json(new { successful = true });
                }

            }
            catch (Exception ex)
            {
                return Json(new { successful = false });

            }
            return Json(new { successful = false });



        }

        [HttpPost]
        public ActionResult UpdateJob(string jobData, string guid)
        {
            try
            {
                if (jobData != null)
                {
                    jm.UpdateJob(int.Parse(guid), jobData);
                    return Json(new { successful = true });
                }

            }
            catch (Exception ex)
            {
                return Json(new { successful = false });

            }
            return Json(new { successful = false });

        }

        [HttpPost]
        public ActionResult DeleteJob(string guid)
        {
            try
            {
                jm.DeleteJob(int.Parse(guid));
                return Json(new { successful = true });

            }
            catch (Exception ex)
            {
                return Json(new { successful = false });

            }
            return Json(new { successful = false });

        }
    }
}