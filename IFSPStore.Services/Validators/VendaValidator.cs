using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class VendaValidator : AbstractValidator<Venda>
    {
        public VendaValidator()
        {
            RuleFor(c => c.Data)
                .NotEmpty().WithMessage("Por favor informe a data da venda.")
                .NotNull().WithMessage("Por favor informe a data da venda.");
            RuleFor(c => c.ValorTotal)
                .NotEmpty().WithMessage("Por favor informe o valor total da venda.")
                .NotNull().WithMessage("Por favor informe o valor total da venda.")
                .LessThan(0).WithMessage("O valor total deve ser acima de zero (0).");
            RuleFor(c => c.Usuario)
                .NotEmpty().WithMessage("Por favor informe a quantidade.")
                .NotNull().WithMessage("Por favor informe a quantidade.");
            RuleFor(c => c.Cliente)
                .NotEmpty().WithMessage("Por favor informe a unidade de medida do produto.")
                .NotNull().WithMessage("Por favor informe a unidade de medida do produto.");
            RuleFor(c => c.Itens)
                .NotEmpty().WithMessage("Por favor informe o grupo do produto.")
                .NotNull().WithMessage("Por favor informe o grupo do produto.");
        }
    }

    public class VendaItemValidator : AbstractValidator<VendaItem>
    {
        public VendaItemValidator()
        {
            RuleFor(c => c.Produto)
                    .NotEmpty().WithMessage("Por favor informe o produto.")
                    .NotNull().WithMessage("Por favor informe o produto.");
            RuleFor(c => c.Quantidade)
                .NotEmpty().WithMessage("Por favor informe a quantidade.")
                .NotNull().WithMessage("Por favor informe a quantidade.")
                .LessThan(0).WithMessage("A quantidade deve ser acima de zero (0).");
            RuleFor(c => c.ValorUnitario)
                .NotEmpty().WithMessage("Por favor informe o valor unitário do item.")
                .NotNull().WithMessage("Por favor informe o valor unitário do item.")
                .LessThan(0).WithMessage("O valor unitário deve ser acima de zero (0).");
            RuleFor(c => c.ValorTotal)
                .NotEmpty().WithMessage("Por favor informe o valor total.")
                .NotNull().WithMessage("Por favor informe o valor total.")
                .LessThan(0).WithMessage("O valor total deve ser acima de zero (0).");
            RuleFor(c => c.Venda)
                .NotEmpty().WithMessage("Por favor informe o grupo do produto.")
                .NotNull().WithMessage("Por favor informe o grupo do produto.");
        }
    }
}
