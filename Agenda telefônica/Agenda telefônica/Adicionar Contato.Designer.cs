namespace Agenda_telefônica
{
    partial class AddContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHigher = new System.Windows.Forms.Panel();
            this.imgAdd = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblDDI = new System.Windows.Forms.Label();
            this.ComboBoxDDI = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtDistrict = new System.Windows.Forms.TextBox();
            this.TxtHouseNo = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtContactNo = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblRuaAv = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelHigher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdd)).BeginInit();
            this.PanelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHigher
            // 
            this.panelHigher.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelHigher.Controls.Add(this.imgAdd);
            this.panelHigher.Controls.Add(this.lblTitle);
            this.panelHigher.Location = new System.Drawing.Point(0, 0);
            this.panelHigher.Name = "panelHigher";
            this.panelHigher.Size = new System.Drawing.Size(1204, 100);
            this.panelHigher.TabIndex = 1;
            // 
            // imgAdd
            // 
            this.imgAdd.Image = global::Agenda_telefônica.Properties.Resources.add;
            this.imgAdd.Location = new System.Drawing.Point(22, 9);
            this.imgAdd.Name = "imgAdd";
            this.imgAdd.Size = new System.Drawing.Size(70, 80);
            this.imgAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAdd.TabIndex = 2;
            this.imgAdd.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(338, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(486, 75);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Adicionar Contato";
            // 
            // PanelCenter
            // 
            this.PanelCenter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PanelCenter.Controls.Add(this.LblNumero);
            this.PanelCenter.Controls.Add(this.LblDDI);
            this.PanelCenter.Controls.Add(this.ComboBoxDDI);
            this.PanelCenter.Controls.Add(this.btnSalvar);
            this.PanelCenter.Controls.Add(this.btnSair);
            this.PanelCenter.Controls.Add(this.TxtCity);
            this.PanelCenter.Controls.Add(this.TxtDistrict);
            this.PanelCenter.Controls.Add(this.TxtHouseNo);
            this.PanelCenter.Controls.Add(this.TxtAddress);
            this.PanelCenter.Controls.Add(this.TxtContactNo);
            this.PanelCenter.Controls.Add(this.TxtName);
            this.PanelCenter.Controls.Add(this.lblCity);
            this.PanelCenter.Controls.Add(this.lblBairro);
            this.PanelCenter.Controls.Add(this.lblN);
            this.PanelCenter.Controls.Add(this.lblRuaAv);
            this.PanelCenter.Controls.Add(this.lblAddress);
            this.PanelCenter.Controls.Add(this.lblTelephone);
            this.PanelCenter.Controls.Add(this.lblName);
            this.PanelCenter.Location = new System.Drawing.Point(96, 174);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(1000, 500);
            this.PanelCenter.TabIndex = 2;
            this.PanelCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNumero.Location = new System.Drawing.Point(163, 183);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(92, 16);
            this.LblNumero.TabIndex = 21;
            this.LblNumero.Text = "DDD+Número";
            this.LblNumero.Click += new System.EventHandler(this.LblNumero_Click);
            // 
            // LblDDI
            // 
            this.LblDDI.AutoSize = true;
            this.LblDDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDDI.Location = new System.Drawing.Point(43, 183);
            this.LblDDI.Name = "LblDDI";
            this.LblDDI.Size = new System.Drawing.Size(33, 16);
            this.LblDDI.TabIndex = 20;
            this.LblDDI.Text = "DDI";
            this.LblDDI.Click += new System.EventHandler(this.LblDDI_Click);
            // 
            // ComboBoxDDI
            // 
            this.ComboBoxDDI.FormattingEnabled = true;
            this.ComboBoxDDI.Items.AddRange(new object[] {
            "Afeganistão:+93",
            "África do Sul:+27",
            "Albânia: +355",
            "Alemanha: +49",
            "Andorra: +376",
            "Angola: +244",
            "Anguilla: +1",
            "Antígua e Barbuda: +1",
            "Antilhas Holandesas: +599",
            "Arábia Saudita: +966",
            "Argélia: +213",
            "Argentina: +54",
            "Armênia: +374",
            "Aruba: +297",
            "Ascensão: +247",
            "Austrália: +61",
            "Áustria: +43",
            "Azerbaidjão: +994",
            "Bahamas: +1",
            "Bangladesh: +880",
            "Barbados: +1",
            "Barein: +973",
            "Bélgica: +32",
            "Belize: +501",
            "Benim: +229",
            "Bermudas: +1",
            "Bielorrússia: +375",
            "Bolívia: +591",
            "Bósnia e Herzegovina: +387",
            "Botswana: +267",
            "Brunei: +673",
            "Bulgária: +359",
            "Burkina Faso: +226",
            "Burundi: +257",
            "Butão: +975",
            "Brasil: +55",
            "Cabo Verde: +238",
            "Camarões: +237",
            "Camboja: +855",
            "Canadá: +1",
            "Cazaquistão: +7",
            "Chade: +237",
            "Chile: +56",
            "Chipre: +357",
            "Colômbia: +57",
            "Comores: +269",
            "Congo-Brazzaville: +242",
            "Congo-Kinshasa: +243",
            "Coreia do Norte: +850",
            "Coreia do Sul: +82",
            "Costa do Marfim: +225",
            "Costa Rica: +506",
            "Croácia: +385",
            "Cuba: +53",
            "Dinamarca: +45",
            "Djibuti: +253",
            "Dominica: +1",
            "Egito: +20",
            "El Salvador: +503",
            "Emirados Árabes Unidos: +971",
            "Equador: +593",
            "Eritreia: +291",
            "Eslováquia: +421",
            "Eslovênia: +386",
            "Espanha: +34",
            "Estados Federados da Micronésia: +691",
            "Estados Unidos: +1",
            "Estonia: +372",
            "Etiópia: +251",
            "Fiji: +679",
            "Filipinas: +63",
            "Finlândia: +358",
            "França: +33",
            "Gabão: +241",
            "Gambia: +220",
            "Gana: +233",
            "Geórgia: +995",
            "Gibraltar: +350",
            "Granada: +1",
            "Grécia: +30",
            "Groenlândia: +299",
            "Guadalupe: +590",
            "Guam: +671",
            "Guatemala: +502",
            "Guiana: +592",
            "Guiana Francesa: +594",
            "Guiné: +224",
            "Guiné-Bissau: +245",
            "Guiné Equatorial: +240",
            "Haiti: +509",
            "Honduras: +504",
            "Hong Kong: +852",
            "Hungria: +36",
            "Iêmen: +967",
            "Ilhas Cayman: +1",
            "Ilha Christmas: +672",
            "Ilhas Cocos: +672",
            "Ilhas Cook: +682",
            "Ilhas Féroe: +298",
            "Ilha Heard e Ilhas McDonald: +672",
            "Maldivas: +960",
            "Ilhas Malvinas: +500",
            "Ilhas Marianas do Norte: +1",
            "Ilhas Marshall: +692",
            "Ilha Norfolk: +672",
            "Ilhas Salomão: +677",
            "Ilhas Virgens Americanas: +1",
            "Ilhas Virgens Britânicas: +1",
            "Índia: +91",
            "Indonésia: +62",
            "Irã: +98",
            "Iraque: +964",
            "Irlanda: +353",
            "Islândia: +354",
            "Israel: +972",
            "Itália: +39",
            "Jamaica: +1",
            "Japão: +81",
            "Jordânia: +962",
            "Kiribati: +686",
            "Kosovo: +383",
            "Kuwait: +965",
            "Laos: +856",
            "Lesoto: +266",
            "Letônia: +371",
            "Líbano: +961",
            "Libéria: +231",
            "Líbia: +218",
            "Liechtenstein: +423",
            "Lituânia: +370",
            "Luxemburgo: +352",
            "Macau: +853",
            "Madagascar: +261",
            "Malásia: +60",
            "Malawi: +265",
            "Mali: +223",
            "Malta: +356",
            "Marrocos: +212",
            "Martinica: +596",
            "Maurícia: +230",
            "Mauritânia: +222",
            "Mayotte: +269",
            "México: +52",
            "Moçambique: +258",
            "Moldávia: +373",
            "Mônaco: +377",
            "Mongólia: +976;",
            "Montenegro: +382",
            "Montserrat: +1",
            "Myanmar: +95",
            "Namíbia: +264",
            "Nauru: +674",
            "Nepal: +977;",
            "Nicarágua: +505",
            "Níger: +227",
            "Nigéria: +234",
            "Niue: +683",
            "Noruega: +47",
            "Nova Caledônia: +687",
            "Nova Zelândia: +64",
            "Omã: +968",
            "Países Baixos: +31",
            "Palau: +680",
            "Palestina: +970",
            "Panamá: +507",
            "Papua-Nova Guiné: +675",
            "Paquistão: +92",
            "Paraguai: +595",
            "Peru: +51",
            "Polinésia Francesa: +689",
            "Polônia: +48",
            "Porto Rico: +1",
            "Portugal: +351",
            "Qatar: +974",
            "Quênia: +254",
            "Quirguistão:+ 996",
            "Reino Unido:+44",
            "República Centro-Africana: +236",
            "República da China: +886",
            "República Popular da China: +86",
            "República Dominicana: +1",
            "República da Macedônia: +389",
            "República Tcheca: +420",
            "Reunião: +262",
            "Romênia: +40",
            "Ruanda: +250",
            "Rússia: +7",
            "Saara Ocidental: +212",
            "Samoa: +685",
            "amoa Americana: +1",
            "Santa Helena (território): +290",
            "Santa Lúcia: +1",
            "São Cristóvão e Nevis: +1",
            "São Marinho: +378",
            "Saint-Pierre e Miquelon: +508",
            "São Tomé e Príncipe: +239",
            "São Vicente e Granadinas: +1",
            "Seicheles: +248",
            "Senegal: +221",
            "Serra Leoa: +232",
            "Sérvia: +381",
            "Singapura: +65",
            "Síria: +963",
            "Somália: +252",
            "Sri Lanka: +94",
            "Suazilândia: +268",
            "Sudão: +249",
            "Sudão do Sul: +211",
            "Suécia: +46",
            "Suíça: +41",
            "Suriname: +597",
            "Tadjiquistão:+ 992",
            "Tailândia: +66",
            "Tanzânia: +255",
            "Território Britânico do Oceano Índico: +246",
            "Timor-Leste: +670",
            "Togo: +228",
            "Tokelau: +690",
            "Tonga: +676",
            "Trinidad e Tobago: +1",
            "Tunísia: +216",
            "Turcas e Caicos: +1",
            "Turquemenistão: +993",
            "Turquia: +90",
            "Tuvalu: +688",
            "Ucrânia: +380",
            "Uganda: +256",
            "Uruguai: +598",
            "Uzbequistão: +998",
            "Vanuatu: +678",
            "Vaticano: +379",
            "Venezuela: +58",
            "Vietnã: +84",
            "Wallis e Futuna: +681",
            "Zâmbia: +260",
            "Zimbábue: +263"});
            this.ComboBoxDDI.Location = new System.Drawing.Point(43, 202);
            this.ComboBoxDDI.Name = "ComboBoxDDI";
            this.ComboBoxDDI.Size = new System.Drawing.Size(114, 23);
            this.ComboBoxDDI.TabIndex = 19;
            this.ComboBoxDDI.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDDI_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(505, 464);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(416, 464);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 23);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BntCancelar_Click);
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(101, 349);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(189, 23);
            this.TxtCity.TabIndex = 16;
            this.TxtCity.TextChanged += new System.EventHandler(this.TxtCity_TextChanged);
            // 
            // TxtDistrict
            // 
            this.TxtDistrict.Location = new System.Drawing.Point(625, 295);
            this.TxtDistrict.Name = "TxtDistrict";
            this.TxtDistrict.Size = new System.Drawing.Size(210, 23);
            this.TxtDistrict.TabIndex = 15;
            // 
            // TxtHouseNo
            // 
            this.TxtHouseNo.Location = new System.Drawing.Point(474, 295);
            this.TxtHouseNo.Name = "TxtHouseNo";
            this.TxtHouseNo.Size = new System.Drawing.Size(45, 23);
            this.TxtHouseNo.TabIndex = 14;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(102, 296);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(325, 23);
            this.TxtAddress.TabIndex = 13;
            // 
            // TxtContactNo
            // 
            this.TxtContactNo.Location = new System.Drawing.Point(163, 202);
            this.TxtContactNo.Name = "TxtContactNo";
            this.TxtContactNo.Size = new System.Drawing.Size(180, 23);
            this.TxtContactNo.TabIndex = 12;
            this.TxtContactNo.TextChanged += new System.EventHandler(this.TxtNumber_TextChanged);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(43, 70);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(487, 23);
            this.TxtName.TabIndex = 10;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(43, 348);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(52, 20);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "Cidade";
            this.lblCity.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBairro.Location = new System.Drawing.Point(572, 299);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(47, 20);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "Bairro";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblN.Location = new System.Drawing.Point(445, 295);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(23, 20);
            this.lblN.TabIndex = 7;
            this.lblN.Text = "Nº";
            // 
            // lblRuaAv
            // 
            this.lblRuaAv.AutoSize = true;
            this.lblRuaAv.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRuaAv.Location = new System.Drawing.Point(43, 295);
            this.lblRuaAv.Name = "lblRuaAv";
            this.lblRuaAv.Size = new System.Drawing.Size(53, 20);
            this.lblRuaAv.TabIndex = 6;
            this.lblRuaAv.Text = "Rua/Av";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(43, 264);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "ENDEREÇO";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelephone.Location = new System.Drawing.Point(43, 151);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(79, 20);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "TELEFÔNE";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(43, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "NOME";
            this.lblName.Click += new System.EventHandler(this.LblNome_Click);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1188, 749);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.panelHigher);
            this.Name = "AddContact";
            this.Text = "Adicionar Contato";
            this.Load += new System.EventHandler(this.AdicionarContato_Load);
            this.panelHigher.ResumeLayout(false);
            this.panelHigher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdd)).EndInit();
            this.PanelCenter.ResumeLayout(false);
            this.PanelCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHigher;
        private PictureBox imgAdd;
        private Label lblTitle;
        private Panel PanelCenter;
        private Label lblAddress;
        private Label lblTelephone;
        private Label lblName;
        private Label lblCity;
        private Label lblBairro;
        private Label lblN;
        private Label lblRuaAv;
        private Button btnSalvar;
        private Button btnSair;
        private TextBox TxtCity;
        private TextBox TxtDistrict;
        private TextBox TxtHouseNo;
        private TextBox TxtAddress;
        private TextBox TxtContactNo;
        private TextBox TxtName;
        private ComboBox ComboBoxDDI;
        private Label LblNumero;
        private Label LblDDI;
    }
}