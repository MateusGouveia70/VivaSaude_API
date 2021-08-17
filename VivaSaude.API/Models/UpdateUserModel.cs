using VivaSaude.Core.Enums;

namespace VivaSaude.API.Models
{
    public class UpdateUserModel
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public EnumNivelAtividade NivelAtividade { get; set; } 
    }
}
