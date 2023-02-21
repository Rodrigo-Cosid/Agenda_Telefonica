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

namespace Agenda_telefônica
{
    public partial class AddContact : Form
    {

        public AddContact()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblNome_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarContato_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BntCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar está Aplicação?", "Cancelar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Home cancelADD = new();
                cancelADD.ShowDialog();
            }
            
        }

        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxDDI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblDDI_Click(object sender, EventArgs e)
        {

        }

        private void LblNumero_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            AddContact ContactXML = new();



           
        }

    }
}
