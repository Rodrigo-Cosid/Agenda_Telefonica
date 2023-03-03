using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Linq;
using System.Xml;
using System.Runtime.Serialization.DataContracts;
using System.Xml.XPath;

namespace Agenda_telefônica
{
    public partial class EditContact : Form
    {
        public string NameLV { get; set; }
        public string DDILV { get; set; }
        public string ContactNoLV { get; set; }
        public string AddressLV { get; set; }
        public string HouseNoLV { get; set; }
        public string DistrictLV { get; set; }
        public string CityLV { get; set; }


        public EditContact()
        { 
            InitializeComponent(); 
        }
            
        private void BntCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar está alteração?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Home cancelADD = new();
                cancelADD.ShowDialog();
            }

        }

        private void TxtNumber_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TxtNameEdit.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha campo Nome", "Cadastro de Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNameEdit.Text = "";
                TxtNameEdit.Focus();
                return;
            }

            if (TxtContactNoEdit.Text.ToString().Trim() == "(  )      -")
            {
                MessageBox.Show("Preencha campo Numero de Telefone", "Cadastro de Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtContactNoEdit.Text = "";
                TxtContactNoEdit.Focus();
                return;
            }

           
            MessageBox.Show("Salvo com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Home start = new();
                start.ShowDialog();
        }
        
        private void Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditContact_Load(object sender, EventArgs e)
        {                      
            TxtNameEdit.Text = this.NameLV;
            ComboBoxDDIEdit.Text = this.DDILV;
            TxtContactNoEdit.Text = this.ContactNoLV;
            TxtAddressEdit.Text = this.AddressLV;
            TxtHouseNoEdit.Text = this.HouseNoLV;
            TxtDistrictEdit.Text = this.DistrictLV;
            TxtCityEdit.Text = this.CityLV;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PanelCenter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
