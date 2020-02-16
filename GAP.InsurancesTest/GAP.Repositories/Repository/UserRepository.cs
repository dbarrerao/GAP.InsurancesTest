using GAP.Models;
using GAP.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace GAP.Repositories.Repository
{
    public class UserRepository : IUserRepository
    {
        private IConfiguration _configuration;

        public UserRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User ValidateUser()
        {
            User user = new User();

            user.UserLogin = _configuration["Login:User"];
            user.Password = _configuration["Login:Password"];

            return user;        
        }
    }
}
