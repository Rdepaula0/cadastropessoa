using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP.Repository;
using CP.Domain;

namespace CP.Test
{
    [TestClass]
    public class PhysicalPersonRepositoryTest
    {
        #region Proprietes

        private PhysicalPersonRepository _physicalPersonRepository;

        private PhysicalPersonRepository PhysicalPersonRepository => _physicalPersonRepository ?? (_physicalPersonRepository = new PhysicalPersonRepository());

        #endregion

        [TestMethod]
        public void save_physical_person_success()
        {
            var newperson = new PhysicalPerson
            {
                DateofBirth = new DateTime(1982,01,01),
                Name = "Rodrigo",
                Occupation = "Developer"
            };

            var result = PhysicalPersonRepository.Add(newperson);

            Assert.IsNotNull(result, "cannot save person");
        }

        [TestMethod]
        public void find_all_physical_person_success()
        {            
            var result = PhysicalPersonRepository.FindAllPhysicalPerson();

            Assert.IsNotNull(result, "cannot find person");
        }

        [TestMethod]
        public void find_physical_person_by_name_success()
        {
            var result = PhysicalPersonRepository.FindPhysicalPerson("Rodrigo");

            Assert.IsNotNull(result, "cannot find person");
        }
    }
}
