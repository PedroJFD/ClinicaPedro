using ClinicaOdontologica.Entidades;
using ClinicaOdontologica.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace ClinicaOdontologica.Telas
{
    public partial class AgendarTratamento : Form
    {

        public AgendarTratamento()
        {
            InitializeComponent();
        }

        private void cb_tratameto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            string ArquivoXml = "C:\\Users\\pedro\\source\\repos\\teste.XML";
            XElement XML = XElement.Load(ArquivoXml);

            var nomeElements = XML.Descendants("Nome");

            foreach (var nomeElement in nomeElements)
            {
                cb_clientes.Items.Add("Nome: " + nomeElement.Value);
            }

            cb_clientes.Enabled = true;
            cb_data.Enabled = true;
            cb_tratameto.Enabled = true;
            mask_data.Enabled = true;
        }
    }
}
