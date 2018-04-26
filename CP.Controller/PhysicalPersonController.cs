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
    public class PhysicalPersonController
    {
        #region Proprietes

        private PhysicalPersonRepository _physicalPersonRepository;

        private PhysicalPersonRepository PhysicalPersonRepository => _physicalPersonRepository ?? (_physicalPersonRepository = new PhysicalPersonRepository());

        #endregion

        public bool AddPerson(PhysicalPersonDTO person)
        {
            var newperson = new PhysicalPerson
            {
                Name = person.Name,
                DateofBirth = person.DateofBirth,
                Occupation = person.Occupation,
                //PhoneList = ConvertPhoneListTo(person.PhoneList),
                //AddressList = ConvertAddressListTo(person.AddressList)
            };

            var data = PhysicalPersonRepository.Add(newperson);

            return data != 0;
        }

        public IEnumerable<PhysicalPersonDTO> FindLegalPersons()
        {
            var data = PhysicalPersonRepository.FindAllPhysicalPerson();

            return data.Select(person => new PhysicalPersonDTO()
            {
                Id = person.Id,
                Name = person.Name,
                Occupation = person.Occupation,
                DateofBirth = person.DateofBirth,
                AddressList = ConvertAddressListTo(person.AddressList),
                PhoneList = ConvertPhoneListTo(person.PhoneList),
            }).ToList();
        }

        public PhysicalPersonDTO FindLegalPersons(string name)
        {
            var data = PhysicalPersonRepository.FindPhysicalPerson(name);

            return new PhysicalPersonDTO()
            {
                Id = data.Id,
                Name = data.Name,
                Occupation = data.Occupation,
                DateofBirth = data.DateofBirth,
                AddressList = ConvertAddressListTo(data.AddressList),
                PhoneList = ConvertPhoneListTo(data.PhoneList),
            };
        }

        private List<AddressDTO> ConvertAddressListTo(List<Address> addressList)
        {
            var list = new List<AddressDTO>();
            foreach (var item in addressList)
            {
                list.Add(new AddressDTO
                {
                    Id = item.Id,
                    City = item.City,
                    Number = item.Number,
                    State = item.State,
                    Street = item.Street,
                    TypeAddress = item.TypeAddress
                });
            }

            return list;
        }

        private List<Address> ConvertAddressListTo(List<AddressDTO> addressList)
        {
            var list = new List<Address>();
            foreach (var item in addressList)
            {
                list.Add(new Address
                {
                    Id = item.Id,
                    City = item.City,
                    Number = item.Number,
                    State = item.State,
                    Street = item.Street,
                    TypeAddress = item.TypeAddress
                });
            }

            return list;
        }

        private List<PhoneDTO> ConvertPhoneListTo(List<Phone> phoneList)
        {
            var list = new List<PhoneDTO>();
            foreach (var item in phoneList)
            {
                list.Add(new PhoneDTO
                {
                    Id = item.Id,
                    Number = item.Number,
                    TypeNumber = item.TypeNumber,
                });
            }

            return list;
        }

        private List<Phone> ConvertPhoneListTo(List<PhoneDTO> phoneList)
        {
            var list = new List<Phone>();
            foreach (var item in phoneList)
            {
                list.Add(new Phone
                {
                    Id = item.Id,
                    Number = item.Number,
                    TypeNumber = item.TypeNumber,
                });
            }

            return list;
        }
    }
}
