using CP.WCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;
using CP.DTO;
using CP.Controller;

namespace CP.WCF
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class AddressService : WebService, IAddressService
    {
        #region Proprietes

        private AddressController _addressController;

        private AddressController AddressController => _addressController ?? (_addressController = new AddressController());
        #endregion

        public bool CreateAddress(AddressDTO personaddressdto)
        {
            return AddressController.AddAddress(personaddressdto);
        }

        public List<AddressDTO> FindAddress()
        {
            return AddressController.FindAddress().ToList();
        }
    }
}
