using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP.Repository;
using CP.Domain;

namespace CP.Test
{
    [TestClass]
    public class PhoneRepositoryTest
    {
        #region Proprietes

        private PhoneRepository _phoneRepository;

        private PhoneRepository PhoneRepository => _phoneRepository ?? (_phoneRepository = new PhoneRepository());

        #endregion

        [TestMethod]
        public void save_phone_with_success()
        {
            var newitem = new Phone
            {
                Number = "21-3333-4444",
                TypeNumber = TypeNumberEnum.Celular
            };

            var result = PhoneRepository.Add(newitem);

            Assert.IsNotNull(result, "cannot save");
        }

        [TestMethod]
        public void find_all_phone_success()
        {            
            var result = PhoneRepository.FindAllPhone();

            Assert.IsNotNull(result, "cannot find");
        }
    }
}
