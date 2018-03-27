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
    public interface IAddressService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "person/address/findall")]
        List<AddressDTO> FindAddress();
        
        [OperationContract]
        [WebInvoke(UriTemplate = "person/address/add", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool CreateAddress(AddressDTO personaddressdto);
    }
}
