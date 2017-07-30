using ScoreKeepWeb.Models;
using ScoreKeepWeb.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeepWeb.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private AppDbContext context;

        public UsersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.Users.ToList();
        }
    }
}
