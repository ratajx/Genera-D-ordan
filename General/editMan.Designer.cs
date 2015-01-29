namespace General
{
    partial class editMan
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
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.skladBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_9BA4F7_dzordanDataSet1 = new General.DB_9BA4F7_dzordanDataSet1();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bazyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazyTableAdapter = new General.DB_9BA4F7_dzordanDataSet1TableAdapters.BazyTableAdapter();
            this.skladTableAdapter = new General.DB_9BA4F7_dzordanDataSet1TableAdapters.SkladTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.manewryKatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manewryKatTableAdapter = new General.DB_9BA4F7_dzordanDataSet1TableAdapters.ManewryKatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_9BA4F7_dzordanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manewryKatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Uaktualnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(51, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Skład";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Baza";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.skladBindingSource, "IDSkladu", true));
            this.comboBox1.DataSource = this.skladBindingSource;
            this.comboBox1.DisplayMember = "Nazwa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "IDSkladu";
            // 
            // skladBindingSource
            // 
            this.skladBindingSource.DataMember = "Sklad";
            this.skladBindingSource.DataSource = this.dB_9BA4F7_dzordanDataSet1;
            // 
            // dB_9BA4F7_dzordanDataSet1
            // 
            this.dB_9BA4F7_dzordanDataSet1.DataSetName = "DB_9BA4F7_dzordanDataSet1";
            this.dB_9BA4F7_dzordanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bazyBindingSource, "IDBazy", true));
            this.comboBox2.DataSource = this.bazyBindingSource;
            this.comboBox2.DisplayMember = "Miasto";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(51, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "IDBazy";
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
            // skladTableAdapter
            // 
            this.skladTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Typ";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.manewryKatBindingSource, "IDManewryKat", true));
            this.comboBox3.DataSource = this.manewryKatBindingSource;
            this.comboBox3.DisplayMember = "Nazwa";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(51, 83);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(153, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.ValueMember = "IDManewryKat";
            // 
            // manewryKatBindingSource
            // 
            this.manewryKatBindingSource.DataMember = "ManewryKat";
            this.manewryKatBindingSource.DataSource = this.dB_9BA4F7_dzordanDataSet1;
            // 
            // manewryKatTableAdapter
            // 
            this.manewryKatTableAdapter.ClearBeforeFill = true;
            // 
            // editMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 206);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "editMan";
            this.Text = "Edycja";
            this.Load += new System.EventHandler(this.editMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skladBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_9BA4F7_dzordanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manewryKatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private DB_9BA4F7_dzordanDataSet1 dB_9BA4F7_dzordanDataSet1;
        private System.Windows.Forms.BindingSource bazyBindingSource;
        private DB_9BA4F7_dzordanDataSet1TableAdapters.BazyTableAdapter bazyTableAdapter;
        private System.Windows.Forms.BindingSource skladBindingSource;
        private DB_9BA4F7_dzordanDataSet1TableAdapters.SkladTableAdapter skladTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource manewryKatBindingSource;
        private DB_9BA4F7_dzordanDataSet1TableAdapters.ManewryKatTableAdapter manewryKatTableAdapter;
    }
}