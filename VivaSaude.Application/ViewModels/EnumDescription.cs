using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace VivaSaude.Application.ViewModels
{
    public static class EnumDescription
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributs = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributs != null && attributs.Any())
            {
                return attributs.First().Description;
            }

            return value.ToString();
        }
    }
}
