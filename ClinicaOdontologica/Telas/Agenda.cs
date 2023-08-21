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
            GridAtualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void GridAtualizar()
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
