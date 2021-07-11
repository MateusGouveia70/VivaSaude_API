using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Application.InputModels;
using VivaSaude.Application.ViewModels;
using VivaSaude.Core.Entities;

namespace VivaSaude.Application.Repositories
{
    public interface IUserService
    {
        List<UserViewModel> FindAll(string query);
        UserDetailsViewModel FindById(int id);
        int CreateUser(UserInputModel model);
        void UpdateUser(UpdateUserInputModel model);
        void Delete(int id);
    }
}
