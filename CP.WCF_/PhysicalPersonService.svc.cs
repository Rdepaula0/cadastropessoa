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
    public class PhysicalPersonService : WebService, IPhysicalPersonService
    {
        #region Proprietes

        private PhysicalPersonController _physicalPersonController;

        private PhysicalPersonController PhysicalPersonController => _physicalPersonController ?? (_physicalPersonController = new PhysicalPersonController());

        #endregion
        public bool CreatePhysicalPerson(PhysicalPersonDTO physicalpersondto)
        {
            return PhysicalPersonController.AddPerson(physicalpersondto);
        }

        public PhysicalPersonDTO FindPhysicalPerson(string name)
        {
            return PhysicalPersonController.FindLegalPersons(name);
        }
    }
}
