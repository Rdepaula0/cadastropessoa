using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP.Repository;
using CP.Domain;
using CP.Controller;
using CP.DTO;

namespace CP.Test
{
    [TestClass]
    public class UserControllerTest
    {
        #region Proprietes

        private UserController _usercontroller;

        private UserController UserController => _usercontroller ?? (_usercontroller = new UserController());

        #endregion

        [TestMethod]
        public void save_user_with_success()
        {
            var newitem = new UserDTO
            {
                Email = "test@test.com",
                Password = "12"
            };

            var result = UserController.AddUser(newitem);

            Assert.IsNotNull(result, "cannot save");
        }

        [TestMethod]
        public void find_all_user_success()
        {            
            var result = UserController.FindAll();

            Assert.IsNotNull(result, "cannot find");
        }


        [TestMethod]
        public void find_user_success()
        {
            var result = UserController.FindUser("test@test.com","12");

            Assert.IsNotNull(result, "cannot find");
        }
    }
}
