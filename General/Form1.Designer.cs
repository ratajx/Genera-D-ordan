﻿namespace General
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
            this.components = new System.ComponentModel.Container();
            this.bazyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB9BA4F7dzordanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_9BA4F7_dzordanDataSet = new General.DB_9BA4F7_dzordanDataSet();
            this.bazyTableAdapter = new General.DB_9BA4F7_dzordanDataSetTableAdapters.BazyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.zolnierzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zolnierzTableAdapter = new General.DB_9BA4F7_dzordanDataSetTableAdapters.ZolnierzTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statsBox = new System.Windows.Forms.GroupBox();
            this.iloscZolnierzyNieuzytychLabel = new System.Windows.Forms.Label();
            this.iloscPojazdowUzytychLabel = new System.Windows.Forms.Label();
            this.iloscZolnierzyUzytychLabel = new System.Windows.Forms.Label();
            this.iloscPojazdowNiezytychLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iloscPojazdowLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iloscZolnierzyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bazyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB9BA4F7dzordanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_9BA4F7_dzordanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zolnierzBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bazyBindingSource
            // 
            this.bazyBindingSource.DataMember = "Bazy";
            this.bazyBindingSource.DataSource = this.dB9BA4F7dzordanDataSetBindingSource;
            // 
            // dB9BA4F7dzordanDataSetBindingSource
            // 
            this.dB9BA4F7dzordanDataSetBindingSource.DataSource = this.dB_9BA4F7_dzordanDataSet;
            this.dB9BA4F7dzordanDataSetBindingSource.Position = 0;
            // 
            // dB_9BA4F7_dzordanDataSet
            // 
            this.dB_9BA4F7_dzordanDataSet.DataSetName = "DB_9BA4F7_dzordanDataSet";
            this.dB_9BA4F7_dzordanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bazyTableAdapter
            // 
            this.bazyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            // 
            // zolnierzBindingSource
            // 
            this.zolnierzBindingSource.DataMember = "Zolnierz";
            this.zolnierzBindingSource.DataSource = this.dB9BA4F7dzordanDataSetBindingSource;
            // 
            // zolnierzTableAdapter
            // 
            this.zolnierzTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 258);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.statsBox);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Panel główny";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "pokaz łączne";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bazyBindingSource;
            this.comboBox1.DisplayMember = "Miasto";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "IDBazy";
            // 
            // statsBox
            // 
            this.statsBox.Controls.Add(this.label2);
            this.statsBox.Controls.Add(this.label4);
            this.statsBox.Controls.Add(this.iloscZolnierzyNieuzytychLabel);
            this.statsBox.Controls.Add(this.iloscPojazdowUzytychLabel);
            this.statsBox.Controls.Add(this.iloscZolnierzyUzytychLabel);
            this.statsBox.Controls.Add(this.iloscPojazdowNiezytychLabel);
            this.statsBox.Controls.Add(this.label6);
            this.statsBox.Controls.Add(this.label5);
            this.statsBox.Controls.Add(this.iloscPojazdowLabel);
            this.statsBox.Controls.Add(this.label3);
            this.statsBox.Controls.Add(this.iloscZolnierzyLabel);
            this.statsBox.Controls.Add(this.label1);
            this.statsBox.Location = new System.Drawing.Point(327, 6);
            this.statsBox.Name = "statsBox";
            this.statsBox.Size = new System.Drawing.Size(604, 202);
            this.statsBox.TabIndex = 1;
            this.statsBox.TabStop = false;
            this.statsBox.Text = "Statystyki";
            // 
            // iloscZolnierzyNieuzytychLabel
            // 
            this.iloscZolnierzyNieuzytychLabel.AutoSize = true;
            this.iloscZolnierzyNieuzytychLabel.Location = new System.Drawing.Point(105, 42);
            this.iloscZolnierzyNieuzytychLabel.Name = "iloscZolnierzyNieuzytychLabel";
            this.iloscZolnierzyNieuzytychLabel.Size = new System.Drawing.Size(13, 13);
            this.iloscZolnierzyNieuzytychLabel.TabIndex = 9;
            this.iloscZolnierzyNieuzytychLabel.Text = "0";
            // 
            // iloscPojazdowUzytychLabel
            // 
            this.iloscPojazdowUzytychLabel.AutoSize = true;
            this.iloscPojazdowUzytychLabel.Location = new System.Drawing.Point(365, 29);
            this.iloscPojazdowUzytychLabel.Name = "iloscPojazdowUzytychLabel";
            this.iloscPojazdowUzytychLabel.Size = new System.Drawing.Size(13, 13);
            this.iloscPojazdowUzytychLabel.TabIndex = 8;
            this.iloscPojazdowUzytychLabel.Text = "0";
            // 
            // iloscZolnierzyUzytychLabel
            // 
            this.iloscZolnierzyUzytychLabel.AutoSize = true;
            this.iloscZolnierzyUzytychLabel.Location = new System.Drawing.Point(105, 29);
            this.iloscZolnierzyUzytychLabel.Name = "iloscZolnierzyUzytychLabel";
            this.iloscZolnierzyUzytychLabel.Size = new System.Drawing.Size(13, 13);
            this.iloscZolnierzyUzytychLabel.TabIndex = 7;
            this.iloscZolnierzyUzytychLabel.Text = "0";
            // 
            // iloscPojazdowNiezytychLabel
            // 
            this.iloscPojazdowNiezytychLabel.AutoSize = true;
            this.iloscPojazdowNiezytychLabel.Location = new System.Drawing.Point(365, 42);
            this.iloscPojazdowNiezytychLabel.Name = "iloscPojazdowNiezytychLabel";
            this.iloscPojazdowNiezytychLabel.Size = new System.Drawing.Size(13, 13);
            this.iloscPojazdowNiezytychLabel.TabIndex = 6;
            this.iloscPojazdowNiezytychLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "-w użyciu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "-dostępnych:";
            // 
            // iloscPojazdowLabel
            // 
            this.iloscPojazdowLabel.AutoSize = true;
            this.iloscPojazdowLabel.Location = new System.Drawing.Point(365, 16);
            this.iloscPojazdowLabel.Name = "iloscPojazdowLabel";
            this.iloscPojazdowLabel.Size = new System.Drawing.Size(13, 13);
            this.iloscPojazdowLabel.TabIndex = 3;
            this.iloscPojazdowLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ilość pojazdów:";
            // 
            // iloscZolnierzyLabel
            // 
            this.iloscZolnierzyLabel.AutoSize = true;
            this.iloscZolnierzyLabel.Location = new System.Drawing.Point(105, 16);
            this.iloscZolnierzyLabel.Name = "iloscZolnierzyLabel";
            this.iloscZolnierzyLabel.Size = new System.Drawing.Size(13, 13);
            this.iloscZolnierzyLabel.TabIndex = 1;
            this.iloscZolnierzyLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość żołnierzy:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(937, 232);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(937, 232);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "-w użyciu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "-dostępnych:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 414);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB9BA4F7dzordanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_9BA4F7_dzordanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zolnierzBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statsBox.ResumeLayout(false);
            this.statsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource dB9BA4F7dzordanDataSetBindingSource;
        private DB_9BA4F7_dzordanDataSet dB_9BA4F7_dzordanDataSet;
        private System.Windows.Forms.BindingSource bazyBindingSource;
        private DB_9BA4F7_dzordanDataSetTableAdapters.BazyTableAdapter bazyTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource zolnierzBindingSource;
        private DB_9BA4F7_dzordanDataSetTableAdapters.ZolnierzTableAdapter zolnierzTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox statsBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label iloscZolnierzyNieuzytychLabel;
        private System.Windows.Forms.Label iloscPojazdowUzytychLabel;
        private System.Windows.Forms.Label iloscZolnierzyUzytychLabel;
        private System.Windows.Forms.Label iloscPojazdowNiezytychLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label iloscPojazdowLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label iloscZolnierzyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

