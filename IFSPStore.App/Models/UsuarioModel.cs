﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.App.Models
{
    public class UsuarioModel
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataLogin { get; set; }
        public bool Ativo { get; set; }
    }
}