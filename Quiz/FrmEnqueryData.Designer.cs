
namespace Quiz
{
   partial class FrmEnqueryData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData1 = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblBanyakRecordData = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.mahasiswaDS = new Quiz.MahasiswaDS();
            this.mahasiswaDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMahasiswaTableAdapter = new Quiz.MahasiswaDSTableAdapters.TMahasiswaTableAdapter();
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programStudiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktuKuliahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMahasiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData1
            // 
            this.dgvData1.AllowUserToAddRows = false;
            this.dgvData1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvData1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData1.AutoGenerateColumns = false;
            this.dgvData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.programStudiDataGridViewTextBoxColumn,
            this.waktuKuliahDataGridViewTextBoxColumn,
            this.kelasDataGridViewTextBoxColumn});
            this.dgvData1.DataSource = this.tMahasiswaBindingSource;
            this.dgvData1.Location = new System.Drawing.Point(16, 97);
            this.dgvData1.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData1.Name = "dgvData1";
            this.dgvData1.ReadOnly = true;
            this.dgvData1.RowHeadersWidth = 51;
            this.dgvData1.Size = new System.Drawing.Size(1312, 517);
            this.dgvData1.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(16, 15);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 28);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblBanyakRecordData
            // 
            this.lblBanyakRecordData.Location = new System.Drawing.Point(16, 69);
            this.lblBanyakRecordData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanyakRecordData.Name = "lblBanyakRecordData";
            this.lblBanyakRecordData.Size = new System.Drawing.Size(457, 25);
            this.lblBanyakRecordData.TabIndex = 2;
            this.lblBanyakRecordData.Text = "{ banyak record data }";
            this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.Location = new System.Drawing.Point(124, 16);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(1204, 25);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "{ filter items }";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mahasiswaDS
            // 
            this.mahasiswaDS.DataSetName = "MahasiswaDS";
            this.mahasiswaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaDSBindingSource
            // 
            this.mahasiswaDSBindingSource.DataSource = this.mahasiswaDS;
            this.mahasiswaDSBindingSource.Position = 0;
            // 
            // tMahasiswaBindingSource
            // 
            this.tMahasiswaBindingSource.DataMember = "TMahasiswa";
            this.tMahasiswaBindingSource.DataSource = this.mahasiswaDSBindingSource;
            // 
            // tMahasiswaTableAdapter
            // 
            this.tMahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // nimDataGridViewTextBoxColumn
            // 
            this.nimDataGridViewTextBoxColumn.DataPropertyName = "Nim";
            this.nimDataGridViewTextBoxColumn.HeaderText = "Nim";
            this.nimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nimDataGridViewTextBoxColumn.Name = "nimDataGridViewTextBoxColumn";
            this.nimDataGridViewTextBoxColumn.ReadOnly = true;
            this.nimDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            this.namaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "JenisKelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            this.jenisKelaminDataGridViewTextBoxColumn.ReadOnly = true;
            this.jenisKelaminDataGridViewTextBoxColumn.Width = 125;
            // 
            // programStudiDataGridViewTextBoxColumn
            // 
            this.programStudiDataGridViewTextBoxColumn.DataPropertyName = "ProgramStudi";
            this.programStudiDataGridViewTextBoxColumn.HeaderText = "Program Studi";
            this.programStudiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.programStudiDataGridViewTextBoxColumn.Name = "programStudiDataGridViewTextBoxColumn";
            this.programStudiDataGridViewTextBoxColumn.ReadOnly = true;
            this.programStudiDataGridViewTextBoxColumn.Width = 125;
            // 
            // waktuKuliahDataGridViewTextBoxColumn
            // 
            this.waktuKuliahDataGridViewTextBoxColumn.DataPropertyName = "WaktuKuliah";
            this.waktuKuliahDataGridViewTextBoxColumn.HeaderText = "Waktu Kuliah";
            this.waktuKuliahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waktuKuliahDataGridViewTextBoxColumn.Name = "waktuKuliahDataGridViewTextBoxColumn";
            this.waktuKuliahDataGridViewTextBoxColumn.ReadOnly = true;
            this.waktuKuliahDataGridViewTextBoxColumn.Width = 125;
            // 
            // kelasDataGridViewTextBoxColumn
            // 
            this.kelasDataGridViewTextBoxColumn.DataPropertyName = "Kelas";
            this.kelasDataGridViewTextBoxColumn.HeaderText = "Kelas";
            this.kelasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kelasDataGridViewTextBoxColumn.Name = "kelasDataGridViewTextBoxColumn";
            this.kelasDataGridViewTextBoxColumn.ReadOnly = true;
            this.kelasDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmEnqueryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 629);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblBanyakRecordData);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvData1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEnqueryData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enquery Data";
            this.Load += new System.EventHandler(this.FrmEnqueryData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMahasiswaBindingSource)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button btnFilter;
      private System.Windows.Forms.Label lblBanyakRecordData;
      private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.BindingSource mahasiswaDSBindingSource;
        private MahasiswaDS mahasiswaDS;
        private System.Windows.Forms.BindingSource tMahasiswaBindingSource;
        private MahasiswaDSTableAdapters.TMahasiswaTableAdapter tMahasiswaTableAdapter;
        private System.Windows.Forms.DataGridView dgvData1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programStudiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktuKuliahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelasDataGridViewTextBoxColumn;
    }
}

