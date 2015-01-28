namespace General
{
    partial class addMod
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dB_9BA4F7_dzordanDataSet1 = new General.DB_9BA4F7_dzordanDataSet1();
            this.pojazdyTypBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pojazdyTypTableAdapter = new General.DB_9BA4F7_dzordanDataSet1TableAdapters.PojazdyTypTableAdapter();
            this.pojazdyKatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pojazdyKatTableAdapter = new General.DB_9BA4F7_dzordanDataSet1TableAdapters.PojazdyKatTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pojazdyTypBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nazwaPojazduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ładownośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dB_9BA4F7_dzordanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdyTypBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdyKatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdyTypBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa pojazdu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategoria";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.pojazdyKatBindingSource;
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dB_9BA4F7_dzordanDataSet1
            // 
            this.dB_9BA4F7_dzordanDataSet1.DataSetName = "DB_9BA4F7_dzordanDataSet1";
            this.dB_9BA4F7_dzordanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pojazdyTypBindingSource
            // 
            this.pojazdyTypBindingSource.DataMember = "PojazdyTyp";
            this.pojazdyTypBindingSource.DataSource = this.dB_9BA4F7_dzordanDataSet1;
            // 
            // pojazdyTypTableAdapter
            // 
            this.pojazdyTypTableAdapter.ClearBeforeFill = true;
            // 
            // pojazdyKatBindingSource
            // 
            this.pojazdyKatBindingSource.DataMember = "PojazdyKat";
            this.pojazdyKatBindingSource.DataSource = this.dB_9BA4F7_dzordanDataSet1;
            // 
            // pojazdyKatTableAdapter
            // 
            this.pojazdyKatTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Masa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ładowność";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaPojazduDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.ładownośćDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pojazdyTypBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(306, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 137);
            this.dataGridView1.TabIndex = 10;
            // 
            // pojazdyTypBindingSource1
            // 
            this.pojazdyTypBindingSource1.DataMember = "PojazdyTyp";
            this.pojazdyTypBindingSource1.DataSource = this.dB_9BA4F7_dzordanDataSet1;
            // 
            // nazwaPojazduDataGridViewTextBoxColumn
            // 
            this.nazwaPojazduDataGridViewTextBoxColumn.DataPropertyName = "NazwaPojazdu";
            this.nazwaPojazduDataGridViewTextBoxColumn.HeaderText = "NazwaPojazdu";
            this.nazwaPojazduDataGridViewTextBoxColumn.Name = "nazwaPojazduDataGridViewTextBoxColumn";
            this.nazwaPojazduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            this.masaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ładownośćDataGridViewTextBoxColumn
            // 
            this.ładownośćDataGridViewTextBoxColumn.DataPropertyName = "Ładowność";
            this.ładownośćDataGridViewTextBoxColumn.HeaderText = "Ładowność";
            this.ładownośćDataGridViewTextBoxColumn.Name = "ładownośćDataGridViewTextBoxColumn";
            this.ładownośćDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 155);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "addMod";
            this.Text = "Dodaj nowy model pojazdu";
            this.Load += new System.EventHandler(this.addMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_9BA4F7_dzordanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdyTypBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdyKatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdyTypBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DB_9BA4F7_dzordanDataSet1 dB_9BA4F7_dzordanDataSet1;
        private System.Windows.Forms.BindingSource pojazdyTypBindingSource;
        private DB_9BA4F7_dzordanDataSet1TableAdapters.PojazdyTypTableAdapter pojazdyTypTableAdapter;
        private System.Windows.Forms.BindingSource pojazdyKatBindingSource;
        private DB_9BA4F7_dzordanDataSet1TableAdapters.PojazdyKatTableAdapter pojazdyKatTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaPojazduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ładownośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pojazdyTypBindingSource1;
    }
}