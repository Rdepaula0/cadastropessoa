using CP.DTO;
using CP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP.Domain;

namespace CP.Controller
{
    public class AddressController
    {
        #region Proprietes

        private AddressRepository _addressRepository;

        private AddressRepository AddressRepository => _addressRepository ?? (_addressRepository = new AddressRepository());

        #endregion

        public bool AddAddress(AddressDTO person)
        {
            var newperson = new Address
            {
                Number = person.Number,
                City = person.City,
                State = person.State,
                Street = person.Street,
                TypeAddress = person.TypeAddress
            };

            var data = AddressRepository.Add(newperson);

            return data != 0;
        }

        public IEnumerable<AddressDTO> FindAddress()
        {
            var data = AddressRepository.FindAllAddress();

            return data.Select(person => new AddressDTO()
            {
                Id = person.Id,
                Number = person.Number,
                TypeAddress = person.TypeAddress,
                City = person.City,
                Street = person.Street,
                State = person.State
            }).ToList();
        }
    }
}
