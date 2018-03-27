using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP.Repository;
using CP.Domain;

namespace CP.Test
{
    [TestClass]
    public class LegalPersonRepositoryTest
    {
        #region Proprietes

        private LegalPersonRepository _legalPersonRepository;

        private LegalPersonRepository LegalPersonRepository => _legalPersonRepository ?? (_legalPersonRepository = new LegalPersonRepository());

        #endregion

        [TestMethod]
        public void save_legal_person_success()
        {
            var newitem = new LegalPerson
            {
                CNPJ="11111111111111",
                Company_Name="COMPAY X",
                Responsible="JOSE"
            };

            var result = LegalPersonRepository.Add(newitem);

            Assert.IsNotNull(result, "cannot save person");
        }

        [TestMethod]
        public void find_all_legal_person_success()
        {            
            var result = LegalPersonRepository.FindAllLegalPersons();

            Assert.IsNotNull(result, "cannot find person");
        }
    }
}
