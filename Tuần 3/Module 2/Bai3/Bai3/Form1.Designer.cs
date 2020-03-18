namespace Bai3
{
    partial class frmHoTen
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblHoLot = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHo = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(261, 13);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(0, 13);
            this.lblHoTen.TabIndex = 0;
            // 
            // lblHoLot
            // 
            this.lblHoLot.AutoSize = true;
            this.lblHoLot.Location = new System.Drawing.Point(58, 58);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(39, 13);
            this.lblHoLot.TabIndex = 1;
            this.lblHoLot.Text = "Họ Lót";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(58, 106);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 13);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(161, 55);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(261, 20);
            this.txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(161, 99);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(261, 20);
            this.txtTen.TabIndex = 4;
            // 
            // btnHo
            // 
            this.btnHo.Location = new System.Drawing.Point(48, 137);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(75, 23);
            this.btnHo.TabIndex = 5;
            this.btnHo.Text = "Họ Lot";
            this.btnHo.UseVisualStyleBackColor = true;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(187, 137);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Location = new System.Drawing.Point(326, 137);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(75, 23);
            this.btnHoTen.TabIndex = 7;
            this.btnHoTen.Text = "Họ & Tên";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(149, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(197, 34);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát Chương Trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmHoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 228);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHoLot);
            this.Controls.Add(this.lblHoTen);
            this.Name = "frmHoTen";
            this.Text = "Bài Tập Họ Tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblHoLot;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnThoat;
    }
}

