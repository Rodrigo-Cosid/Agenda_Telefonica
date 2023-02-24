using System.Xml.Linq;

namespace Agenda_telefônica
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListContact_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            XDocument ContactXML = XDocument.Load(@"..\contato.xml");

            foreach (var ListXML in ContactXML.Descendants("Contact"))
            {

                ListViewItem list = new ListViewItem(new string[]
                {
                    ListXML.Element("Name").Value,
                    ListXML.Element("DDI").Value,
                    ListXML.Element("ContactNo").Value,
                    ListXML.Element("Address").Value
                });

                ListContact.Items.Add(list);

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

        private void BntPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}