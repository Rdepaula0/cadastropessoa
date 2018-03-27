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
    public class PhoneController
    {
        #region Proprietes

        private PhoneRepository _phoneRepository;

        private PhoneRepository PhoneRepository => _phoneRepository ?? (_phoneRepository = new PhoneRepository());

        #endregion

        public bool AddPhone(PhoneDTO person)
        {
            var newperson = new Phone
            {
                Number = person.Number,
                TypeNumber = person.TypeNumber
            };

            var data = PhoneRepository.Add(newperson);

            return data != 0;
        }

        public IEnumerable<PhoneDTO> FindPhone()
        {
            var data = PhoneRepository.FindAllPhone();

            return data.Select(person => new PhoneDTO()
            {
                Id = person.Id,
                Number = person.Number,
                TypeNumber = person.TypeNumber
            }).ToList();
        }

        public PhoneDTO FindPhone(string number)
        {
            var data = PhoneRepository.FindPhone(number);

            return new PhoneDTO()
            {
                Id = data.Id,
                Number = data.Number,
                TypeNumber = data.TypeNumber
            };
        }

    }
}
