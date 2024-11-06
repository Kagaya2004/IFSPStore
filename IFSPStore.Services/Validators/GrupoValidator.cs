using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class GrupoValidator : AbstractValidator<Grupo>
    {
        public GrupoValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome do grupo.")
                .NotNull().WithMessage("Por favor informe o nome do grupo.");
        }
    }
}
