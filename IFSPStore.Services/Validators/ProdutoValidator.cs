using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto> 
    {
        public ProdutoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o produto.")
                .NotNull().WithMessage("Por favor informe o produto.");
            RuleFor(c => c.Preco)
                .NotEmpty().WithMessage("Por favor informe o preço.")
                .NotNull().WithMessage("Por favor informe o preço.");
            RuleFor(c => c.Quantidade)
                .NotEmpty().WithMessage("Por favor informe a quantidade.")
                .NotNull().WithMessage("Por favor informe a quantidade.")
                .LessThan(0).WithMessage("A quantidade deve ser acima de zero (0).");
            RuleFor(c => c.UnidadeVenda)
                .NotEmpty().WithMessage("Por favor informe a unidade de medida do produto.")
                .NotNull().WithMessage("Por favor informe a unidade de medida do produto.");
            RuleFor(c => c.Grupo)
                .NotEmpty().WithMessage("Por favor informe o grupo do produto.")
                .NotNull().WithMessage("Por favor informe o grupo do produto.");
        }
    }
}
