using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaOdontologica.Telas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void bt_agendar_Click(object sender, EventArgs e)
        {
            AgendarTratamento tratamento = new AgendarTratamento();
            tratamento.ShowDialog();
        }
    }
}
