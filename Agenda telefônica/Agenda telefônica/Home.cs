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
using System.IO;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.XPath;

namespace Agenda_telefônica
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

                    
        private void ListContact()
        {
            ListView.Items.Clear();
            DataSet XmlContact = new();
                      
            XmlContact.ReadXml(@"..\contato.xml");

            ListViewItem item;

            foreach (DataRow ListXml in XmlContact.Tables["Contact"].Rows)

            {

                item = new ListViewItem(new string[] {
                    ListXml[ "Name" ].ToString(),
                    ListXml["DDI"].ToString(),
                    ListXml["ContactNo"].ToString(),
                    ListXml["Address"].ToString(),
                    ListXml["HouseNO"].ToString(),
                    ListXml["District"].ToString(),
                    ListXml["City"].ToString()});
               
                ListView.Items.Add(item);
                
            }
              
        }

        private void DataListView()
        {
            
            if (ListView.SelectedItems.Count>0)
            {

                this.Hide();
                EditContact Edit = new()
                {
                    NameLV = ListView.SelectedItems[0].Text,
                    DDILV = ListView.SelectedItems[0].SubItems[1].Text,
                    ContactNoLV = ListView.SelectedItems[0].SubItems[2].Text,
                    AddressLV = ListView.SelectedItems[0].SubItems[3].Text,
                    HouseNoLV = ListView.SelectedItems[0].SubItems[4].Text,
                    DistrictLV = ListView.SelectedItems[0].SubItems[5].Text,
                    CityLV = ListView.SelectedItems[0].SubItems[6].Text
                };

                Edit.Show();


            }
            else
            {
                MessageBox.Show("Nenhum contato Selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void ListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void ImgPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void BntEdit_Click(object sender, EventArgs e)
        {

            DataListView();
            

        }
      
        private void BntAdicionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddContact Add = new();
            Add.ShowDialog();
        }

      
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListView.Items)
            {
                
                if (item.SubItems[0].Text.ToLower().Contains( TxtSearch.Text.ToLower()))
                {
                    item.Selected = true;
                    ListView.TopItem = item;
                    ListView.Focus();
                                                     
                }
            }

        }
       
        private void Home_Load(object sender, EventArgs e)
        {
            ListContact();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }
              
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            XmlDocument DataContact = new();
            DataContact.Load(@"..\contato.xml");
            XPathNavigator Navigation = DataContact.CreateNavigator();

            if (ListView.SelectedItems.Count > 0)
            {

                if (MessageBox.Show("Deseja apagar este item?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Navigation.MoveToChild("contato", String.Empty);
                    Navigation.MoveToChild("Contact", String.Empty);
                   

                    Navigation.DeleteSelf();

                    Console.WriteLine("Position after delete: {0}", Navigation.Name);
                    Console.WriteLine(Navigation.OuterXml);
                    DataContact.Save(@"..\contato.xml");


                    foreach (ListViewItem item in ListView.Items)
                        if (item.Selected)
                        {
                            ListView.Items.RemoveAt(item.Index);
                           
                        }
                }
            }
            else
            {
                MessageBox.Show("Nenhum contato Selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
       
    }
}