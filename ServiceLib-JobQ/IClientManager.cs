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
    public interface IClientManager
    {
        [OperationContract]
        Machine GetClient(int id);

        [OperationContract]
        List<Machine> GetAllClients();

        [OperationContract]
        void DeleteClient(int id);

        [OperationContract]
        Machine CreateClient(Machine client);

    }
}
