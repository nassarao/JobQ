using JobQ;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;

namespace ServiceLib_JobQ
{

    public partial class WcfEntryPoint : ICourier
    {


        public Job DispatchJob(Machine requestingClient)
        {
            Console.WriteLine("Recieved request for job");
            CheckClientList(requestingClient);
            List<Job> remainingJobs = db.Job.Include("CreatingMachine").Include("ExecutionMachine").Where(x => x.Status == "InQueue").ToList();
            if (remainingJobs.Count > 0)
            {

                return remainingJobs.OrderBy(x => x.DateCreated).FirstOrDefault();
            }
            return null;

        }

        public string ReturnJob(Job returningJob)
        {
            if (returningJob.ExecutionMachine != null)
            {
                Machine match = db.Machine.FirstOrDefault(x => x.IpAddress == returningJob.ExecutionMachine.IpAddress);
                if (match != null)
                {
                    returningJob.ExecutionMachineId = match.Id;
                }
                else
                {
                    db.Machine.Add(returningJob.ExecutionMachine);
                    db.SaveChanges();
                    returningJob.ExecutionMachineId = returningJob.ExecutionMachine.Id;
                }
            }

            Job oldJ = db.Job.Find(returningJob.Id);
            db.Entry(oldJ).CurrentValues.SetValues(returningJob);
            db.SaveChanges();
            Console.WriteLine("Updating completed job from: {0}", returningJob.ExecutionMachine);
            return "Thanks I've updated the job";
        }



    }


    public partial class WcfEntryPoint : IJobManager
    {
        public Job CreateJob(string cmd)
        {
            Job newJob = new Job(cmd);
            CheckClientList(newJob);
            db.Job.Add(newJob);
            db.SaveChanges();
            Console.WriteLine("Added Job: {0}, Total Jobs {1}.", newJob.ToString(), db.Job.ToList().Count);
            return newJob;
        }
        public Job AddJob(Job job)
        {
            CheckClientList(job);
            db.Job.Add(job);
            db.SaveChanges();
            Console.WriteLine("Added Job: {0}, Total Jobs {1}.", job.ToString(), db.Job.ToList().Count);
            return job;
        }
        public List<Job> AddJobRange(List<Job> jobs)
        {
            jobs.ForEach(x => CheckClientList(x));
            db.Job.AddRange(jobs);
            db.SaveChanges();
            jobs.ForEach(x => Console.WriteLine("Added Job: {0}", x.ToString()));
            return jobs;
        }

        public Job CreateJobWithName(string cmd, string username)
        {
            Job newJob = new Job(cmd,username);
            CheckClientList(newJob);
            db.Job.Add(newJob);
            db.SaveChanges();
            Console.WriteLine("Added Job: {0}, Total Jobs {1}.", newJob.ToString(), db.Job.ToList().Count);
            return newJob;
        }

        private void CheckClientList(Job newJob)
        {
            List<Machine> clients = db.Machine.ToList();
            Machine match = null;
            if (clients.Count > 0)
                match = db.Machine.FirstOrDefault(x => x.IpAddress == newJob.CreatingMachine.IpAddress);

            if (match != null)
            {
                newJob.CreatingMachine = null;
                newJob.CreatingMachineId = match.Id;
            }
        }

        public List<Job> CreateJobRange(List<string> cmds,string username)
        {
            if (cmds.Count > 0)
            {
                List<Job> newJobs = new List<Job>();
                foreach (string cmd in cmds)
                {
                    newJobs.Add(new Job(cmd) { Username = username});
                }
               
                newJobs.ForEach(x => CheckClientList(x));
                db.Job.AddRange(newJobs);
                db.SaveChanges();
                newJobs.ForEach(x => Console.WriteLine("Added Job: {0}", x.ToString()));
                return newJobs;
            }
            return null;

        }
        public void DeleteJob(int id)
        {
            Job jobToRemove = db.Job.Find(id);
            if (jobToRemove != null)
            {
                db.Job.Remove(jobToRemove);
                db.SaveChanges();
                Console.WriteLine("Deleted Job: {0}, Total Jobs {1}.", jobToRemove.ToString(), db.Job.ToList().Count);
            }

        }

