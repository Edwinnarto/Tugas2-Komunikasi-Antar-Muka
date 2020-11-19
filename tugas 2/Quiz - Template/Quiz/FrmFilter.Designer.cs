
namespace Quiz
{
   partial class FrmFilter
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
            this.lblBanyakRecordData = new System.Windows.Forms.Label();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboJenisKelamin = new System.Windows.Forms.ComboBox();
            this.cboProgramStudi = new System.Windows.Forms.ComboBox();
            this.cboWaktuKuliah = new System.Windows.Forms.ComboBox();
            this.cboKelas = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBanyakRecordData
            // 
            this.lblBanyakRecordData.Location = new System.Drawing.Point(12, 15);
            this.lblBanyakRecordData.Name = "lblBanyakRecordData";
            this.lblBanyakRecordData.Size = new System.Drawing.Size(98, 20);
            this.lblBanyakRecordData.TabIndex = 3;
            this.lblBanyakRecordData.Text = "Nim";
            this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNim
            // 
            this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNim.Location = new System.Drawing.Point(116, 15);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(156, 20);
            this.txtNim.TabIndex = 0;
            this.txtNim.TextChanged += new System.EventHandler(this.txtNim_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Location = new System.Drawing.Point(116, 41);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(156, 20);
            this.txtNama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jenis Kelamin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Program Studi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Waktu Kuliah";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kelas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboJenisKelamin
            // 
            this.cboJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJenisKelamin.FormattingEnabled = true;
            this.cboJenisKelamin.Items.AddRange(new object[] {
            "",
            "Pria",
            "Wanita"});
            this.cboJenisKelamin.Location = new System.Drawing.Point(116, 67);
            this.cboJenisKelamin.Name = "cboJenisKelamin";
            this.cboJenisKelamin.Size = new System.Drawing.Size(156, 21);
            this.cboJenisKelamin.TabIndex = 2;
            // 
            // cboProgramStudi
            // 
            this.cboProgramStudi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramStudi.FormattingEnabled = true;
            this.cboProgramStudi.Items.AddRange(new object[] {
            "",
            "TI",
            "SI"});
            this.cboProgramStudi.Location = new System.Drawing.Point(116, 93);
            this.cboProgramStudi.Name = "cboProgramStudi";
            this.cboProgramStudi.Size = new System.Drawing.Size(156, 21);
            this.cboProgramStudi.TabIndex = 3;
            // 
            // cboWaktuKuliah
            // 
            this.cboWaktuKuliah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWaktuKuliah.FormattingEnabled = true;
            this.cboWaktuKuliah.Items.AddRange(new object[] {
            "",
            "Pagi",
            "Sore"});
            this.cboWaktuKuliah.Location = new System.Drawing.Point(116, 119);
            this.cboWaktuKuliah.Name = "cboWaktuKuliah";
            this.cboWaktuKuliah.Size = new System.Drawing.Size(156, 21);
            this.cboWaktuKuliah.TabIndex = 4;
            // 
            // cboKelas
            // 
            this.cboKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKelas.FormattingEnabled = true;
            this.cboKelas.Items.AddRange(new object[] {
            "",
            "A",
            "B"});
            this.cboKelas.Location = new System.Drawing.Point(116, 145);
            this.cboKelas.Name = "cboKelas";
            this.cboKelas.Size = new System.Drawing.Size(156, 21);
            this.cboKelas.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(116, 182);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(197, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 215);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cboKelas);
            this.Controls.Add(this.cboWaktuKuliah);
            this.Controls.Add(this.cboProgramStudi);
            this.Controls.Add(this.cboJenisKelamin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.lblBanyakRecordData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kriteria Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblBanyakRecordData;
      private System.Windows.Forms.TextBox txtNim;
      private System.Windows.Forms.TextBox txtNama;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox cboJenisKelamin;
      private System.Windows.Forms.ComboBox cboProgramStudi;
      private System.Windows.Forms.ComboBox cboWaktuKuliah;
      private System.Windows.Forms.ComboBox cboKelas;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnClear;
   }
}