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

namespace Agenda_telefônica
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void ListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
        private void ListContact()
        {
            DataSet XmlContact = new();

            ListView.Items.Clear();

            XmlContact.ReadXml(@"..\contato.xml");

            ListViewItem item;

            foreach (DataRow ListXml in XmlContact.Tables["Contact"].Rows)

            {

                item = new ListViewItem(new string[] {
                    ListXml[ "Name" ].ToString(),
                    ListXml["DDI"].ToString(),
                    ListXml["ContactNo"].ToString(),
                    ListXml["Address"].ToString()});

                ListView.Items.Add(item);
                
            }
              
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
                    this.Hide();
                    EditContact Edit = new();
                    Edit.ShowDialog();
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
                    ListView.Focus();
                    item.Selected = true;
                    ListView.TopItem = item;
                    break;

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
                        
            if (MessageBox.Show("Deseja apagar este item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (ListViewItem item in ListView.Items)
                    if (item.Selected)
                    {
                        ListView.Items.RemoveAt(item.Index); 
                       
                       
                    }
                
            }
           
        }
       
    }
}