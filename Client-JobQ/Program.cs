
using Client_JobQ.JobQService;
using JobQ;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client_JobQ
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasJob = false;
            CourierClient courier = new CourierClient();          
            JobQ.Machine client = new JobQ.Machine();
           

            try
            {
                while (true)
                {
                    while (!hasJob)
                    {

                        Console.WriteLine("Requesting Job...");
                        JobQ.Job job = courier.DispatchJob(client);
                        
                        if (job != null)
                        {
                            Console.WriteLine("Recieved Job: {0}", job.ToString());
                            hasJob = true;
                            job.Status = "Running";
                            job.ExecutionMachine = client;
                            courier.ReturnJob(job);
                            job.Run();
                            job.Status = "Complete";
                            courier.ReturnJob(job);
                            Console.WriteLine("Sent completed Job back to server");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("No Jobs available. Waiting and will request another");
                        }

                        System.Threading.Thread.Sleep(10000);

                        hasJob = false;
                    }

                    

                }
            }
            catch(EndpointNotFoundException ee)
            {
                Console.WriteLine("There is not Server Running or it was not found!");
                Console.WriteLine(ee.Message);
            }

            courier.Abort();
            Console.WriteLine();
            Console.WriteLine("Press <enter> to close.");
            Console.ReadLine();
        }

       
    }
}
