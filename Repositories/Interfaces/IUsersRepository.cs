using ScoreKeepWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeepWeb.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAllUsers();
    }
}
