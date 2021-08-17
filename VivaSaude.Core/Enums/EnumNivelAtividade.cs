using System.ComponentModel;

namespace VivaSaude.Core.Enums
{
    public enum EnumNivelAtividade
    {
        [Description("Sedentário")]
        Sedentario = 0,
        [Description("Leve")]
        Leve = 1,
        [Description("Moderado")]
        Moderado = 2,
        [Description("Intenso")]
        Intenso = 3,
        [Description("Muito Intenso")]
        MuitoIntenso = 4
    }
}
