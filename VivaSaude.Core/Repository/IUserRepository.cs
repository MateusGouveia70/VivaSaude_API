using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Core.Entities;

namespace VivaSaude.Core.Repository
{
    public interface IUserRepository
    {
        Task <List<User>> FindAllAsync();
        Task<User> FindByIdAsync(int id);
        Task CreateAsync(User model);
        Task SaveChangesAsync();
        
    }
}
 