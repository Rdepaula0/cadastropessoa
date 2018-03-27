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
    public class LegalPersonService : WebService, ILegalPersonService
    {
        #region Proprietes

        private LegalPersonController _personController;

        private LegalPersonController PersonController => _personController ?? (_personController = new LegalPersonController());
        #endregion

        public bool CreateILegalPerson(LegalPersonDTO legalpersondto)
        {
            return PersonController.AddPerson(legalpersondto);
        }

        public LegalPersonDTO FindLegalPersons(string company)
        {
            return PersonController.FindLegalPersonsBy(company);
        }
    }
}
