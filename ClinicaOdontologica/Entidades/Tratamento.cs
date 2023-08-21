using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologica.Entidades
{
    internal class Tratamento
    {
        public string Data { get; set; }
        public string Horario { get; set; }
        public string TipoTratamento { get; set; }

        public string Cliente { get; set; }

        public Tratamento()
        {

        }

        public Tratamento(string cliente, string data, string horario, string tipoTratamento)
        {
            this.Cliente = cliente;
            this.Data = data;
            this.Horario = horario;
            this.TipoTratamento = tipoTratamento;
        }


    }
}

