using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Core.Enums;
using VivaSaude.Core.FormulesMath;

namespace VivaSaude.Core.Entities
{
    public class User
    {
        public User(string nome, int idade, double peso, double altura, EnumGenero genero, EnumNivelAtividade nivelAtividade)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura / 100; // Metros para Cm
            Genero = genero;
            NivelAtividade = nivelAtividade;
            UserStatus = EnumUserStatus.Ativo;

            Imc = ImcCalculation.ImcCalc(Peso, Altura);
            SetImcStatus();
            Tdee = TdeeCalc(Peso, Altura, Idade);
            UserStatus = EnumUserStatus.Ativo;
           
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; set; }
        public double Peso { get; private set; }
        public double Altura { get; private set; } 
        public double Imc { get; private set; }
        public double Tdee { get; private set; } 
        public EnumGenero Genero { get; private set; }
        public EnumNivelAtividade NivelAtividade { get; private set; }
        public EnumImcStatus ImcStatus { get; private set; }
        public EnumUserStatus UserStatus { get; private set; }


        public void Update(int idade, double peso, double altura, EnumNivelAtividade nivelAtividade)
        {
            Idade = idade;
            Peso = peso;
            Altura = altura / 100;
            NivelAtividade = nivelAtividade;
        }

        public void Delete()
        {
            UserStatus = EnumUserStatus.Inativo;
        }

        public void SetImcStatus() 
        {
            if (Imc < 18.5)
            {
                ImcStatus = EnumImcStatus.Magreza;
            }
            else if (Imc >= 18.5 && Imc <= 24.9)
            {
                ImcStatus = EnumImcStatus.Saudavel;
            }
            else if (Imc >= 25.0 && Imc <= 29.9)
            {
                ImcStatus = EnumImcStatus.Sobrepeso;
            }
            else if (Imc >= 30.0 && Imc <= 34.9)
            {
                ImcStatus = EnumImcStatus.ObesidadeGrau1;
            }
            else if (Imc >= 35.0 && Imc <= 39.9)
            {
                ImcStatus = EnumImcStatus.ObesidadeGrau2;
            }
            else if (Imc >= 40)
            {
                ImcStatus = EnumImcStatus.ObesidadeGrau3;
            }
            else
            {
                ImcStatus = EnumImcStatus.Desconhecido;
            }
        }

        public double TdeeCalc(double peso, double altura, int idade)
        {
            if(Genero == EnumGenero.Feminino)
            {
                return TdeeCalculation.TmbFeminino(peso, altura, idade) * ActivityFator();
            }
            else if(Genero == EnumGenero.Masculino) 
            {
                return TdeeCalculation.TmbMasculino(peso, altura, idade) * ActivityFator();
            }
            else
            {
                return 0;
            }
        }

        public double ActivityFator()
        {
            double factor = 0;

            if(NivelAtividade == EnumNivelAtividade.Sedentario)
            {
                factor = 1.2;
            }

            else if(NivelAtividade == EnumNivelAtividade.Leve)
            {
                factor = 1.375;
            }

            else if(NivelAtividade == EnumNivelAtividade.Moderado)
            {
                factor = 1.55;
            }

            else if(NivelAtividade == EnumNivelAtividade.Intenso)
            {
                factor = 1.725;
            }

            else if(NivelAtividade == EnumNivelAtividade.MuitoIntenso)
            {
                factor = 1.9;
            }

            return factor;
        }
    }
}
