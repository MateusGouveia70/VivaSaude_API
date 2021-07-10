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
                new User(1, "Mateus", 27, 100, 176, EnumGenero.Masculino, EnumNivelAtividade.Leve)
            };
        }


        public List<User> Users { get; set; }
    }
}
