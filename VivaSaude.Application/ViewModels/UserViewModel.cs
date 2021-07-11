using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaSaude.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(int id, string nome, int idade, string peso, string altura)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Peso { get; private set; }
        public string Altura { get; private set; }


        

    }
}
