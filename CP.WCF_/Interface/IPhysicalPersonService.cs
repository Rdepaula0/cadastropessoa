using CP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CP.WCF
{
    [ServiceContract]
    public interface IPhysicalPersonService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "person/physical/find/{name}")]
        PhysicalPersonDTO FindPhysicalPerson(string name);
        
        [OperationContract]
        [WebInvoke(UriTemplate = "person/physical/add", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool CreatePhysicalPerson(PhysicalPersonDTO physicalpersondto);
    }
}
