using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP.Repository;
using CP.Domain;
using CP.Controller;
using CP.DTO;

namespace CP.Test
{
    [TestClass]
    public class LegalPersonControllerTest
    {
        #region Proprietes

        private LegalPersonController _legalPersonController;

        private LegalPersonController LegalPersonController => _legalPersonController ?? (_legalPersonController = new LegalPersonController());

        #endregion

        [TestMethod]
        public void save_legal_person_success()
        {
            var newitem = new LegalPersonDTO
            {
                CNPJ="11111111111111",
                Company_Name="COMPAY X",
                Responsible="JOSE"
            };

            var result = LegalPersonController.AddPerson(newitem);

            Assert.IsNotNull(result, "cannot save person");
        }

        [TestMethod]
        public void find_all_legal_person_success()
        {            
            var result = LegalPersonController.FindLegalPersons();

            Assert.IsNotNull(result, "cannot find person");
        }

        [TestMethod]
        public void find_all_legal_person_BY_COMPANY_success()
        {
            var result = LegalPersonController.FindLegalPersonsBy("COMPAY X");

            Assert.IsNotNull(result, "cannot find person");
        }
    }
}