        public List<Job> GetAllJobs()
        {

            List<Job> allJobs = db.Job.Include(x => x.CreatingMachine).Include(x => x.ExecutionMachine).ToList();
            Console.WriteLine("Returning All Jobs... Count {0}.", allJobs.Count);
            return allJobs;
        }

        public List<Job> GetAllUnexecutedJobs()
        {
            List<Job> allJobs = db.Job.Include("CreatingMachine").Where(x => x.Status == "InQueue").ToList();
            Console.WriteLine("Returning All Unexecuted Jobs... Count {0}.", allJobs.Count);
            return allJobs;

        }

        public List<Job> GetAllExecutedJobs()
        {
            List<Job> exeJobs = db.Job.Include("CreatingMachine").Include("ExecutionMachine").ToList();
            Console.WriteLine("Returning All Executed Jobs... Count {0}.", exeJobs.Count);
            return exeJobs;

        }

        public Job GetJob(int id)
        {
            Job jobToReturn = db.Job.Include("CreatingMachine").Include("ExecutionMachine").FirstOrDefault(x => x.Id == id);
            if (jobToReturn != null)
            {
                Console.WriteLine("Returning job {0}.", jobToReturn.ToString());
                return jobToReturn;
            }
            else
            {
                Console.WriteLine("Job with id: {0} does not exist.");
                return null;
            }
        }

        public Job UpdateJob(int id, string data)
        {
            Job oldJ = db.Job.Include("CreatingMachine").Include("ExecutionMachine").FirstOrDefault(x => x.Id == id);
            if (data != null && oldJ != null)
            {
                Job newJ = new Job(data);
                oldJ.Cmd = newJ.Cmd;
                oldJ.DateCreated = newJ.DateCreated;
                oldJ.Arguments = newJ.Arguments;
                db.Entry(oldJ).State = EntityState.Modified;
                db.SaveChanges();
                Console.WriteLine("Updating job guid:{0} with {1}", oldJ.Id, oldJ.ToString());
                return oldJ;
            }
            else
            {
                return null;
            }

        }

        public Job UpdateJobWithName(int id, string data, string username)
        {
            Job oldJ = db.Job.Include("CreatingMachine").Include("ExecutionMachine").FirstOrDefault(x => x.Id == id);
            if (data != null && oldJ != null)
            {
                Job newJ = new Job(data,username);
                oldJ.Cmd = newJ.Cmd;
                oldJ.DateCreated = newJ.DateCreated;
                oldJ.Arguments = newJ.Arguments;
                db.Entry(oldJ).State = EntityState.Modified;
                db.SaveChanges();
                Console.WriteLine("Updating job guid:{0} with {1}", oldJ.Id, oldJ.ToString());
                return oldJ;
            }
            else
            {
                return null;
            }

        }

    }


    public partial class WcfEntryPoint : IClientManager
    {

        JobQContext db = new JobQContext();
        public Machine CreateClient(Machine client)
        {
            db.Machine.Add(client);
            db.SaveChanges();
            Console.WriteLine("Added Client: {0}, Total Clients {1}.", client.ToString(), db.Machine.ToList().Count);
            return client;
        }

        public void DeleteClient(int id)
        {
            db.Machine.Remove(db.Machine.Find(id));
            db.SaveChanges();
        }

        public List<Machine> GetAllClients()
        {
            return db.Machine.ToList();
        }

        public Machine GetClient(int id)
        {
            return db.Machine.Find(id);
        }

        private void CheckClientList(Machine client)
        {
            if (db.Machine.Count() > 0)
            {
                Machine match = db.Machine.FirstOrDefault(x => x.IpAddress == client.IpAddress);
                if (match == null)
                {
                    db.Machine.Add(client);
                    db.SaveChanges();
                }
            }
            else
            {
                db.Machine.Add(client);
                db.SaveChanges();
            }
        }
    }
}
