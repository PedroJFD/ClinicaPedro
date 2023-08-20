using ClinicaOdontologica.Entidades;
using ClinicaOdontologica.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ClinicaOdontologica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Cidade = cb_cidade.Text;
            c.Nome = tx_nome.Text;
            c.Email = tx_email.Text;
            c.Telefone = tx_telefone.Text;

            XmlCreator xmlCreator = new XmlCreator();
            xmlCreator.GravarXml(c);

            tx_nome.Clear();
            tx_email.Clear();
            tx_telefone.Clear();
            cb_cidade.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
