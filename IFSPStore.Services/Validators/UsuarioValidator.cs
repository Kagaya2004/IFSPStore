using FluentValidation;
using IFSPStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome do usuário obrigatório.")
                .NotNull().WithMessage("Nome do usuário obrigatório.");
            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("Senha obrigatório.")
                .NotNull().WithMessage("Senha obrigatório.");
                //.MinimumLength(8).WithMessage("A senha precisa possuir,no mínimo, 8 caracteres")
                //.Matches(@"[A-Z]+").WithMessage("A senha precisa possuir, pelo menos, um caractere maíusculo.")
                //.Matches(@"[a-z]+").WithMessage("A senha precisa possuir, pelo menos, um caractere minúsculo")
                //.Matches(@"[0-9]+").WithMessage("A senha precisa possuir, pelo menos, um caractere numérico")
                //.Matches(@"[\!\?\*\.\@]+").WithMessage("a senha precisa possuir, pelo menos, um caractere desses caracteres: ! ? * .");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("E-mail obrigatório.")
                .NotNull().WithMessage("E-mail obrigatório.")
                .EmailAddress().WithMessage("E-mail inválido.");
            RuleFor(c => c.Login)
                .NotEmpty().WithMessage("Login obrigatório.")
                .NotNull().WithMessage("Login obrigatório.");
            RuleFor(c => c.DataCadastro)
                .NotEmpty().WithMessage("Data de Cadastro Obrigatória")
                .NotNull().WithMessage("Data de Cadastro Obrigatória");
            RuleFor(c => c.DataLogin)
                .NotEmpty().WithMessage("Data de Login Obrigatória")
                .NotNull().WithMessage("Data de Login Obrigatória");
        }
    }
}
