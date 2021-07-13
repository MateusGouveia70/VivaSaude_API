using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Core.Enums;

namespace VivaSaude.Application.InputModels
{
    public class UserInputModel
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public EnumGenero Genero { get; set; }
        public EnumNivelAtividade NivelAtividade { get; set; }  
    }
}
