using VivaSaude.Core.Enums;

namespace VivaSaude.Application.InputModels
{
    public class UpdateUserInputModel
    {
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public EnumNivelAtividade NivelAtividade { get; set; }
    }
} 
