using GAP.Business.Interfaces;
using GAP.Models;
using GAP.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Business.Business
{
    public class UserBusiness : IUserBusiness
    {
        private IUserRepository _userRepository;

        public UserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool ValidateUser(User userSignIn)
        {
            bool validate = false;
            User user = _userRepository.ValidateUser();

            if (userSignIn.UserLogin == user.UserLogin && userSignIn.Password == user.Password)
                validate = true;

            return validate;
        }
    }
}
