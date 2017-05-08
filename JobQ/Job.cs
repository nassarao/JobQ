using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JobQ
{

    /// <summary>
    /// A job to be executed
    /// </summary>
    [DataContract]
    public class Job
    {
      
        [DataMember]
        public int Id{ get; set; }

        [DataMember]
        public string Cmd { get; set; }

        [DataMember]
        public string Arguments { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public DateTime DateCreated { get; set; }

        [DataMember]
        public DateTime DateExecuted { get; set; }

        [DataMember]
        public int CreatingMachineId { get; set; }
        [DataMember]
        public int? ExecutionMachineId { get; set; }

        [DataMember]
        public  Machine CreatingMachine { get; set; }
        [DataMember]
        public  Machine ExecutionMachine { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Name { get; set; }

        public Job(string cmd)
        {
            string[] data = cmd.Split(' ');
            Cmd = data[0];
            Arguments = "";
            for (int i = 1; i < data.Length; i++)
            {
                Arguments += " " + data[i];
            }
            Arguments = Arguments.Trim();
            Status = "InQueue";
            DateCreated = DateTime.Now;
            CreatingMachine = new Machine();
            Username = Environment.UserName;
        }

        public Job(string cmd, string username)
        {
            string[] data = cmd.Split(' ');
            Cmd = data[0];
            Arguments = "";
            for (int i = 1; i < data.Length; i++)
            {
                Arguments += " " + data[i];
            }
            Arguments = Arguments.Trim();
            Status = "InQueue";
            DateCreated = DateTime.Now;
            Username = username;
            CreatingMachine = new Machine();
        }
        public Job()
        {

        }

        public override string ToString()
        {
            if (CreatingMachine != null)
            {
                string job = String.Format("id:{0}, cmd:{1}, Machine:{2}, Date:{3}", Id, Cmd + " " + Arguments,
                    CreatingMachine.Name ?? "", DateCreated);
                return job;
            }
            else
            {
                string job = String.Format("id:{0}, cmd:{1}, Machine:{2}, Date:{3}", Id, Cmd + " " +Arguments,
                   "", DateCreated);
                return job;
            }
        }
        public Job Run()
        {
            ProcessStartInfo cmdsi = new ProcessStartInfo(Cmd,Arguments);
            ExecutionMachine = new Machine();
            try
            {
                Process cmd = Process.Start(cmdsi);
                cmd.WaitForExit();
                Status = "Done";

            }
            catch (Exception ex)
            {
                Status = String.Format("Failed: {0}", ex.Message);
            }
            return this;
        }

      
    }
}
