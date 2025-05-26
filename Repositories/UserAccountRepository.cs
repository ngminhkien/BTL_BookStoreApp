using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Repositories.Entities;

namespace Repositories
{
    public class UserAccountRepository
    {
        private DbdesignQlchBansachContext _context;

        public UserAccount? GetAccount(string email, string password)
        {
            _context = new();
            //return _context.UserAccounts.FirstOrDefault(x => PasswordHelper.VerifyPassword(x.Email) == email && x.Password == password);

            var user = _context.UserAccounts.FirstOrDefault(u => u.Email == email);

            if (user != null && PasswordHelper.VerifyPassword(password, user.Password))
            {
                return user; // Mật khẩu đúng → trả về tài khoản
            }

            return null; // Sai email hoặc mật khẩu
        }
    }
}
