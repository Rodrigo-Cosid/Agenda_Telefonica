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
using System.Net.Security;

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
            if (MessageBox.Show("Deseja Sair da Aplicação?", "Sair", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
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
          
            XmlDocument DataContact = new();
            DataContact.Load(@"..\contato.xml");

            if (TxtName.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha campo Nome", "Cadastro de Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtName.Text = "";
                TxtName.Focus();
                return;
            }

            if (TxtContactNo.Text.ToString().Trim() == "(  )      -")
            {
                MessageBox.Show("Preencha campo Numero de Telefone", "Cadastro de Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtContactNo.Text = "";
                TxtContactNo.Focus();
                return;
            }

                try
                {
                    XmlElement Contact = DataContact.CreateElement("Contact");
                    XmlElement Name = DataContact.CreateElement("Name");
                    XmlElement DDI = DataContact.CreateElement("DDI");
                    XmlElement ContactNo = DataContact.CreateElement("ContactNo");
                    XmlElement Address = DataContact.CreateElement("Address");
                    XmlElement HouseNo = DataContact.CreateElement("HouseNo");
                    XmlElement District = DataContact.CreateElement("District");
                    XmlElement City = DataContact.CreateElement("City");

                    Name.InnerText = this.TxtName.Text.Trim();
                    DDI.InnerText = this.ComboBoxDDI.Text.Trim();
                    ContactNo.InnerText = this.TxtContactNo.Text.Trim();
                    Address.InnerText = this.TxtAddress.Text.Trim();
                    HouseNo.InnerText = this.TxtHouseNo.Text.Trim();
                    District.InnerText = this.TxtDistrict.Text.Trim();
                    City.InnerText = this.TxtCity.Text.Trim();

                    Contact.AppendChild(Name);
                    Contact.AppendChild(DDI);
                    Contact.AppendChild(ContactNo);
                    Contact.AppendChild(Address);
                    Contact.AppendChild(HouseNo);
                    Contact.AppendChild(District);
                    Contact.AppendChild(City);

                    DataContact.DocumentElement.AppendChild(Contact);
                    DataContact.Save(@"..\contato.xml");

                    TxtName.Clear();
                    TxtContactNo.Clear();
                    TxtAddress.Clear();
                    TxtHouseNo.Clear();
                    TxtDistrict.Clear();
                    TxtCity.Clear();
            
                MessageBox.Show("Salvo com sucesso", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception) {}
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtContactNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtContactNo_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
