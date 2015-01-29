namespace General
{
    partial class addMan
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.manewryKatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_9BA4F7_dzordanDataSet1 = new General.DB_9BA4F7_dzordanDataSet1();
            this.pojazdyKatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pojazdyKatTableAdapter = new General.DB_9BA4F7_dzordanDataSet1TableAdapters.PojazdyKatTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bazyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazyTableAdapter = new General.DB_9BA4F7_dzordanDataSet1TableAdapters.BazyTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.skladTableAdapter = new General.DB_9BA4F7_dzordanDataSet1TableAdapters.SkladTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manewryKatTableAdapter = new General.DB_9BA4F7_dzordanDataSet1TableAdapters.ManewryKatTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.manewryKatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_9BA4F7_dzordanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdyKatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategoria";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.manewryKatBindingSource;
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // manewryKatBindingSource
            // 
            this.manewryKatBindingSource.DataMember = "ManewryKat";
            this.manewryKatBindingSource.DataSource = this.dB_9BA4F7_dzordanDataSet1;
            // 
            // dB_9BA4F7_dzordanDataSet1
            // 
            this.dB_9BA4F7_dzordanDataSet1.DataSetName = "DB_9BA4F7_dzordanDataSet1";
            this.dB_9BA4F7_dzordanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baza";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.bazyBindingSource;
            this.comboBox2.DisplayMember = "Miasto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(128, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // bazyBindingSource
            // 
            this.bazyBindingSource.DataMember = "Bazy";
            this.bazyBindingSource.DataSource = this.dB_9BA4F7_dzordanDataSet1;
            // 
            // bazyTableAdapter
            // 
            this.bazyTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data do";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(128, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.skladBindingSource;
            this.comboBox3.DisplayMember = "Nazwa";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(128, 142);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(144, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "Sklad";
            this.skladBindingSource.DataSource = this.dB_9BA4F7_dzordanDataSet1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Skład";
            // 
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(287, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(252, 129);
            this.dataGridView1.TabIndex = 10;
            // 
            // manewryKatTableAdapter
            // 
            this.manewryKatTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(287, 141);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(252, 150);
            this.dataGridView2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj skład";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(357, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Dodaj manewry";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(203, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 35);
            this.button4.TabIndex = 15;
            this.button4.Text = "Edytuj skład";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // addMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 356);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "addMan";
            this.Text = "Zaplanuj Manewry";
            this.Load += new System.EventHandler(this.addMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manewryKatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_9BA4F7_dzordanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdyKatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DB_9BA4F7_dzordanDataSet1 dB_9BA4F7_dzordanDataSet1;
        private System.Windows.Forms.BindingSource pojazdyKatBindingSource;
        private DB_9BA4F7_dzordanDataSet1TableAdapters.PojazdyKatTableAdapter pojazdyKatTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource bazyBindingSource;
        private DB_9BA4F7_dzordanDataSet1TableAdapters.BazyTableAdapter bazyTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private DB_9BA4F7_dzordanDataSet1TableAdapters.SkladTableAdapter skladTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource manewryKatBindingSource;
        private DB_9BA4F7_dzordanDataSet1TableAdapters.ManewryKatTableAdapter manewryKatTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}