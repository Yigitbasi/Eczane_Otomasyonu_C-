namespace eczane_otomasyonu
{
    partial class reçetesiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokmiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talimatlarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sikayetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblilacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneDataSet = new eczane_otomasyonu.EczaneDataSet();
            this.tblilacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ilacTableAdapter = new eczane_otomasyonu.EczaneDataSetTableAdapters.Tbl_ilacTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ilaç adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ücret";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "fiyat görüntüleme";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Parol",
            "Parasetamol",
            "Ibuprofen",
            "Aspirin"});
            this.comboBox1.Location = new System.Drawing.Point(153, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "satış işlemi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunkoduDataGridViewTextBoxColumn,
            this.urunadiDataGridViewTextBoxColumn,
            this.stokmiktariDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn,
            this.talimatlarDataGridViewTextBoxColumn,
            this.sikayetDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblilacBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 276);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // urunkoduDataGridViewTextBoxColumn
            // 
            this.urunkoduDataGridViewTextBoxColumn.DataPropertyName = "urun_kodu";
            this.urunkoduDataGridViewTextBoxColumn.HeaderText = "urun_kodu";
            this.urunkoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunkoduDataGridViewTextBoxColumn.Name = "urunkoduDataGridViewTextBoxColumn";
            this.urunkoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunadiDataGridViewTextBoxColumn
            // 
            this.urunadiDataGridViewTextBoxColumn.DataPropertyName = "urun_adi";
            this.urunadiDataGridViewTextBoxColumn.HeaderText = "urun_adi";
            this.urunadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunadiDataGridViewTextBoxColumn.Name = "urunadiDataGridViewTextBoxColumn";
            this.urunadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokmiktariDataGridViewTextBoxColumn
            // 
            this.stokmiktariDataGridViewTextBoxColumn.DataPropertyName = "stok_miktari";
            this.stokmiktariDataGridViewTextBoxColumn.HeaderText = "stok_miktari";
            this.stokmiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokmiktariDataGridViewTextBoxColumn.Name = "stokmiktariDataGridViewTextBoxColumn";
            this.stokmiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "ucret";
            this.ucretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.Width = 125;
            // 
            // talimatlarDataGridViewTextBoxColumn
            // 
            this.talimatlarDataGridViewTextBoxColumn.DataPropertyName = "talimatlar";
            this.talimatlarDataGridViewTextBoxColumn.HeaderText = "talimatlar";
            this.talimatlarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.talimatlarDataGridViewTextBoxColumn.Name = "talimatlarDataGridViewTextBoxColumn";
            this.talimatlarDataGridViewTextBoxColumn.Width = 125;
            // 
            // sikayetDataGridViewTextBoxColumn
            // 
            this.sikayetDataGridViewTextBoxColumn.DataPropertyName = "sikayet";
            this.sikayetDataGridViewTextBoxColumn.HeaderText = "sikayet";
            this.sikayetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sikayetDataGridViewTextBoxColumn.Name = "sikayetDataGridViewTextBoxColumn";
            this.sikayetDataGridViewTextBoxColumn.Width = 125;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblilacBindingSource1
            // 
            this.tblilacBindingSource1.DataMember = "Tbl_ilac";
            this.tblilacBindingSource1.DataSource = this.eczaneDataSet;
            // 
            // eczaneDataSet
            // 
            this.eczaneDataSet.DataSetName = "EczaneDataSet";
            this.eczaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblilacBindingSource
            // 
            this.tblilacBindingSource.DataMember = "Tbl_ilac";
            this.tblilacBindingSource.DataSource = this.eczaneDataSet;
            // 
            // tbl_ilacTableAdapter
            // 
            this.tbl_ilacTableAdapter.ClearBeforeFill = true;
            // 
            // reçetesiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "reçetesiz";
            this.Text = "reçetesiz";
            this.Load += new System.EventHandler(this.reçetesiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblilacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EczaneDataSet eczaneDataSet;
        private System.Windows.Forms.BindingSource tblilacBindingSource;
        private EczaneDataSetTableAdapters.Tbl_ilacTableAdapter tbl_ilacTableAdapter;
        private System.Windows.Forms.BindingSource tblilacBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokmiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talimatlarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sikayetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}