using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP.Repository;
using CP.Domain;
using CP.Controller;
using CP.DTO;

namespace CP.Test
{
    [TestClass]
    public class PhoneControllerTest
    {
        #region Proprietes

        private PhoneController _phonecontroller;

        private PhoneController PhoneController => _phonecontroller ?? (_phonecontroller = new PhoneController());

        #endregion

        [TestMethod]
        public void save_phone_with_success()
        {
            var newitem = new PhoneDTO
            {
                Number = "11112222",
                TypeNumber = TypeNumberEnum.Celular
            };

            var result = PhoneController.AddPhone(newitem);

            Assert.IsNotNull(result, "cannot save");
        }

        [TestMethod]
        public void find_all_phone_success()
        {            
            var result = PhoneController.FindPhone();

            Assert.IsNotNull(result, "cannot find");
        }

        [TestMethod]
        public void find_phone_by_number_success()
        {
            var result = PhoneController.FindPhone("11112222");

            Assert.IsNotNull(result, "cannot find");
        }
    }
}
