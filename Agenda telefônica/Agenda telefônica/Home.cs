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

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
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