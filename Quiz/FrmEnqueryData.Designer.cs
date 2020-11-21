
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         this.dgvData = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.btnFilter = new System.Windows.Forms.Button();
         this.lblBanyakRecordData = new System.Windows.Forms.Label();
         this.lblFilter = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvData
         // 
         this.dgvData.AllowUserToAddRows = false;
         this.dgvData.AllowUserToDeleteRows = false;
         dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
         this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
         this.dgvData.EnableHeadersVisualStyles = false;
         this.dgvData.Location = new System.Drawing.Point(12, 79);
         this.dgvData.Name = "dgvData";
         this.dgvData.ReadOnly = true;
         this.dgvData.Size = new System.Drawing.Size(984, 420);
         this.dgvData.TabIndex = 0;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "Nim";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         // 
         // Column2
         // 
         this.Column2.HeaderText = "Nama";
         this.Column2.Name = "Column2";
         this.Column2.ReadOnly = true;
         this.Column2.Width = 200;
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Jenis Kelamin";
         this.Column3.Name = "Column3";
         this.Column3.ReadOnly = true;
         // 
         // Column4
         // 
         this.Column4.HeaderText = "Program Studi";
         this.Column4.Name = "Column4";
         this.Column4.ReadOnly = true;
         this.Column4.Width = 200;
         // 
         // Column5
         // 
         this.Column5.HeaderText = "Waktu Kuliah";
         this.Column5.Name = "Column5";
         this.Column5.ReadOnly = true;
         // 
         // Column6
         // 
         this.Column6.HeaderText = "Kelas";
         this.Column6.Name = "Column6";
         this.Column6.ReadOnly = true;
         // 
         // btnFilter
         // 
         this.btnFilter.Location = new System.Drawing.Point(12, 12);
         this.btnFilter.Name = "btnFilter";
         this.btnFilter.Size = new System.Drawing.Size(75, 23);
         this.btnFilter.TabIndex = 1;
         this.btnFilter.Text = "&Filter";
         this.btnFilter.UseVisualStyleBackColor = true;
         // 
         // lblBanyakRecordData
         // 
         this.lblBanyakRecordData.Location = new System.Drawing.Point(12, 56);
         this.lblBanyakRecordData.Name = "lblBanyakRecordData";
         this.lblBanyakRecordData.Size = new System.Drawing.Size(343, 20);
         this.lblBanyakRecordData.TabIndex = 2;
         this.lblBanyakRecordData.Text = "{ banyak record data }";
         this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblFilter
         // 
         this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lblFilter.Location = new System.Drawing.Point(93, 13);
         this.lblFilter.Name = "lblFilter";
         this.lblFilter.Size = new System.Drawing.Size(903, 20);
         this.lblFilter.TabIndex = 3;
         this.lblFilter.Text = "{ filter items }";
         this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // FrmEnqueryData
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1008, 511);
         this.Controls.Add(this.lblFilter);
         this.Controls.Add(this.lblBanyakRecordData);
         this.Controls.Add(this.btnFilter);
         this.Controls.Add(this.dgvData);
         this.KeyPreview = true;
         this.Name = "FrmEnqueryData";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Enquery Data";
         ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dgvData;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
      private System.Windows.Forms.Button btnFilter;
      private System.Windows.Forms.Label lblBanyakRecordData;
      private System.Windows.Forms.Label lblFilter;
   }
}

