using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Core.Entities;
using VivaSaude.Core.Enums;

namespace VivaSaude.Infrastructure.Persistence
{
    public class VivaSaudeDbContext
    {
        public VivaSaudeDbContext()
        {
            Users = new List<User>
            {
                new User(1, "Mateus", 27, 100, 176, EnumGenero.Masculino, EnumNivelAtividade.Leve),
                new User(2, "She-Ra", 52, 100, 167, EnumGenero.Feminino, EnumNivelAtividade.Sedentario),
                new User(3, "Marco", 19, 90, 177, EnumGenero.Masculino, EnumNivelAtividade.Sedentario),
                new User(4, "Venceslau", 54, 82, 174, EnumGenero.Masculino, EnumNivelAtividade.Sedentario)
            };
        }


        public List<User> Users { get; set; }
    }
}
