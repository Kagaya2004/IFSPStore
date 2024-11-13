using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome do cliente.")
                .NotNull().WithMessage("Por favor informe o nome do cliente.");
            RuleFor(c => c.Endereco)
                .NotEmpty().WithMessage("Por favor informe o endereço.")
                .NotNull().WithMessage("Por favor informe o endereço.");
            RuleFor(c => c.Documento)
                .NotEmpty().WithMessage("Por favor informe o documento.")
                .NotNull().WithMessage("Por favor informe o documento.")
                .MinimumLength(11).WithMessage("O documento precisa ter, no mínimo, 11 dígitos.");
            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("Por favor informe o bairro.")
                .NotNull().WithMessage("Por favor informe o bairro.");
            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("por favor informe a cidade.")
                .NotNull().WithMessage("Por favor informe a cidade.");
        }
    }
}
