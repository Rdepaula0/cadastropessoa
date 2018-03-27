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
    public interface ILegalPersonService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "person/legal/find/{company}")]
        LegalPersonDTO FindLegalPersons(string company);
        
        [OperationContract]
        [WebInvoke(UriTemplate = "person/legal/add", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool CreateILegalPerson(LegalPersonDTO legalpersondto);
    }
}
