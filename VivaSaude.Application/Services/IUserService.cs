using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Application.InputModels;
using VivaSaude.Application.ViewModels;

namespace VivaSaude.Application.Services
{
    public interface IUserService
    {
        Task<List<UserViewModel>> FindAll(string query);
        Task<UserDetailsViewModel> FindById(int id);
        Task<int> CreateUser(UserInputModel model);
        Task UpdateUser(int id,UpdateUserInputModel model);
        Task Delete(int id);
    }
}
