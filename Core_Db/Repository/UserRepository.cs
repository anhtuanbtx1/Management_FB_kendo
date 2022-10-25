using Core_Db.Domains;
using Core_Db.Interface;
using Microsoft.EntityFrameworkCore;
using PSafe.Core.SharedKernel;
using PSafe.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Db.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(footballContext context) : base(context)
        {
        }
    }
}
