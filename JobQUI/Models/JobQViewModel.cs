
using JobQ;
using JobQUI.JobQService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobQUI.Models
{
    public class JobQViewModel
    {
        public List<Job> Jobs { get; set; }
        public List<Job> ExecutedJobs { get; set; }

        public List<Machine> Clients { get; set; }

    }
}