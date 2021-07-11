﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaSaude.Core.FormulesMath
{
    public class TdeeCalculation
    {
        public static double TmbFeminino(double peso, double altura, int idade)
        {
            return 655 + (9.6 * peso) + (1.9 * altura) - (4.7 * idade);
        }
        
        public static double TmbMasculino(double peso, double altura, int idade)
        {
            return 66 + (13.8 * peso) + (5.0 * altura) - (6.8 * idade);
        }
    }
}


    