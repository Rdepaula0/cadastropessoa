using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP.Repository;
using CP.Domain;

namespace CP.Test
{
    [TestClass]
    public class UserValeRepositoryTest
    {
        #region Proprietes

        private UserValeRepository _userRepository;

        private UserValeRepository UserRepository => _userRepository ?? (_userRepository = new UserValeRepository());

        #endregion

        [TestMethod]
        public void save_user_with_success()
        {
            var newitem = new UserVale
            {
                Email = "test@test.com",
                Password = "12"
            };

            var result = UserRepository.Add(newitem);

            Assert.IsNotNull(result, "cannot save");
        }

        [TestMethod]
        public void find_all_user_success()
        {            
            var result = UserRepository.FindAllUser();

            Assert.IsNotNull(result, "cannot find");
        }

        [TestMethod]
        public void find_user_by_email_success()
        {
            var result = UserRepository.FindUser("test@teste.com","12");

            Assert.IsNotNull(result, "cannot find");
        }
    }
}
