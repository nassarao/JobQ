using JobQ;
using JQJMCLI.JobManager;
using System;
using System.Collections.Generic;
using System.Linq;
namespace JMCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null)
            {
                if (args.Length >= 1)
                {
                    JobManagerClient jm = new JobManagerClient();
                    ClientManagerClient cm = new ClientManagerClient();

                    string cmdType = args[0].ToLower();
                    string id;
                    string argument;

                    switch (args[0].ToLower())
                    {
                        case "-create":
                            argument = args[1].ToLower();
                            jm.CreateJob(argument);
                            break;
                        case "-get":
                            argument = args[1].ToLower();
                            Job job = jm.GetJob(int.Parse(argument));
                            if(job != null)
                            Console.WriteLine(job.ToString()); 
                            break;
                        case "-getall":
                            List<Job> jobs = jm.GetAllJobs().ToList();
                            jobs.ForEach(x => Console.WriteLine(x.ToString())); 
                            Console.ReadLine();
                            break;
                        case "-getallclients":

                            cm.GetAllClients().ToList().ForEach(x => Console.WriteLine(x.ToString()));
                            Console.ReadLine();
                            break;
                        case "-update":
                            id = args[1];
                            argument = args[2].ToLower();
                            jm.UpdateJob(int.Parse(id), argument);
                            break;
                        case "-delete":
                            argument = args[1].ToLower();
                            jm.DeleteJob(int.Parse(argument));
                            break;
                        case "help":
                            printHelp();
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    printHelp();
                    Console.ReadLine();
                }
            }
            else
            {
                printHelp();
                Console.ReadLine();
            }

        }

       

        private static void printHelp()
        {
            Console.WriteLine("jqjmcli.exe action [parameters]");
            Console.WriteLine("All Actions:" + Environment.NewLine
                    + "\t -create [string]" + Environment.NewLine
                    + "\t -get [guid]" + Environment.NewLine
                    + "\t -getAll" + Environment.NewLine
                    + "\t -getAllclients" + Environment.NewLine
                    + "\t -update [guid] [string]" + Environment.NewLine
                    + "\t -delete [guid]" + Environment.NewLine
                    + "Examples:" + Environment.NewLine
                    + "\t jqjmcli.exe -create \"c:\\qatfclie.exe 116 0 gc\"" + Environment.NewLine
                    + "\t jqjmcli.exe -get 15");
        }
    }
}
