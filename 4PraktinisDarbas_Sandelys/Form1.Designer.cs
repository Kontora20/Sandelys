namespace _4PraktinisDarbas_Sandelys
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTiekejai = new System.Windows.Forms.TabPage();
            this.btnIsregistruoti = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lstTiekejai = new System.Windows.Forms.ListBox();
            this.btnPridetiTiekeja = new System.Windows.Forms.Button();
            this.dateTimePickerTiekPabaiga = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTiekPradzia = new System.Windows.Forms.DateTimePicker();
            this.txtTiekImonesKodas = new System.Windows.Forms.TextBox();
            this.txtTiekImonesPav = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSutartis = new System.Windows.Forms.TabPage();
            this.btnNutraukti = new System.Windows.Forms.Button();
            this.buttonPratesti = new System.Windows.Forms.Button();
            this.dateTimePickerPratesti = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSutartisKodas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDatosPabaiga = new System.Windows.Forms.TextBox();
            this.txtDatosPradzia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstSutartysTiekejai = new System.Windows.Forms.ListBox();
            this.tabProduktai = new System.Windows.Forms.TabPage();
            this.btnUzsakytiSandeli = new System.Windows.Forms.Button();
            this.txtKiekis = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrekesKategorija = new System.Windows.Forms.TextBox();
            this.txtPrekesKaina = new System.Windows.Forms.TextBox();
            this.lstTiekejoPrekes = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstTiekejaiProduktai = new System.Windows.Forms.ListBox();
            this.tabSandelis = new System.Windows.Forms.TabPage();
            this.cmbPrekesPavSandelys = new System.Windows.Forms.ComboBox();
            this.cmbKategorijaSandelys = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pavadinimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SandelioKaina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Likutis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiekejoProduktoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFilterKat = new System.Windows.Forms.Button();
            this.btnFilterPav = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabTiekejai.SuspendLayout();
            this.tabSutartis.SuspendLayout();
            this.tabProduktai.SuspendLayout();
            this.tabSandelis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTiekejai);
            this.tabControl1.Controls.Add(this.tabSutartis);
            this.tabControl1.Controls.Add(this.tabProduktai);
            this.tabControl1.Controls.Add(this.tabSandelis);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 329);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabTiekejai
            // 
            this.tabTiekejai.Controls.Add(this.btnIsregistruoti);
            this.tabTiekejai.Controls.Add(this.label11);
            this.tabTiekejai.Controls.Add(this.lstTiekejai);
            this.tabTiekejai.Controls.Add(this.btnPridetiTiekeja);
            this.tabTiekejai.Controls.Add(this.dateTimePickerTiekPabaiga);
            this.tabTiekejai.Controls.Add(this.dateTimePickerTiekPradzia);
            this.tabTiekejai.Controls.Add(this.txtTiekImonesKodas);
            this.tabTiekejai.Controls.Add(this.txtTiekImonesPav);
            this.tabTiekejai.Controls.Add(this.label5);
            this.tabTiekejai.Controls.Add(this.label4);
            this.tabTiekejai.Controls.Add(this.label3);
            this.tabTiekejai.Controls.Add(this.label2);
            this.tabTiekejai.Controls.Add(this.label1);
            this.tabTiekejai.Location = new System.Drawing.Point(4, 22);
            this.tabTiekejai.Name = "tabTiekejai";
            this.tabTiekejai.Padding = new System.Windows.Forms.Padding(3);
            this.tabTiekejai.Size = new System.Drawing.Size(874, 303);
            this.tabTiekejai.TabIndex = 0;
            this.tabTiekejai.Text = "Tiekėjai";
            this.tabTiekejai.UseVisualStyleBackColor = true;
            // 
            // btnIsregistruoti
            // 
            this.btnIsregistruoti.Location = new System.Drawing.Point(335, 149);
            this.btnIsregistruoti.Name = "btnIsregistruoti";
            this.btnIsregistruoti.Size = new System.Drawing.Size(120, 23);
            this.btnIsregistruoti.TabIndex = 12;
            this.btnIsregistruoti.Text = "Išregistruoti";
            this.btnIsregistruoti.UseVisualStyleBackColor = true;
            this.btnIsregistruoti.Click += new System.EventHandler(this.btnIsregistruoti_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label11.Location = new System.Drawing.Point(336, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tiekėjų sąrašas";
            // 
            // lstTiekejai
            // 
            this.lstTiekejai.FormattingEnabled = true;
            this.lstTiekejai.Location = new System.Drawing.Point(335, 48);
            this.lstTiekejai.Name = "lstTiekejai";
            this.lstTiekejai.Size = new System.Drawing.Size(120, 95);
            this.lstTiekejai.TabIndex = 10;
            // 
            // btnPridetiTiekeja
            // 
            this.btnPridetiTiekeja.Location = new System.Drawing.Point(72, 162);
            this.btnPridetiTiekeja.Name = "btnPridetiTiekeja";
            this.btnPridetiTiekeja.Size = new System.Drawing.Size(117, 23);
            this.btnPridetiTiekeja.TabIndex = 9;
            this.btnPridetiTiekeja.Text = "Pridėti naują tiekėją";
            this.btnPridetiTiekeja.UseVisualStyleBackColor = true;
            this.btnPridetiTiekeja.Click += new System.EventHandler(this.btnPridetiTiekeja_Click);
            // 
            // dateTimePickerTiekPabaiga
            // 
            this.dateTimePickerTiekPabaiga.CustomFormat = "yyyy/M/d";
            this.dateTimePickerTiekPabaiga.Location = new System.Drawing.Point(117, 126);
            this.dateTimePickerTiekPabaiga.Name = "dateTimePickerTiekPabaiga";
            this.dateTimePickerTiekPabaiga.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerTiekPabaiga.TabIndex = 8;
            // 
            // dateTimePickerTiekPradzia
            // 
            this.dateTimePickerTiekPradzia.CustomFormat = "yyyy/M/d";
            this.dateTimePickerTiekPradzia.Location = new System.Drawing.Point(117, 100);
            this.dateTimePickerTiekPradzia.Name = "dateTimePickerTiekPradzia";
            this.dateTimePickerTiekPradzia.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerTiekPradzia.TabIndex = 7;
            // 
            // txtTiekImonesKodas
            // 
            this.txtTiekImonesKodas.Location = new System.Drawing.Point(117, 74);
            this.txtTiekImonesKodas.Name = "txtTiekImonesKodas";
            this.txtTiekImonesKodas.Size = new System.Drawing.Size(127, 20);
            this.txtTiekImonesKodas.TabIndex = 6;
            // 
            // txtTiekImonesPav
            // 
            this.txtTiekImonesPav.Location = new System.Drawing.Point(117, 48);
            this.txtTiekImonesPav.Name = "txtTiekImonesPav";
            this.txtTiekImonesPav.Size = new System.Drawing.Size(127, 20);
            this.txtTiekImonesPav.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sutarties pabaiga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sutarties pradžia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sutarties kodas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Įmonės pavadinimas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naujas tiekėjas";
            // 
            // tabSutartis
            // 
            this.tabSutartis.Controls.Add(this.btnNutraukti);
            this.tabSutartis.Controls.Add(this.buttonPratesti);
            this.tabSutartis.Controls.Add(this.dateTimePickerPratesti);
            this.tabSutartis.Controls.Add(this.label14);
            this.tabSutartis.Controls.Add(this.txtSutartisKodas);
            this.tabSutartis.Controls.Add(this.label8);
            this.tabSutartis.Controls.Add(this.label7);
            this.tabSutartis.Controls.Add(this.txtDatosPabaiga);
            this.tabSutartis.Controls.Add(this.txtDatosPradzia);
            this.tabSutartis.Controls.Add(this.label6);
            this.tabSutartis.Controls.Add(this.lstSutartysTiekejai);
            this.tabSutartis.Location = new System.Drawing.Point(4, 22);
            this.tabSutartis.Name = "tabSutartis";
            this.tabSutartis.Padding = new System.Windows.Forms.Padding(3);
            this.tabSutartis.Size = new System.Drawing.Size(874, 303);
            this.tabSutartis.TabIndex = 1;
            this.tabSutartis.Text = "Sutartis";
            this.tabSutartis.UseVisualStyleBackColor = true;
            // 
            // btnNutraukti
            // 
            this.btnNutraukti.Location = new System.Drawing.Point(467, 83);
            this.btnNutraukti.Name = "btnNutraukti";
            this.btnNutraukti.Size = new System.Drawing.Size(75, 23);
            this.btnNutraukti.TabIndex = 10;
            this.btnNutraukti.Text = "Nutraukti";
            this.btnNutraukti.UseVisualStyleBackColor = true;
            this.btnNutraukti.Click += new System.EventHandler(this.btnNutraukti_Click);
            // 
            // buttonPratesti
            // 
            this.buttonPratesti.Location = new System.Drawing.Point(467, 120);
            this.buttonPratesti.Name = "buttonPratesti";
            this.buttonPratesti.Size = new System.Drawing.Size(75, 23);
            this.buttonPratesti.TabIndex = 9;
            this.buttonPratesti.Text = "Pratęsti";
            this.buttonPratesti.UseVisualStyleBackColor = true;
            this.buttonPratesti.Click += new System.EventHandler(this.buttonPratesti_Click);
            // 
            // dateTimePickerPratesti
            // 
            this.dateTimePickerPratesti.Location = new System.Drawing.Point(301, 123);
            this.dateTimePickerPratesti.Name = "dateTimePickerPratesti";
            this.dateTimePickerPratesti.Size = new System.Drawing.Size(132, 20);
            this.dateTimePickerPratesti.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(175, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Pratęsti sutartį iki:";
            // 
            // txtSutartisKodas
            // 
            this.txtSutartisKodas.Location = new System.Drawing.Point(28, 165);
            this.txtSutartisKodas.Name = "txtSutartisKodas";
            this.txtSutartisKodas.Size = new System.Drawing.Size(138, 20);
            this.txtSutartisKodas.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sutartis galioja iki:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sutarties sudarymo data:";
            // 
            // txtDatosPabaiga
            // 
            this.txtDatosPabaiga.Location = new System.Drawing.Point(301, 91);
            this.txtDatosPabaiga.Name = "txtDatosPabaiga";
            this.txtDatosPabaiga.Size = new System.Drawing.Size(132, 20);
            this.txtDatosPabaiga.TabIndex = 3;
            // 
            // txtDatosPradzia
            // 
            this.txtDatosPradzia.Location = new System.Drawing.Point(301, 65);
            this.txtDatosPradzia.Name = "txtDatosPradzia";
            this.txtDatosPradzia.Size = new System.Drawing.Size(132, 20);
            this.txtDatosPradzia.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tiekėjai, su kuriais sudarytos sutartys";
            // 
            // lstSutartysTiekejai
            // 
            this.lstSutartysTiekejai.FormattingEnabled = true;
            this.lstSutartysTiekejai.Location = new System.Drawing.Point(28, 38);
            this.lstSutartysTiekejai.Name = "lstSutartysTiekejai";
            this.lstSutartysTiekejai.Size = new System.Drawing.Size(138, 121);
            this.lstSutartysTiekejai.TabIndex = 0;
            this.lstSutartysTiekejai.SelectedIndexChanged += new System.EventHandler(this.lstSutartysTiekejai_SelectedIndexChanged);
            // 
            // tabProduktai
            // 
            this.tabProduktai.Controls.Add(this.btnUzsakytiSandeli);
            this.tabProduktai.Controls.Add(this.txtKiekis);
            this.tabProduktai.Controls.Add(this.label15);
            this.tabProduktai.Controls.Add(this.label13);
            this.tabProduktai.Controls.Add(this.label12);
            this.tabProduktai.Controls.Add(this.txtPrekesKategorija);
            this.tabProduktai.Controls.Add(this.txtPrekesKaina);
            this.tabProduktai.Controls.Add(this.lstTiekejoPrekes);
            this.tabProduktai.Controls.Add(this.label10);
            this.tabProduktai.Controls.Add(this.label9);
            this.tabProduktai.Controls.Add(this.lstTiekejaiProduktai);
            this.tabProduktai.Location = new System.Drawing.Point(4, 22);
            this.tabProduktai.Name = "tabProduktai";
            this.tabProduktai.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduktai.Size = new System.Drawing.Size(874, 303);
            this.tabProduktai.TabIndex = 2;
            this.tabProduktai.Text = "Produktai";
            this.tabProduktai.UseVisualStyleBackColor = true;
            // 
            // btnUzsakytiSandeli
            // 
            this.btnUzsakytiSandeli.Location = new System.Drawing.Point(273, 245);
            this.btnUzsakytiSandeli.Name = "btnUzsakytiSandeli";
            this.btnUzsakytiSandeli.Size = new System.Drawing.Size(120, 23);
            this.btnUzsakytiSandeli.TabIndex = 12;
            this.btnUzsakytiSandeli.Text = "Užsakyti į sandėlį";
            this.btnUzsakytiSandeli.UseVisualStyleBackColor = true;
            this.btnUzsakytiSandeli.Click += new System.EventHandler(this.btnUzsakytiSandeli_Click);
            // 
            // txtKiekis
            // 
            this.txtKiekis.Location = new System.Drawing.Point(273, 218);
            this.txtKiekis.Name = "txtKiekis";
            this.txtKiekis.Size = new System.Drawing.Size(120, 20);
            this.txtKiekis.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Pasirinkite kiekį:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(187, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Kaina:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(187, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Kategorija:";
            // 
            // txtPrekesKategorija
            // 
            this.txtPrekesKategorija.Location = new System.Drawing.Point(273, 162);
            this.txtPrekesKategorija.Name = "txtPrekesKategorija";
            this.txtPrekesKategorija.Size = new System.Drawing.Size(120, 20);
            this.txtPrekesKategorija.TabIndex = 7;
            // 
            // txtPrekesKaina
            // 
            this.txtPrekesKaina.Location = new System.Drawing.Point(273, 191);
            this.txtPrekesKaina.Name = "txtPrekesKaina";
            this.txtPrekesKaina.Size = new System.Drawing.Size(120, 20);
            this.txtPrekesKaina.TabIndex = 6;
            // 
            // lstTiekejoPrekes
            // 
            this.lstTiekejoPrekes.FormattingEnabled = true;
            this.lstTiekejoPrekes.Location = new System.Drawing.Point(273, 35);
            this.lstTiekejoPrekes.Name = "lstTiekejoPrekes";
            this.lstTiekejoPrekes.Size = new System.Drawing.Size(120, 121);
            this.lstTiekejoPrekes.TabIndex = 5;
            this.lstTiekejoPrekes.SelectedIndexChanged += new System.EventHandler(this.lstTiekejoPrekes_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label10.Location = new System.Drawing.Point(280, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tiekėjo prekės:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.Location = new System.Drawing.Point(68, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tiekėjai";
            // 
            // lstTiekejaiProduktai
            // 
            this.lstTiekejaiProduktai.FormattingEnabled = true;
            this.lstTiekejaiProduktai.Location = new System.Drawing.Point(28, 35);
            this.lstTiekejaiProduktai.Name = "lstTiekejaiProduktai";
            this.lstTiekejaiProduktai.Size = new System.Drawing.Size(138, 121);
            this.lstTiekejaiProduktai.TabIndex = 2;
            this.lstTiekejaiProduktai.SelectedIndexChanged += new System.EventHandler(this.lstTiekejaiProduktai_SelectedIndexChanged);
            // 
            // tabSandelis
            // 
            this.tabSandelis.Controls.Add(this.btnFilterPav);
            this.tabSandelis.Controls.Add(this.btnFilterKat);
            this.tabSandelis.Controls.Add(this.button1);
            this.tabSandelis.Controls.Add(this.cmbPrekesPavSandelys);
            this.tabSandelis.Controls.Add(this.cmbKategorijaSandelys);
            this.tabSandelis.Controls.Add(this.label18);
            this.tabSandelis.Controls.Add(this.label17);
            this.tabSandelis.Controls.Add(this.label16);
            this.tabSandelis.Controls.Add(this.dataGridView1);
            this.tabSandelis.Location = new System.Drawing.Point(4, 22);
            this.tabSandelis.Name = "tabSandelis";
            this.tabSandelis.Padding = new System.Windows.Forms.Padding(3);
            this.tabSandelis.Size = new System.Drawing.Size(874, 303);
            this.tabSandelis.TabIndex = 3;
            this.tabSandelis.Text = "Sandėlis";
            this.tabSandelis.UseVisualStyleBackColor = true;
            // 
            // cmbPrekesPavSandelys
            // 
            this.cmbPrekesPavSandelys.FormattingEnabled = true;
            this.cmbPrekesPavSandelys.Location = new System.Drawing.Point(686, 126);
            this.cmbPrekesPavSandelys.Name = "cmbPrekesPavSandelys";
            this.cmbPrekesPavSandelys.Size = new System.Drawing.Size(121, 21);
            this.cmbPrekesPavSandelys.TabIndex = 5;
            this.cmbPrekesPavSandelys.SelectedIndexChanged += new System.EventHandler(this.cmbPrekesPavSandelys_SelectedIndexChanged);
            // 
            // cmbKategorijaSandelys
            // 
            this.cmbKategorijaSandelys.FormattingEnabled = true;
            this.cmbKategorijaSandelys.Location = new System.Drawing.Point(686, 59);
            this.cmbKategorijaSandelys.Name = "cmbKategorijaSandelys";
            this.cmbKategorijaSandelys.Size = new System.Drawing.Size(121, 21);
            this.cmbKategorijaSandelys.TabIndex = 4;
            this.cmbKategorijaSandelys.SelectedIndexChanged += new System.EventHandler(this.cmbKategorijaSandelys_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label18.Location = new System.Drawing.Point(539, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 16);
            this.label18.TabIndex = 3;
            this.label18.Text = "Prekės pavadinimą:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label17.Location = new System.Drawing.Point(539, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "Kategoriją:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label16.Location = new System.Drawing.Point(538, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Filtruoti pagal:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pavadinimas,
            this.SandelioKaina,
            this.kategorijaID,
            this.Likutis,
            this.tiekejoProduktoID});
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(504, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.HeaderText = "Pavadinimas";
            this.Pavadinimas.Name = "Pavadinimas";
            // 
            // SandelioKaina
            // 
            this.SandelioKaina.HeaderText = "Sandėlio Kaina";
            this.SandelioKaina.Name = "SandelioKaina";
            // 
            // kategorijaID
            // 
            this.kategorijaID.HeaderText = "Kategorijos ID";
            this.kategorijaID.Name = "kategorijaID";
            // 
            // Likutis
            // 
            this.Likutis.HeaderText = "Likutis";
            this.Likutis.Name = "Likutis";
            // 
            // tiekejoProduktoID
            // 
            this.tiekejoProduktoID.HeaderText = "Tiekėjo Produkto ID";
            this.tiekejoProduktoID.Name = "tiekejoProduktoID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Parodyti visas prekes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFilterKat
            // 
            this.btnFilterKat.Location = new System.Drawing.Point(686, 87);
            this.btnFilterKat.Name = "btnFilterKat";
            this.btnFilterKat.Size = new System.Drawing.Size(121, 23);
            this.btnFilterKat.TabIndex = 7;
            this.btnFilterKat.Text = "Filtruoti";
            this.btnFilterKat.UseVisualStyleBackColor = true;
            this.btnFilterKat.Click += new System.EventHandler(this.btnFilterKat_Click);
            // 
            // btnFilterPav
            // 
            this.btnFilterPav.Location = new System.Drawing.Point(686, 154);
            this.btnFilterPav.Name = "btnFilterPav";
            this.btnFilterPav.Size = new System.Drawing.Size(121, 23);
            this.btnFilterPav.TabIndex = 8;
            this.btnFilterPav.Text = "Filtruoti";
            this.btnFilterPav.UseVisualStyleBackColor = true;
            this.btnFilterPav.Click += new System.EventHandler(this.btnFilterPav_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 354);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabTiekejai.ResumeLayout(false);
            this.tabTiekejai.PerformLayout();
            this.tabSutartis.ResumeLayout(false);
            this.tabSutartis.PerformLayout();
            this.tabProduktai.ResumeLayout(false);
            this.tabProduktai.PerformLayout();
            this.tabSandelis.ResumeLayout(false);
            this.tabSandelis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTiekejai;
        private System.Windows.Forms.DateTimePicker dateTimePickerTiekPabaiga;
        private System.Windows.Forms.DateTimePicker dateTimePickerTiekPradzia;
        private System.Windows.Forms.TextBox txtTiekImonesKodas;
        private System.Windows.Forms.TextBox txtTiekImonesPav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabSutartis;
        private System.Windows.Forms.TabPage tabProduktai;
        private System.Windows.Forms.TabPage tabSandelis;
        private System.Windows.Forms.Button btnPridetiTiekeja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstSutartysTiekejai;
        private System.Windows.Forms.TextBox txtDatosPabaiga;
        private System.Windows.Forms.TextBox txtDatosPradzia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSutartisKodas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstTiekejaiProduktai;
        private System.Windows.Forms.ListBox lstTiekejoPrekes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstTiekejai;
        private System.Windows.Forms.TextBox txtPrekesKategorija;
        private System.Windows.Forms.TextBox txtPrekesKaina;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonPratesti;
        private System.Windows.Forms.DateTimePicker dateTimePickerPratesti;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnIsregistruoti;
        private System.Windows.Forms.Button btnNutraukti;
        private System.Windows.Forms.Button btnUzsakytiSandeli;
        private System.Windows.Forms.TextBox txtKiekis;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbPrekesPavSandelys;
        private System.Windows.Forms.ComboBox cmbKategorijaSandelys;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pavadinimas;
        private System.Windows.Forms.DataGridViewTextBoxColumn SandelioKaina;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Likutis;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiekejoProduktoID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFilterPav;
        private System.Windows.Forms.Button btnFilterKat;
    }
}

