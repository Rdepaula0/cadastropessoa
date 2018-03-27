using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP.Repository;
using CP.Domain;
using CP.Controller;
using CP.DTO;

namespace CP.Test
{
    [TestClass]
    public class PhysicalPersonControllerTest
    {
        #region Proprietes

        private PhysicalPersonController _physicalPersonController;

        private PhysicalPersonController PhysicalPersonController => _physicalPersonController ?? (_physicalPersonController = new PhysicalPersonController());

        #endregion

        [TestMethod]
        public void save_physical_person_success()
        {
            var newperson = new PhysicalPersonDTO
            {
                DateofBirth = new DateTime(1982,01,01),
                Name = "Rodrigo",
                Occupation = "Developer"
            };

            var result = PhysicalPersonController.AddPerson(newperson);

            Assert.IsNotNull(result, "cannot save person");
        }

        [TestMethod]
        public void find_all_physical_person_success()
        {            
            var result = PhysicalPersonController.FindLegalPersons();

            Assert.IsNotNull(result, "cannot find person");
        }

        [TestMethod]
        public void find_physical_person_by_name_success()
        {
            var result = PhysicalPersonController.FindLegalPersons("Rodrigo");

            Assert.IsNotNull(result, "cannot find person");
        }
    }
}
