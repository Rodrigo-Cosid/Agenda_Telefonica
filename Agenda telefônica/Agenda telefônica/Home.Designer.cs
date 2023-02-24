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
            this.ListContact = new System.Windows.Forms.ListView();
            this.ClName = new System.Windows.Forms.ColumnHeader();
            this.ClTelephone = new System.Windows.Forms.ColumnHeader();
            this.ClAddress = new System.Windows.Forms.ColumnHeader();
            this.ClId = new System.Windows.Forms.ColumnHeader();
            this.BtnToAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            // ListContact
            // 
            this.ListContact.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ListContact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClName,
            this.ClTelephone,
            this.ClAddress,
            this.ClId});
            this.ListContact.FullRowSelect = true;
            this.ListContact.GridLines = true;
            this.ListContact.Location = new System.Drawing.Point(94, 192);
            this.ListContact.MultiSelect = false;
            this.ListContact.Name = "ListContact";
            this.ListContact.Size = new System.Drawing.Size(1000, 500);
            this.ListContact.TabIndex = 1;
            this.ListContact.UseCompatibleStateImageBehavior = false;
            this.ListContact.View = System.Windows.Forms.View.Details;
            this.ListContact.SelectedIndexChanged += new System.EventHandler(this.ListContact_SelectedIndexChanged_1);
            // 
            // ClName
            // 
            this.ClName.DisplayIndex = 1;
            this.ClName.Text = "NOME";
            this.ClName.Width = 310;
            // 
            // ClTelephone
            // 
            this.ClTelephone.DisplayIndex = 2;
            this.ClTelephone.Text = "TELEFÔNE";
            this.ClTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClTelephone.Width = 310;
            // 
            // ClAddress
            // 
            this.ClAddress.DisplayIndex = 3;
            this.ClAddress.Text = "ENDEREÇO";
            this.ClAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClAddress.Width = 400;
            // 
            // ClId
            // 
            this.ClId.DisplayIndex = 0;
            this.ClId.Text = "ID";
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
            this.BtnToAdd.Location = new System.Drawing.Point(94, 131);
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
            this.BtnEdit.Location = new System.Drawing.Point(165, 131);
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
            this.BtnDelete.Location = new System.Drawing.Point(235, 131);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(50, 55);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(842, 148);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(206, 23);
            this.txtSearch.TabIndex = 5;
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
            this.BtnSearch.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1188, 749);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnToAdd);
            this.Controls.Add(this.ListContact);
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
        private ListView ListContact;
        private ColumnHeader ClName;
        private ColumnHeader ClTelephone;
        private ColumnHeader ClAddress;
        private Button BtnToAdd;
        private Button BtnEdit;
        private Button BtnDelete;
        private TextBox txtSearch;
        private Button BtnSearch;
        private ColumnHeader ClId;
    }
}