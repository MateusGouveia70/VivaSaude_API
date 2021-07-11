using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Application.InputModels;
using VivaSaude.Application.ViewModels;
using VivaSaude.Core.Entities;
using VivaSaude.Infrastructure.Persistence;

namespace VivaSaude.Application.Repositories.UserService
{
    public class UserService : IUserService
    {
        private readonly VivaSaudeDbContext _dbContext;

        public UserService(VivaSaudeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<UserViewModel> FindAll(string query)
        { 
            var userView = _dbContext.Users
                .Select(u => new UserViewModel(
                    u.Id,
                    u.Nome,
                    u.Idade,
                    u.Peso.ToString("F2"),
                    u.Altura.ToString("F2"))).ToList();

            return userView;
               
        }

        public UserDetailsViewModel FindById(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            UserDetailsViewModel userView = new UserDetailsViewModel(
                user.Id,
                user.Nome,
                user.Idade,
                user.Peso.ToString("F2"),
                user.Altura.ToString("F2"),
                user.Imc.ToString("F2"),
                user.Tdee.ToString("F2"),
                user.Genero,
                user.NivelAtividade,
                user.ImcStatus
                );

            return userView; 
        }

        public int CreateUser(UserInputModel model)
        {
            var user = new User(
                model.Id,
                model.Nome,
                model.Idade,
                model.Peso,
                model.Altura,
                model.Genero,
                model.NivelAtividade);

            return user.Id;
        }

        public void UpdateUser(UpdateUserInputModel model)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == model.Id);


            user.Update(model.Idade, model.Altura, model.Altura, model.NivelAtividade);

        }

        public void Delete(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            user.Delete();
        }
       
    }
}
