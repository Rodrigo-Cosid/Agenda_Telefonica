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
        public void Record(string Name, string ContactNo, string Address, string HouseNo, string District, string City)
        {
            XmlTextWriter DataContact;
            DataContact = new XmlTextWriter("C:\\Users\\Rodrigo\\Documents\\GitHub-Agenda\\Agenda telefônica\\Agenda telefônica\\contato.xml", Encoding.UTF8);

            DataContact.WriteStartElement("contato");
            DataContact.WriteElementString("Name", Name.Trim());
            DataContact.WriteElementString("ContactNo", ContactNo.Trim());
            DataContact.WriteElementString("Address", Address.Trim());
            DataContact.WriteElementString("HouseNo", HouseNo.Trim());
            DataContact.WriteElementString("District", District.Trim());
            DataContact.WriteElementString("City", City.Trim());
            DataContact.WriteEndElement();
            DataContact.Close();

        }



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

            ContactXML.Record(TxtName.Text, TxtContactNo.Text, TxtAddress.Text, TxtHouseNo.Text, TxtDistrict.Text, txtCity.Text);
            TxtName.Text = "";
            TxtContactNo.Text = "";
            TxtAddress.Text = "";
            TxtHouseNo.Text = "";
            TxtDistrict.Text = "";
            txtCity.Text = "";


           
        }

    }
}
