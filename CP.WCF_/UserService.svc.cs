using CP.WCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;
using CP.DTO;
using CP.Controller;

namespace CP.WCF
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class UserService : WebService, IUserService
    {
        #region Proprietes

        private UserController _userController;

        private UserController UserController => _userController ?? (_userController = new UserController());

        #endregion
               
        public bool CreateUser(UserDTO userdto)
        {
           return UserController.AddUser(userdto);
        }

        public List<UserDTO> FindAll()
        {
            return UserController.FindAll();
        }

        public UserDTO FindUser(string email, string password)
        {
            return UserController.FindUser(email, password);
        }
    }
}
