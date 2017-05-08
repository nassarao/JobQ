using JobQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLib_JobQ
{
    [ServiceContract]
    public interface IJobManager
    {
        [OperationContract]
        Job CreateJob(string cmd);

        [OperationContract]
        Job AddJob(Job job);
        [OperationContract]
        List<Job> AddJobRange(List<Job> jobs);

        [OperationContract]
        Job CreateJobWithName(string cmd, string username);

        [OperationContract]
        List<Job> CreateJobRange(List<string> cmds, string username);

        [OperationContract]
        Job GetJob(int id);

        [OperationContract]
        List<Job> GetAllJobs();

        [OperationContract]
        List<Job> GetAllExecutedJobs();

        [OperationContract]
        List<Job> GetAllUnexecutedJobs();

        [OperationContract]
        Job UpdateJob(int id, string cmd);
        [OperationContract]
        Job UpdateJobWithName(int id, string cmd, string username);

        [OperationContract]
        void DeleteJob(int id);

    }
}
