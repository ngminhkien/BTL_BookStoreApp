using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Repositories.Entities;

namespace Services
{
    public class UserAcountService
    {
        private UserAccountRepository _repo = new();

        public UserAccount? CheckLogin(string email, string password)
        {
            return _repo.GetAccount(email, password);
        }
    }
}
