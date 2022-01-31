using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using rest.src.Models.DAO;
using rest.src.Models.ORM;
namespace rest.src.Models.Repository
{
    public class UserRepository : RepositoryAbstract<User, AppDbContext>
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }
    }
}
