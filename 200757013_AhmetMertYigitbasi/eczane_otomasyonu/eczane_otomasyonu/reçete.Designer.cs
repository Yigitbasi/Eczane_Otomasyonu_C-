namespace eczane_otomasyonu
{
    partial class reçete
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eczaneDataSet4 = new eczane_otomasyonu.EczaneDataSet4();
            this.eczaneDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblhastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_hastaTableAdapter = new eczane_otomasyonu.EczaneDataSet4TableAdapters.Tbl_hastaTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta adı soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "reçetedeki ilaç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ücret";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "ilaç tespit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "satış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "reçete kontrol";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 258);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eczaneDataSet4
            // 
            this.eczaneDataSet4.DataSetName = "EczaneDataSet4";
            this.eczaneDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eczaneDataSet4BindingSource
            // 
            this.eczaneDataSet4BindingSource.DataSource = this.eczaneDataSet4;
            this.eczaneDataSet4BindingSource.Position = 0;
            // 
            // tblhastaBindingSource
            // 
            this.tblhastaBindingSource.DataMember = "Tbl_hasta";
            this.tblhastaBindingSource.DataSource = this.eczaneDataSet4BindingSource;
            // 
            // tbl_hastaTableAdapter
            // 
            this.tbl_hastaTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 42);
            this.button4.TabIndex = 11;
            this.button4.Text = "ücret";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(537, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 44);
            this.button5.TabIndex = 12;
            this.button5.Text = "listeleme";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // reçete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "reçete";
            this.Text = "reçete";
            this.Load += new System.EventHandler(this.reçete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblhastaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eczaneDataSet4BindingSource;
        private EczaneDataSet4 eczaneDataSet4;
        private System.Windows.Forms.BindingSource tblhastaBindingSource;
        private EczaneDataSet4TableAdapters.Tbl_hastaTableAdapter tbl_hastaTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}