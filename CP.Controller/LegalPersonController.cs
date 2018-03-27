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
    public class LegalPersonController
    {
        #region Proprietes

        private LegalPersonRepository _legalPersonRepository;

        private LegalPersonRepository LegalPersonRepository => _legalPersonRepository ?? (_legalPersonRepository = new LegalPersonRepository());

        #endregion

        public bool AddPerson(LegalPersonDTO person)
        {
            var newperson = new LegalPerson
            {
                CNPJ = person.CNPJ,
                Company_Name= person.Company_Name,
                Responsible=person.Responsible,
                PhoneList= ConvertPhoneListTo(person.PhoneList),
                AddressList= ConvertAddressListTo(person.AddressList)
            };

            var data = LegalPersonRepository.Add(newperson);

            return data != 0;
        }

        public IEnumerable<LegalPersonDTO> FindLegalPersons()
        {
            var data = LegalPersonRepository.FindAllLegalPersons();

            return data.Select(person => new LegalPersonDTO()
            {
                Id = person.Id,
                Company_Name = person.Company_Name,
                CNPJ = person.CNPJ,
                Responsible = person.Responsible,
                AddressList = ConvertAddressListTo(person.AddressList),
                PhoneList = ConvertPhoneListTo(person.PhoneList),
            }).ToList();
        }

        public LegalPersonDTO FindLegalPersonsBy(string company)
        {
            var data = LegalPersonRepository.FindAllLegalPersons(company);

            return new LegalPersonDTO()
            {
                Id = data.Id,
                Company_Name = data.Company_Name,
                CNPJ = data.CNPJ,
                Responsible = data.Responsible,
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
