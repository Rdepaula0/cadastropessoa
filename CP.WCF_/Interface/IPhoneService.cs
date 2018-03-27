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
    public interface IPhoneService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "person/phone/find/{number}")]
        PhoneDTO FindPhone(string number);
        
        [OperationContract]
        [WebInvoke(UriTemplate = "person/phone/add", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool CreatePhonePerson(PhoneDTO personphonedto);
    }
}
