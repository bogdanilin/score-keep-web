using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreKeepWeb.Models
{
    public class AppDbContextSeed
    {

        private AppDbContext context;

        public AppDbContextSeed(AppDbContext context)
        {
            this.context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(new List<User>
                {
                    new User(){FirstName = "Bogdan", LastName = "Ilin", Email = "bogdan.a.ilin@gmail.com"},
                    new User(){FirstName = "Donald", LastName = "Nairn"},
                    new User(){FirstName = "Eric", LastName = "Rousset"},
                    new User(){FirstName = "Lee", LastName = "Cockerill"},
                    new User(){FirstName = "Chris", LastName = "Warner"},
                    new User(){FirstName = "Fraser", LastName = "Stewart"},
                    new User(){FirstName = "Ross", LastName = "MacDonald"},
                    new User(){FirstName = "Calum", LastName = "Johnson"},
                    new User(){FirstName = "Basil", LastName = "Khan"},
                    new User(){FirstName = "Taha", LastName = "Khan"},
                    new User(){FirstName = "Fil", LastName = "DiCanto"},
                    new User(){FirstName = "Garry", LastName = "Anderson"}
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
