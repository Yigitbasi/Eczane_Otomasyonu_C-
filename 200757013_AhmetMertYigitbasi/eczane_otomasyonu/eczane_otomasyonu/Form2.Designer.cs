namespace eczane_otomasyonu
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tblhastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneDataSet4 = new eczane_otomasyonu.EczaneDataSet4();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbl_hastaTableAdapter = new eczane_otomasyonu.EczaneDataSet4TableAdapters.Tbl_hastaTableAdapter();
            this.eczaneDataSet5 = new eczane_otomasyonu.EczaneDataSet5();
            this.tblhastaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_hastaTableAdapter1 = new eczane_otomasyonu.EczaneDataSet5TableAdapters.Tbl_hastaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaadisoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastatcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sikayetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recetenintarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alerjilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kronikhastaliklarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ilacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblhastaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneDataSet6 = new eczane_otomasyonu.EczaneDataSet6();
            this.tbl_hastaTableAdapter2 = new eczane_otomasyonu.EczaneDataSet6TableAdapters.Tbl_hastaTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listeleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblhastaBindingSource
            // 
            this.tblhastaBindingSource.DataMember = "Tbl_hasta";
            this.tblhastaBindingSource.DataSource = this.eczaneDataSet4;
            // 
            // eczaneDataSet4
            // 
            this.eczaneDataSet4.DataSetName = "EczaneDataSet4";
            this.eczaneDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hasta ekleme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ekrandaki yazıları sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(530, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Kaydı sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(530, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hasta ad soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta Tc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şikayeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alerji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kronik Hastalık";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 155);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(377, 58);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "0"});
            this.comboBox1.Location = new System.Drawing.Point(377, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Reçete ver";
            // 
            // tbl_hastaTableAdapter
            // 
            this.tbl_hastaTableAdapter.ClearBeforeFill = true;
            // 
            // eczaneDataSet5
            // 
            this.eczaneDataSet5.DataSetName = "EczaneDataSet5";
            this.eczaneDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblhastaBindingSource1
            // 
            this.tblhastaBindingSource1.DataMember = "Tbl_hasta";
            this.tblhastaBindingSource1.DataSource = this.eczaneDataSet5;
            // 
            // tbl_hastaTableAdapter1
            // 
            this.tbl_hastaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siraDataGridViewTextBoxColumn,
            this.hastaadisoyadiDataGridViewTextBoxColumn,
            this.hastatcDataGridViewTextBoxColumn,
            this.sikayetDataGridViewTextBoxColumn,
            this.recetenintarihiDataGridViewTextBoxColumn,
            this.alerjilerDataGridViewTextBoxColumn,
            this.kronikhastaliklarDataGridViewTextBoxColumn,
            this.receteDataGridViewCheckBoxColumn,
            this.ilacDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblhastaBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(15, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1180, 255);
            this.dataGridView1.TabIndex = 21;
            // 
            // siraDataGridViewTextBoxColumn
            // 
            this.siraDataGridViewTextBoxColumn.DataPropertyName = "sira";
            this.siraDataGridViewTextBoxColumn.HeaderText = "sira";
            this.siraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siraDataGridViewTextBoxColumn.Name = "siraDataGridViewTextBoxColumn";
            this.siraDataGridViewTextBoxColumn.ReadOnly = true;
            this.siraDataGridViewTextBoxColumn.Width = 125;
            // 
            // hastaadisoyadiDataGridViewTextBoxColumn
            // 
            this.hastaadisoyadiDataGridViewTextBoxColumn.DataPropertyName = "hasta_adi_soyadi";
            this.hastaadisoyadiDataGridViewTextBoxColumn.HeaderText = "hasta_adi_soyadi";
            this.hastaadisoyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastaadisoyadiDataGridViewTextBoxColumn.Name = "hastaadisoyadiDataGridViewTextBoxColumn";
            this.hastaadisoyadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // hastatcDataGridViewTextBoxColumn
            // 
            this.hastatcDataGridViewTextBoxColumn.DataPropertyName = "hasta_tc";
            this.hastatcDataGridViewTextBoxColumn.HeaderText = "hasta_tc";
            this.hastatcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hastatcDataGridViewTextBoxColumn.Name = "hastatcDataGridViewTextBoxColumn";
            this.hastatcDataGridViewTextBoxColumn.Width = 125;
            // 
            // sikayetDataGridViewTextBoxColumn
            // 
            this.sikayetDataGridViewTextBoxColumn.DataPropertyName = "sikayet";
            this.sikayetDataGridViewTextBoxColumn.HeaderText = "sikayet";
            this.sikayetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sikayetDataGridViewTextBoxColumn.Name = "sikayetDataGridViewTextBoxColumn";
            this.sikayetDataGridViewTextBoxColumn.Width = 125;
            // 
            // recetenintarihiDataGridViewTextBoxColumn
            // 
            this.recetenintarihiDataGridViewTextBoxColumn.DataPropertyName = "recetenin_tarihi";
            this.recetenintarihiDataGridViewTextBoxColumn.HeaderText = "recetenin_tarihi";
            this.recetenintarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recetenintarihiDataGridViewTextBoxColumn.Name = "recetenintarihiDataGridViewTextBoxColumn";
            this.recetenintarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // alerjilerDataGridViewTextBoxColumn
            // 
            this.alerjilerDataGridViewTextBoxColumn.DataPropertyName = "alerjiler";
            this.alerjilerDataGridViewTextBoxColumn.HeaderText = "alerjiler";
            this.alerjilerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alerjilerDataGridViewTextBoxColumn.Name = "alerjilerDataGridViewTextBoxColumn";
            this.alerjilerDataGridViewTextBoxColumn.Width = 125;
            // 
            // kronikhastaliklarDataGridViewTextBoxColumn
            // 
            this.kronikhastaliklarDataGridViewTextBoxColumn.DataPropertyName = "kronik_hastaliklar";
            this.kronikhastaliklarDataGridViewTextBoxColumn.HeaderText = "kronik_hastaliklar";
            this.kronikhastaliklarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kronikhastaliklarDataGridViewTextBoxColumn.Name = "kronikhastaliklarDataGridViewTextBoxColumn";
            this.kronikhastaliklarDataGridViewTextBoxColumn.Width = 125;
            // 
            // receteDataGridViewCheckBoxColumn
            // 
            this.receteDataGridViewCheckBoxColumn.DataPropertyName = "recete";
            this.receteDataGridViewCheckBoxColumn.HeaderText = "recete";
            this.receteDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.receteDataGridViewCheckBoxColumn.Name = "receteDataGridViewCheckBoxColumn";
            this.receteDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ilacDataGridViewTextBoxColumn
            // 
            this.ilacDataGridViewTextBoxColumn.DataPropertyName = "ilac";
            this.ilacDataGridViewTextBoxColumn.HeaderText = "ilac";
            this.ilacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilacDataGridViewTextBoxColumn.Name = "ilacDataGridViewTextBoxColumn";
            this.ilacDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblhastaBindingSource2
            // 
            this.tblhastaBindingSource2.DataMember = "Tbl_hasta";
            this.tblhastaBindingSource2.DataSource = this.eczaneDataSet6;
            // 
            // eczaneDataSet6
            // 
            this.eczaneDataSet6.DataSetName = "EczaneDataSet6";
            this.eczaneDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_hastaTableAdapter2
            // 
            this.tbl_hastaTableAdapter2.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "İlaç";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(377, 133);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Sıra";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(121, 28);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 25;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private EczaneDataSet4 eczaneDataSet4;
        private System.Windows.Forms.BindingSource tblhastaBindingSource;
        private EczaneDataSet4TableAdapters.Tbl_hastaTableAdapter tbl_hastaTableAdapter;
        private EczaneDataSet5 eczaneDataSet5;
        private System.Windows.Forms.BindingSource tblhastaBindingSource1;
        private EczaneDataSet5TableAdapters.Tbl_hastaTableAdapter tbl_hastaTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EczaneDataSet6 eczaneDataSet6;
        private System.Windows.Forms.BindingSource tblhastaBindingSource2;
        private EczaneDataSet6TableAdapters.Tbl_hastaTableAdapter tbl_hastaTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn siraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaadisoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastatcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sikayetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetenintarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alerjilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kronikhastaliklarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn receteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilacDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
    }
}