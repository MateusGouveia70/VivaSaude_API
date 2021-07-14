using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Application.InputModels;
using VivaSaude.Application.Services;
using VivaSaude.Application.ViewModels;
using VivaSaude.Core.Entities;
using VivaSaude.Core.Repository;
using VivaSaude.Infrastructure.Persistence;
using VivaSaude.Infrastructure.Persistence.Repository;

namespace VivaSaude.Application.Repositories.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserViewModel>> FindAll(string query)
        {
            var userView = await _userRepository.FindAllAsync();

            var usersViewModels = userView
                .Select(u => new UserViewModel(
                    u.Id,
                    u.Nome,
                    u.Id,
                    u.Peso.ToString("F2", CultureInfo.InvariantCulture),
                    u.Altura.ToString("F2", CultureInfo.InvariantCulture))).ToList();

            return  usersViewModels;

          
        }

        public async Task<UserDetailsViewModel> FindById(int id)
        {
            var user = await _userRepository.FindByIdAsync(id);

            var userDetails = new UserDetailsViewModel(
                user.Id,
                user.Nome,
                user.Idade,
                user.Peso.ToString("F2", CultureInfo.InvariantCulture),
                user.Altura.ToString("F2", CultureInfo.InvariantCulture),
                user.Imc.ToString("F2", CultureInfo.InvariantCulture),
                user.Tdee.ToString("F2", CultureInfo.InvariantCulture),
                EnumDescription.GetEnumDescription(user.Genero),
                EnumDescription.GetEnumDescription(user.NivelAtividade),
                EnumDescription.GetEnumDescription(user.ImcStatus),
                EnumDescription.GetEnumDescription(user.UserStatus)
                );            

            return userDetails; 
        }

        public async Task<int> CreateUser(UserInputModel model)
        {
            var user = new User(
                model.Nome,
                model.Idade,
                model.Peso,
                model.Altura,
                model.Genero,
                model.NivelAtividade);

            await _userRepository.CreateAsync(user);

            return user.Id;
        }

        public async Task UpdateUser(UpdateUserInputModel model) 
        {
            var user = await _userRepository.FindByIdAsync(model.Id);


            user.Update(model.Idade, model.Peso, model.Altura, model.NivelAtividade);

            await _userRepository.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var user = await _userRepository.FindByIdAsync(id);

            user.Delete();

            await _userRepository.SaveChangesAsync();
        }
       
    }
}
