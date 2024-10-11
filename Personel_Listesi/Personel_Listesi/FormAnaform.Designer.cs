namespace Personel_Listesi
{
    partial class FormAnaform
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.maas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sehircombo = new System.Windows.Forms.ComboBox();
            this.txtSoyısım = new System.Windows.Forms.TextBox();
            this.txtIsım = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaritalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perProffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerSehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerMarital = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PerProff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_dataBase1DataSet1 = new Personel_Listesi.Personel_dataBase1DataSet1();
            this.table_PersonelTableAdapter = new Personel_Listesi.Personel_dataBase1DataSet1TableAdapters.Table_PersonelTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_dataBase1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(36, 176);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(146, 37);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // maas
            // 
            this.maas.Location = new System.Drawing.Point(138, 221);
            this.maas.Mask = "0000";
            this.maas.Name = "maas";
            this.maas.Size = new System.Drawing.Size(100, 20);
            this.maas.TabIndex = 16;
            this.maas.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maaş:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(177, 250);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bekar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(138, 184);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(100, 20);
            this.txtMeslek.TabIndex = 11;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(116, 248);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Evli";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // sehircombo
            // 
            this.sehircombo.FormattingEnabled = true;
            this.sehircombo.Location = new System.Drawing.Point(138, 144);
            this.sehircombo.Name = "sehircombo";
            this.sehircombo.Size = new System.Drawing.Size(100, 21);
            this.sehircombo.TabIndex = 9;
            // 
            // txtSoyısım
            // 
            this.txtSoyısım.Location = new System.Drawing.Point(138, 104);
            this.txtSoyısım.Name = "txtSoyısım";
            this.txtSoyısım.Size = new System.Drawing.Size(100, 20);
            this.txtSoyısım.TabIndex = 8;
            // 
            // txtIsım
            // 
            this.txtIsım.Location = new System.Drawing.Point(138, 70);
            this.txtIsım.Name = "txtIsım";
            this.txtIsım.Size = new System.Drawing.Size(100, 20);
            this.txtIsım.TabIndex = 7;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(36, 136);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(146, 34);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(36, 26);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(146, 36);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(36, 64);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 31);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(138, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Durum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Meslek:";
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(36, 219);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(146, 35);
            this.btnIstatistik.TabIndex = 4;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soy İsim:";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(36, 260);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(146, 35);
            this.btnGrafik.TabIndex = 7;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrafik);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnIstatistik);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Location = new System.Drawing.Point(385, -4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 304);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(36, 98);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(146, 35);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel İsim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.maas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtMeslek);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.sehircombo);
            this.groupBox1.Controls.Add(this.txtSoyısım);
            this.groupBox1.Controls.Add(this.txtIsım);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(98, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 304);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Maaş:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 251);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perNameDataGridViewTextBoxColumn,
            this.perSNDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perSalDataGridViewTextBoxColumn,
            this.perMaritalDataGridViewCheckBoxColumn,
            this.perProffDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.PerName,
            this.PerSN,
            this.PerSehir,
            this.PerSal,
            this.PerMarital,
            this.PerProff});
            this.dataGridView1.DataSource = this.tablePersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perNameDataGridViewTextBoxColumn
            // 
            this.perNameDataGridViewTextBoxColumn.DataPropertyName = "PerName";
            this.perNameDataGridViewTextBoxColumn.HeaderText = "PerName";
            this.perNameDataGridViewTextBoxColumn.Name = "perNameDataGridViewTextBoxColumn";
            // 
            // perSNDataGridViewTextBoxColumn
            // 
            this.perSNDataGridViewTextBoxColumn.DataPropertyName = "PerSN";
            this.perSNDataGridViewTextBoxColumn.HeaderText = "PerSN";
            this.perSNDataGridViewTextBoxColumn.Name = "perSNDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perSalDataGridViewTextBoxColumn
            // 
            this.perSalDataGridViewTextBoxColumn.DataPropertyName = "PerSal";
            this.perSalDataGridViewTextBoxColumn.HeaderText = "PerSal";
            this.perSalDataGridViewTextBoxColumn.Name = "perSalDataGridViewTextBoxColumn";
            // 
            // perMaritalDataGridViewCheckBoxColumn
            // 
            this.perMaritalDataGridViewCheckBoxColumn.DataPropertyName = "PerMarital";
            this.perMaritalDataGridViewCheckBoxColumn.HeaderText = "PerMarital";
            this.perMaritalDataGridViewCheckBoxColumn.Name = "perMaritalDataGridViewCheckBoxColumn";
            // 
            // perProffDataGridViewTextBoxColumn
            // 
            this.perProffDataGridViewTextBoxColumn.DataPropertyName = "PerProff";
            this.perProffDataGridViewTextBoxColumn.HeaderText = "PerProff";
            this.perProffDataGridViewTextBoxColumn.Name = "perProffDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PerID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PerID";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // PerName
            // 
            this.PerName.DataPropertyName = "PerName";
            this.PerName.HeaderText = "PerName";
            this.PerName.Name = "PerName";
            // 
            // PerSN
            // 
            this.PerSN.DataPropertyName = "PerSN";
            this.PerSN.HeaderText = "PerSN";
            this.PerSN.Name = "PerSN";
            // 
            // PerSehir
            // 
            this.PerSehir.DataPropertyName = "PerSehir";
            this.PerSehir.HeaderText = "PerSehir";
            this.PerSehir.Name = "PerSehir";
            // 
            // PerSal
            // 
            this.PerSal.DataPropertyName = "PerSal";
            this.PerSal.HeaderText = "PerSal";
            this.PerSal.Name = "PerSal";
            // 
            // PerMarital
            // 
            this.PerMarital.DataPropertyName = "PerMarital";
            this.PerMarital.HeaderText = "PerMarital";
            this.PerMarital.Name = "PerMarital";
            // 
            // PerProff
            // 
            this.PerProff.DataPropertyName = "PerProff";
            this.PerProff.HeaderText = "PerProff";
            this.PerProff.Name = "PerProff";
            // 
            // tablePersonelBindingSource
            // 
            this.tablePersonelBindingSource.DataMember = "Table_Personel";
            this.tablePersonelBindingSource.DataSource = this.personel_dataBase1DataSet1;
            // 
            // personel_dataBase1DataSet1
            // 
            this.personel_dataBase1DataSet1.DataSetName = "Personel_dataBase1DataSet1";
            this.personel_dataBase1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_PersonelTableAdapter
            // 
            this.table_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Personel_Listesi.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(633, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormAnaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 569);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAnaform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_dataBase1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.MaskedTextBox maas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox sehircombo;
        private System.Windows.Forms.TextBox txtSoyısım;
        private System.Windows.Forms.TextBox txtIsım;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Personel_dataBase1DataSet1 personel_dataBase1DataSet1;
        private System.Windows.Forms.BindingSource tablePersonelBindingSource;
        private Personel_dataBase1DataSet1TableAdapters.Table_PersonelTableAdapter table_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perMaritalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perProffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerSehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerSal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PerMarital;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerProff;
        private System.Windows.Forms.Label label8;
    }
}

