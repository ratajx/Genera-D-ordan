namespace General
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDBazyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodPocztowyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bazyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB9BA4F7dzordanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_9BA4F7_dzordanDataSet = new General.DB_9BA4F7_dzordanDataSet();
            this.bazyTableAdapter = new General.DB_9BA4F7_dzordanDataSetTableAdapters.BazyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.zolnierzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zolnierzTableAdapter = new General.DB_9BA4F7_dzordanDataSetTableAdapters.ZolnierzTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB9BA4F7dzordanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_9BA4F7_dzordanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zolnierzBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBazyDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.numerDataGridViewTextBoxColumn,
            this.kodPocztowyDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bazyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDBazyDataGridViewTextBoxColumn
            // 
            this.iDBazyDataGridViewTextBoxColumn.DataPropertyName = "IDBazy";
            this.iDBazyDataGridViewTextBoxColumn.HeaderText = "IDBazy";
            this.iDBazyDataGridViewTextBoxColumn.Name = "iDBazyDataGridViewTextBoxColumn";
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            // 
            // numerDataGridViewTextBoxColumn
            // 
            this.numerDataGridViewTextBoxColumn.DataPropertyName = "Numer";
            this.numerDataGridViewTextBoxColumn.HeaderText = "Numer";
            this.numerDataGridViewTextBoxColumn.Name = "numerDataGridViewTextBoxColumn";
            // 
            // kodPocztowyDataGridViewTextBoxColumn
            // 
            this.kodPocztowyDataGridViewTextBoxColumn.DataPropertyName = "KodPocztowy";
            this.kodPocztowyDataGridViewTextBoxColumn.HeaderText = "KodPocztowy";
            this.kodPocztowyDataGridViewTextBoxColumn.Name = "kodPocztowyDataGridViewTextBoxColumn";
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
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
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button2.Location = new System.Drawing.Point(30, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB9BA4F7dzordanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_9BA4F7_dzordanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zolnierzBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dB9BA4F7dzordanDataSetBindingSource;
        private DB_9BA4F7_dzordanDataSet dB_9BA4F7_dzordanDataSet;
        private System.Windows.Forms.BindingSource bazyBindingSource;
        private DB_9BA4F7_dzordanDataSetTableAdapters.BazyTableAdapter bazyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBazyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPocztowyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource zolnierzBindingSource;
        private DB_9BA4F7_dzordanDataSetTableAdapters.ZolnierzTableAdapter zolnierzTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}

