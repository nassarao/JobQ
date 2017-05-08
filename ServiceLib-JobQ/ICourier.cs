using JobQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLib_JobQ
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICourier" in both code and config file together.
    [ServiceContract]
    public interface ICourier
    {
    

        [OperationContract]
        Job DispatchJob(Machine requestingClient);

        [OperationContract]
        string ReturnJob(Job job);
    }
}
