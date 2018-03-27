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
    public class PhoneService : WebService, IPhoneService
    {
        #region Proprietes

        private PhoneController _phoneController;

        private PhoneController PhoneController => _phoneController ?? (_phoneController = new PhoneController());

        #endregion

        public bool CreatePhonePerson(PhoneDTO personphonedto)
        {
            return PhoneController.AddPhone(personphonedto);
        }

        public PhoneDTO FindPhone(string number)
        {
            return PhoneController.FindPhone(number);
        }
    }
}
