
using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Linq;

using System.Collections.Generic;
using ServiceLib_JobQ;

namespace Server_JobQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //URI to serve as the base address
            Uri baseAddress = new Uri("http://localhost:8000/JobQ/");

            ServiceHost selfHost = new ServiceHost(typeof(WcfEntryPoint), baseAddress);

            var binding = new WSHttpBinding();
            try
            {
                //Add Service endpoint
                selfHost.AddServiceEndpoint(typeof(ICourier), binding, "Courier");
                selfHost.AddServiceEndpoint(typeof(IJobManager), binding, "JobManager");
                selfHost.AddServiceEndpoint(typeof(IClientManager), binding, "ClientManager");

                //Enable meta data exchange
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;

                selfHost.Description.Behaviors.Add(smb);


                //Starting service
                selfHost.Open();

                Console.WriteLine("Courier Service is running...");
                Console.WriteLine("JobManager Service is runing...");
                Console.WriteLine("ClientManager Service is runing...");

                Console.WriteLine();
                Console.WriteLine("Press <enter> to terminate services");
                Console.WriteLine();
                Console.ReadLine();

                //Shut down service upon pressing enter
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {

                Console.WriteLine("An exception occured: {0}", ce.Message);
                selfHost.Abort();
            }
        }





    }
}
