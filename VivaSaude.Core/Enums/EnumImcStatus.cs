using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaSaude.Core.Enums
{
    public enum EnumImcStatus
    {
        [Description("Desconhecido")]
        Desconhecido = 0,
        [Description("Magreza")]
        Magreza = 1,
        [Description("Saudável")]
        Saudavel = 2,
        [Description("Sobrepeso")]
        Sobrepeso = 3,
        [Description("Obesidade Grau 1")]
        ObesidadeGrau1 = 4,
        [Description("Obesidade Grau 2")]
        ObesidadeGrau2 = 5,
        [Description("Obesidade Grau 3")]
        ObesidadeGrau3 = 6,
    }
}
 