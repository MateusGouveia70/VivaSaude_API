using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Core.Entities;
using VivaSaude.Core.Repository;

namespace VivaSaude.Infrastructure.Persistence.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly VivaSaudeDbContext _dbContext;

        public UserRepository(VivaSaudeDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task CreateAsync(User model)
        {
            await _dbContext.Users.AddAsync(model);
            await _dbContext.SaveChangesAsync();

        }

        public async Task<List<User>> FindAllAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> FindByIdAsync(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task SaveChangesAsync()
        {
             await _dbContext.SaveChangesAsync();
        }

    }
}
