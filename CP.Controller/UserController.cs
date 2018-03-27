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
    public class UserController
    {
        #region Proprietes

        private UserValeRepository _userRepository;

        private UserValeRepository UserRepository => _userRepository ?? (_userRepository = new UserValeRepository());

        #endregion

        public bool AddUser(UserDTO person)
        {
            var newitem = new UserVale
            {
                Email = person.Email,
                Password = person.Password
            };

            var data = UserRepository.Add(newitem);

            return data != 0;
        }

        public UserDTO FindUser(string email, string password)
        {
            var data = UserRepository.FindUser(email, password);

            return new UserDTO()
            {
                Email = data.Email,
                Password = data.Password
            };
        }

        public List<UserDTO> FindAll()
        {
            var data = UserRepository.FindAllUser().ToList();

            var person = new List<UserDTO>();
            foreach (var item in data)
            {
                person.Add(new UserDTO
                {
                    Email = item.Email,
                    Password = item.Password
                });

            }
            return person;
        }
    }
}
