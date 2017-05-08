using JobQ;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ServiceLib_JobQ
{
    public class TempHandler
    {
        public string jobsTempLocation { get; set; }
        public string executedTempLocation { get; set; }

        public TempHandler()
        {
            jobsTempLocation = GetTempFilePathWithExtension(".xml");
            executedTempLocation = GetTempFilePathWithExtension(".xml");
        }

        public void AppendJob(Job job, string path)
        {
            XmlSerializer xx = new XmlSerializer(typeof(Job));
            string xml = "";

            using(StringWriter sww = new StringWriter())
            {
                using(XmlWriter xmlWriter = XmlWriter.Create(sww))
                {
                    xx.Serialize(sww, job);
                    xml = sww.ToString();
                    using(StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine(xml);
                    }
                }
            }

        }

        private string GetTempFilePathWithExtension(string extension)
        {
            var path = Path.GetTempPath();
            var fileName = Guid.NewGuid().ToString() + extension;
            return Path.Combine(path, fileName);
        }


    }
}
