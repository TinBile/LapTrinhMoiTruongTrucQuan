namespace Bai5
{
    partial class frmDinhDang
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
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grbForn = new System.Windows.Forms.GroupBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.chkNghien = new System.Windows.Forms.CheckBox();
            this.chkDam = new System.Windows.Forms.CheckBox();
            this.lblLapTrinhBoi = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.grbColor.SuspendLayout();
            this.grbForn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTen.ForeColor = System.Drawing.Color.Green;
            this.lblNhapTen.Location = new System.Drawing.Point(12, 17);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(63, 13);
            this.lblNhapTen.TabIndex = 0;
            this.lblNhapTen.Text = "Nhập Tên";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(81, 14);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(325, 20);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            // 
            // grbColor
            // 
            this.grbColor.BackColor = System.Drawing.Color.Aqua;
            this.grbColor.Controls.Add(this.radBlack);
            this.grbColor.Controls.Add(this.radBlue);
            this.grbColor.Controls.Add(this.radGreen);
            this.grbColor.Controls.Add(this.radRed);
            this.grbColor.Location = new System.Drawing.Point(24, 66);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(169, 139);
            this.grbColor.TabIndex = 2;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Color";
            this.grbColor.Enter += new System.EventHandler(this.grbColor_Enter);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(17, 103);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(52, 17);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(17, 80);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(17, 57);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(17, 34);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // grbForn
            // 
            this.grbForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grbForn.Controls.Add(this.chkGachChan);
            this.grbForn.Controls.Add(this.chkNghien);
            this.grbForn.Controls.Add(this.chkDam);
            this.grbForn.Location = new System.Drawing.Point(216, 66);
            this.grbForn.Name = "grbForn";
            this.grbForn.Size = new System.Drawing.Size(190, 139);
            this.grbForn.TabIndex = 3;
            this.grbForn.TabStop = false;
            this.grbForn.Text = "Forn";
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachChan.Location = new System.Drawing.Point(28, 103);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(79, 18);
            this.chkGachChan.TabIndex = 2;
            this.chkGachChan.Text = "Gạch Chân";
            this.chkGachChan.UseVisualStyleBackColor = true;
            this.chkGachChan.CheckedChanged += new System.EventHandler(this.chkGachChan_CheckedChanged);
            // 
            // chkNghien
            // 
            this.chkNghien.AutoSize = true;
            this.chkNghien.Font = new System.Drawing.Font("Vladimir Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNghien.Location = new System.Drawing.Point(28, 58);
            this.chkNghien.Name = "chkNghien";
            this.chkNghien.Size = new System.Drawing.Size(54, 17);
            this.chkNghien.TabIndex = 1;
            this.chkNghien.Text = "Nghiên";
            this.chkNghien.UseVisualStyleBackColor = true;
            this.chkNghien.CheckedChanged += new System.EventHandler(this.chkNghien_CheckedChanged);
            // 
            // chkDam
            // 
            this.chkDam.AutoSize = true;
            this.chkDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDam.Location = new System.Drawing.Point(28, 20);
            this.chkDam.Name = "chkDam";
            this.chkDam.Size = new System.Drawing.Size(51, 17);
            this.chkDam.TabIndex = 0;
            this.chkDam.Text = "Đậm";
            this.chkDam.UseVisualStyleBackColor = true;
            this.chkDam.CheckedChanged += new System.EventHandler(this.chkDam_CheckedChanged);
            // 
            // lblLapTrinhBoi
            // 
            this.lblLapTrinhBoi.AutoSize = true;
            this.lblLapTrinhBoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapTrinhBoi.ForeColor = System.Drawing.Color.Maroon;
            this.lblLapTrinhBoi.Location = new System.Drawing.Point(41, 231);
            this.lblLapTrinhBoi.Name = "lblLapTrinhBoi";
            this.lblLapTrinhBoi.Size = new System.Drawing.Size(83, 13);
            this.lblLapTrinhBoi.TabIndex = 4;
            this.lblLapTrinhBoi.Text = "Lập Trình Bởi";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(287, 220);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.AutoSize = true;
            this.lblLapTrinh.Location = new System.Drawing.Point(163, 231);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(0, 13);
            this.lblLapTrinh.TabIndex = 7;
            // 
            // frmDinhDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 274);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblLapTrinhBoi);
            this.Controls.Add(this.grbForn);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.lblNhapTen);
            this.Name = "frmDinhDang";
            this.Text = "Định Dạng";
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.grbForn.ResumeLayout(false);
            this.grbForn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox grbForn;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.CheckBox chkNghien;
        private System.Windows.Forms.CheckBox chkDam;
        private System.Windows.Forms.Label lblLapTrinhBoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblLapTrinh;
    }
}

