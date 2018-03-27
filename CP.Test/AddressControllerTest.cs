using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP.Repository;
using CP.Domain;
using CP.Controller;
using CP.DTO;

namespace CP.Test
{
    [TestClass]
    public class AddressControllerTest
    {
        #region Proprietes

        private AddressController _addressController;

        private AddressController AddressController => _addressController ?? (_addressController = new AddressController());

        #endregion

        [TestMethod]
        public void save_address_with_success()
        {
            var newitem = new AddressDTO
            {                
                Street="Rua A",
                City="Rio de Janeiro",
                State="RJ",
                Number = "10",
                TypeAddress = TypeAddressEnum.Comercial
            };

            var result = AddressController.AddAddress(newitem);

            Assert.IsNotNull(result, "cannot save");
        }

        [TestMethod]
        public void find_all_address_success()
        {
            var result = AddressController.FindAddress();

            Assert.IsNotNull(result, "cannot find");
        }
    }
}
