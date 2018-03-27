using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP.Repository;
using CP.Domain;

namespace CP.Test
{
    [TestClass]
    public class AddressRepositoryTest
    {
        #region Proprietes

        private AddressRepository _addressRepository;

        private AddressRepository AddressRepository => _addressRepository ?? (_addressRepository = new AddressRepository());

        #endregion

        [TestMethod]
        public void save_address_with_success()
        {
            var newitem = new Address
            {                
                Street="Rua A",
                City="Rio de Janeiro",
                State="RJ",
                Number = "10",
                TypeAddress = TypeAddressEnum.Comercial
            };

            var result = AddressRepository.Add(newitem);

            Assert.IsNotNull(result, "cannot save");
        }

        [TestMethod]
        public void find_all_address_success()
        {
            var result = AddressRepository.FindAllAddress();

            Assert.IsNotNull(result, "cannot find");
        }

        [TestMethod]
        public void delete_address_success()
        {
            var result = AddressRepository.FindAllAddress();
            
            Assert.IsNotNull(result, "cannot find");

            foreach (var item in result)
            {
                AddressRepository.Delete(item);
            }

            result = AddressRepository.FindAllAddress();
            Assert.IsNotNull(result, "cannot delete");
        }
    }
}
