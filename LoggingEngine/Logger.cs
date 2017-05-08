using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingEngine
{
    public class Logger
    {
        public event EventHandler<WorkPerformedArgs> WorkPerformed;
        public string message { get; set; }
        public DateTime eventTime { get; set; }

        protected virtual void OnWorkPerformed(string data)
        {
            WorkPerformed?.Invoke(this, new WorkPerformedArgs() { Data = data });
        }

    }

    public class WorkPerformedArgs : EventArgs
    {
        public string Data { get; set; }
    }

    public class Logging
    {
        public FileInfo Log { get; set; }

        public Logging(string directory)
        {
            string path = directory + "Log.txt";
            if (!File.Exists(path))
                File.Create(path).Close();

            Log = new FileInfo(path);
        }


        public void OnWorkPerformed(object source, WorkPerformedArgs args)
        {
            Console.WriteLine(args.Data);
            using (StreamWriter writer = new StreamWriter(Log.FullName, true))
                writer.WriteLine(args.Data);
        }
    }
}
