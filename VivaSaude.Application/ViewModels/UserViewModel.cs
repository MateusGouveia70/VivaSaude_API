using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaSaude.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(int id, string nome, int idade, double peso, double altura)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura / 100;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public double Peso { get; private set; }
        public double Altura { get; private set; }


    }
}
