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
        List<string> disponibilidade = new List<string>();
        List<string> disponibilidadehora = new List<string>();
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
            cb_clientes.Text = "Cliente";
            cb_horario.Text = "Horario";
            cb_tratameto.Text = "Tipo Tratamento";
            mask_data.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            try
            {
                string ArquivoXml = "C:\\XmlClinica\\XmlClientes\\DocumentoXml.XML";
                XElement XML = XElement.Load(ArquivoXml);

                var nomeElements = XML.Descendants("Nome");

                foreach (var nomeElement in nomeElements)
                {
                    cb_clientes.Items.Add("Nome: " + nomeElement.Value);
                }

                cb_clientes.Enabled = true;
                cb_horario.Enabled = true;
                cb_tratameto.Enabled = true;
                mask_data.Enabled = true;

                cb_clientes.Text = "Cliente";
                cb_horario.Text= "Horario";
                cb_tratameto.Text = "Tipo Tratamento";
                mask_data.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                Tratamento t = new Tratamento();
                t.Cliente = cb_clientes.Text;
                t.Data = mask_data.Text;
                t.Horario = cb_horario.Text;
                t.TipoTratamento = cb_tratameto.Text;

                XmlCreator xmlCreator = new XmlCreator();
                xmlCreator.GravarXmlHorarios(t);

                cb_clientes.Text = "Cliente";
                cb_clientes.Enabled = false;
                cb_horario.Enabled = false;
                cb_tratameto.Enabled = false;
                mask_data.Enabled = false;

                MessageBox.Show("Agendamento concluido.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AgendarTratamento_Load(object sender, EventArgs e)
        {

        }
    }
}
