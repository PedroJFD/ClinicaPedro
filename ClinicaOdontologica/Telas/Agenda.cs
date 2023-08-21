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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml("C:\\XmlClinica\\XmlHorarios\\DocumentoXmlHorarios.XML");

                if (dataSet.Tables.Count > 0)
                {
                    dataGridView1.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xml não existente ou vazia. Tente Agendar um tratamento primeiro.");
            }
        }
    }
}
