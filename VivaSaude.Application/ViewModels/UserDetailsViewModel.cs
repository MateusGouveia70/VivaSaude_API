using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Core.Enums;

namespace VivaSaude.Application.ViewModels
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel(int id, string nome, int idade, string peso, string altura, string imc, string tdee, string genero, string nivelAtividade, string imcStatus)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
            Imc = imc;
            Tdee = tdee;
            Genero = genero;
            NivelAtividade = nivelAtividade;
            ImcStatus = imcStatus;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; set; }
        public string Peso { get; private set; }
        public string Altura { get; private set; }
        public string Imc { get; private set; }
        public string Tdee { get; private set; }
        public string Genero { get; private set; }
        public string NivelAtividade { get; private set; }
        public string ImcStatus { get; private set; }

    }
}
