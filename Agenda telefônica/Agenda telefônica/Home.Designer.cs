namespace Agenda_telefônica
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelHigher = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ListView = new System.Windows.Forms.ListView();
            this.ClName = new System.Windows.Forms.ColumnHeader();
            this.ClDDI = new System.Windows.Forms.ColumnHeader();
            this.ClTelephone = new System.Windows.Forms.ColumnHeader();
            this.ClAddress = new System.Windows.Forms.ColumnHeader();
            this.ClHouseNo = new System.Windows.Forms.ColumnHeader();
            this.ClDistric = new System.Windows.Forms.ColumnHeader();
            this.ClCity = new System.Windows.Forms.ColumnHeader();
            this.BtnToAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PanelHigher.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHigher
            // 
            this.PanelHigher.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PanelHigher.Controls.Add(this.lblTitle);
            this.PanelHigher.Location = new System.Drawing.Point(0, 0);
            this.PanelHigher.Name = "PanelHigher";
            this.PanelHigher.Size = new System.Drawing.Size(1204, 100);
            this.PanelHigher.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(338, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(498, 75);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Agenda Telefônica";
            this.lblTitle.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // ListView
            // 
            this.ListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ListView.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClName,
            this.ClDDI,
            this.ClTelephone,
            this.ClAddress,
            this.ClHouseNo,
            this.ClDistric,
            this.ClCity});
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            this.ListView.Location = new System.Drawing.Point(94, 192);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(1000, 500);
            this.ListView.TabIndex = 1;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged_1);
            // 
            // ClName
            // 
            this.ClName.Text = "NOME";
            this.ClName.Width = 310;
            // 
            // ClDDI
            // 
            this.ClDDI.Text = "DDI";
            this.ClDDI.Width = 200;
            // 
            // ClTelephone
            // 
            this.ClTelephone.Text = "TELEFÔNE";
            this.ClTelephone.Width = 200;
            // 
            // ClAddress
            // 
            this.ClAddress.Text = "ENDEREÇO";
            this.ClAddress.Width = 400;
            // 
            // ClHouseNo
            // 
            this.ClHouseNo.Text = "Nº";
            this.ClHouseNo.Width = 55;
            // 
            // ClDistric
            // 
            this.ClDistric.Text = "Bairro";
            this.ClDistric.Width = 100;
            // 
            // ClCity
            // 
            this.ClCity.Text = "Cidade";
            this.ClCity.Width = 100;
            // 
            // BtnToAdd
            // 
            this.BtnToAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnToAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnToAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnToAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnToAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnToAdd.Image = global::Agenda_telefônica.Properties.Resources.ADD_Contato;
            this.BtnToAdd.Location = new System.Drawing.Point(94, 125);
            this.BtnToAdd.Name = "BtnToAdd";
            this.BtnToAdd.Size = new System.Drawing.Size(50, 55);
            this.BtnToAdd.TabIndex = 2;
            this.BtnToAdd.UseVisualStyleBackColor = false;
            this.BtnToAdd.Click += new System.EventHandler(this.BntAdicionar_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEdit.Image = global::Agenda_telefônica.Properties.Resources.Edit_Contato;
            this.BtnEdit.Location = new System.Drawing.Point(150, 125);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(50, 55);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BntEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Image = global::Agenda_telefônica.Properties.Resources.Delete_Contato;
            this.BtnDelete.Location = new System.Drawing.Point(206, 125);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(50, 55);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(842, 148);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(206, 23);
            this.TxtSearch.TabIndex = 5;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSearch.Image = global::Agenda_telefônica.Properties.Resources.Pesquisa;
            this.BtnSearch.Location = new System.Drawing.Point(1054, 134);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(40, 37);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1188, 749);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnToAdd);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.PanelHigher);
            this.Name = "Home";
            this.Text = "Agenda Telefônica";
            this.Load += new System.EventHandler(this.Home_Load);
            this.PanelHigher.ResumeLayout(false);
            this.PanelHigher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelHigher;
        private Label lblTitle;
        private ListView ListView;
        private Button BtnToAdd;
        private Button BtnEdit;
        private Button BtnDelete;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private ColumnHeader ClName;
        private ColumnHeader ClTelephone;
        private ColumnHeader ClAddress;
        private ColumnHeader ClDDI;
        private ColumnHeader ClHouseNo;
        private ColumnHeader ClDistric;
        private ColumnHeader ClCity;
    }
}