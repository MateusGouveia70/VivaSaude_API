using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaSaude.Application.InputModels;

namespace VivaSaude.Application.Validators
{
    public class UpdateUserInputModelValidator : AbstractValidator<UpdateUserInputModel>
    {
        public UpdateUserInputModelValidator()
        {
            RuleFor(u => u.Idade)
              .GreaterThan(0)
              .LessThan(150)
              .WithMessage("A idade ser maior que 0 e menor que 150 Anos");

            RuleFor(u => u.Peso)
                .GreaterThan(0)
                .LessThan(500)
                .WithMessage("O peso deve ser maior que 1kg e menor que 500 Kg");

            RuleFor(u => u.Altura)
               .Must(AlturaValidation)
               .WithMessage("A altura não deve conter pontos ou vígulas");

            RuleFor(u => u.Altura)
                .GreaterThan(0)
                .LessThan(400)
                .WithMessage("A altura deve ser maior que 0 e menor que 400 Cm");
        }

        private bool AlturaValidation(double altura)
        {
            var chars = new char[] { '.', ',' };
            var contains = altura.ToString().IndexOfAny(chars) >= 0; // Se achar . ou , retorna 0 ou 1 (Verdadeiro)

            return !contains;

        }
    }
}
