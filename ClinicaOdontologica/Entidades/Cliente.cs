using ClinicaOdontologica.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Entidades
{
    internal class Cliente
    {
        public string Nome { get; set; }    
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email, string telefone, string cidade)
        {
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Cidade = cidade;
        }

    }
}
