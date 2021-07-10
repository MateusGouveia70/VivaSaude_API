using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaSaude.Core.FormulesMath
{
    public class ImcCalculation
    {
        public static double ImcCalc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }
    }
}
