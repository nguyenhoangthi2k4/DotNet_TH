namespace Bai7
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNhapMang = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtNhapMang = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.grbTinhTong = new System.Windows.Forms.GroupBox();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.txtTongMang = new System.Windows.Forms.TextBox();
            this.lblTongLe = new System.Windows.Forms.Label();
            this.lblTongMang = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.lblTongChan = new System.Windows.Forms.Label();
            this.grbMaxMin = new System.Windows.Forms.GroupBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.grbSapXep = new System.Windows.Forms.GroupBox();
            this.grbThayThe = new System.Windows.Forms.GroupBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.lblViTri = new System.Windows.Forms.Label();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.rdSXTang = new System.Windows.Forms.RadioButton();
            this.rdSXGiam = new System.Windows.Forms.RadioButton();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnTimMaxMin = new System.Windows.Forms.Button();
            this.btnThayThe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.grbTinhTong.SuspendLayout();
            this.grbMaxMin.SuspendLayout();
            this.grbSapXep.SuspendLayout();
            this.grbThayThe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng số nguyên";
            // 
            // lblNhapMang
            // 
            this.lblNhapMang.AutoSize = true;
            this.lblNhapMang.Location = new System.Drawing.Point(85, 76);
            this.lblNhapMang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapMang.Name = "lblNhapMang";
            this.lblNhapMang.Size = new System.Drawing.Size(119, 25);
            this.lblNhapMang.TabIndex = 1;
            this.lblNhapMang.Text = "Nhập mảng:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(85, 134);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(86, 25);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // txtNhapMang
            // 
            this.txtNhapMang.Location = new System.Drawing.Point(219, 72);
            this.txtNhapMang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhapMang.Name = "txtNhapMang";
            this.txtNhapMang.Size = new System.Drawing.Size(593, 30);
            this.txtNhapMang.TabIndex = 3;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(219, 130);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(593, 30);
            this.txtKetQua.TabIndex = 4;
            // 
            // btnXuatMang
            // 
            this.btnXuatMang.Location = new System.Drawing.Point(858, 63);
            this.btnXuatMang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatMang.Name = "btnXuatMang";
            this.btnXuatMang.Size = new System.Drawing.Size(123, 50);
            this.btnXuatMang.TabIndex = 5;
            this.btnXuatMang.Text = "Xuất mảng";
            this.btnXuatMang.UseVisualStyleBackColor = true;
            this.btnXuatMang.Click += new System.EventHandler(this.btnXuatMang_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(858, 120);
            this.btnLamLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(123, 50);
            this.btnLamLai.TabIndex = 6;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // grbTinhTong
            // 
            this.grbTinhTong.Controls.Add(this.btnTinhTong);
            this.grbTinhTong.Controls.Add(this.txtTongChan);
            this.grbTinhTong.Controls.Add(this.lblTongChan);
            this.grbTinhTong.Controls.Add(this.txtTongLe);
            this.grbTinhTong.Controls.Add(this.txtTongMang);
            this.grbTinhTong.Controls.Add(this.lblTongLe);
            this.grbTinhTong.Controls.Add(this.lblTongMang);
            this.grbTinhTong.Location = new System.Drawing.Point(79, 205);
            this.grbTinhTong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbTinhTong.Name = "grbTinhTong";
            this.grbTinhTong.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbTinhTong.Size = new System.Drawing.Size(404, 182);
            this.grbTinhTong.TabIndex = 7;
            this.grbTinhTong.TabStop = false;
            this.grbTinhTong.Text = "Tính tổng";
            // 
            // txtTongLe
            // 
            this.txtTongLe.Location = new System.Drawing.Point(151, 90);
            this.txtTongLe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(90, 30);
            this.txtTongLe.TabIndex = 8;
            // 
            // txtTongMang
            // 
            this.txtTongMang.Location = new System.Drawing.Point(151, 44);
            this.txtTongMang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongMang.Name = "txtTongMang";
            this.txtTongMang.Size = new System.Drawing.Size(90, 30);
            this.txtTongMang.TabIndex = 7;
            // 
            // lblTongLe
            // 
            this.lblTongLe.AutoSize = true;
            this.lblTongLe.Location = new System.Drawing.Point(11, 94);
            this.lblTongLe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongLe.Name = "lblTongLe";
            this.lblTongLe.Size = new System.Drawing.Size(115, 25);
            this.lblTongLe.TabIndex = 6;
            this.lblTongLe.Text = "Tổng PT lẻ:";
            // 
            // lblTongMang
            // 
            this.lblTongMang.AutoSize = true;
            this.lblTongMang.Location = new System.Drawing.Point(11, 48);
            this.lblTongMang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongMang.Name = "lblTongMang";
            this.lblTongMang.Size = new System.Drawing.Size(118, 25);
            this.lblTongMang.TabIndex = 5;
            this.lblTongMang.Text = "Tổng mảng:";
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(151, 132);
            this.txtTongChan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(90, 30);
            this.txtTongChan.TabIndex = 10;
            // 
            // lblTongChan
            // 
            this.lblTongChan.AutoSize = true;
            this.lblTongChan.Location = new System.Drawing.Point(11, 136);
            this.lblTongChan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongChan.Name = "lblTongChan";
            this.lblTongChan.Size = new System.Drawing.Size(143, 25);
            this.lblTongChan.TabIndex = 9;
            this.lblTongChan.Text = "Tổng PT chẵn:";
            // 
            // grbMaxMin
            // 
            this.grbMaxMin.Controls.Add(this.btnTimMaxMin);
            this.grbMaxMin.Controls.Add(this.txtMin);
            this.grbMaxMin.Controls.Add(this.txtMax);
            this.grbMaxMin.Controls.Add(this.lblMin);
            this.grbMaxMin.Controls.Add(this.lblMax);
            this.grbMaxMin.Location = new System.Drawing.Point(583, 205);
            this.grbMaxMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMaxMin.Name = "grbMaxMin";
            this.grbMaxMin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMaxMin.Size = new System.Drawing.Size(404, 182);
            this.grbMaxMin.TabIndex = 8;
            this.grbMaxMin.TabStop = false;
            this.grbMaxMin.Text = "Tìm Max Min";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(104, 111);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(132, 30);
            this.txtMin.TabIndex = 8;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(104, 44);
            this.txtMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(132, 30);
            this.txtMax.TabIndex = 7;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(8, 115);
            this.lblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(50, 25);
            this.lblMin.TabIndex = 6;
            this.lblMin.Text = "Min:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(11, 48);
            this.lblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(56, 25);
            this.lblMax.TabIndex = 5;
            this.lblMax.Text = "Max:";
            // 
            // grbSapXep
            // 
            this.grbSapXep.Controls.Add(this.btnSapXep);
            this.grbSapXep.Controls.Add(this.rdSXGiam);
            this.grbSapXep.Controls.Add(this.rdSXTang);
            this.grbSapXep.Location = new System.Drawing.Point(79, 402);
            this.grbSapXep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSapXep.Name = "grbSapXep";
            this.grbSapXep.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbSapXep.Size = new System.Drawing.Size(404, 144);
            this.grbSapXep.TabIndex = 9;
            this.grbSapXep.TabStop = false;
            this.grbSapXep.Text = "Sắp Xếp";
            // 
            // grbThayThe
            // 
            this.grbThayThe.Controls.Add(this.btnThayThe);
            this.grbThayThe.Controls.Add(this.txtViTri);
            this.grbThayThe.Controls.Add(this.txtGiaTri);
            this.grbThayThe.Controls.Add(this.lblViTri);
            this.grbThayThe.Controls.Add(this.lblGiaTri);
            this.grbThayThe.Location = new System.Drawing.Point(583, 402);
            this.grbThayThe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbThayThe.Name = "grbThayThe";
            this.grbThayThe.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbThayThe.Size = new System.Drawing.Size(404, 144);
            this.grbThayThe.TabIndex = 11;
            this.grbThayThe.TabStop = false;
            this.grbThayThe.Text = "Thay thế";
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(104, 90);
            this.txtViTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(132, 30);
            this.txtViTri.TabIndex = 8;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(104, 44);
            this.txtGiaTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(132, 30);
            this.txtGiaTri.TabIndex = 7;
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(11, 94);
            this.lblViTri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(56, 25);
            this.lblViTri.TabIndex = 6;
            this.lblViTri.Text = "Vị trị:";
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.AutoSize = true;
            this.lblGiaTri.Location = new System.Drawing.Point(11, 48);
            this.lblGiaTri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(68, 25);
            this.lblGiaTri.TabIndex = 5;
            this.lblGiaTri.Text = "Giá trị:";
            // 
            // rdSXTang
            // 
            this.rdSXTang.AutoSize = true;
            this.rdSXTang.Location = new System.Drawing.Point(17, 48);
            this.rdSXTang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdSXTang.Name = "rdSXTang";
            this.rdSXTang.Size = new System.Drawing.Size(161, 29);
            this.rdSXTang.TabIndex = 0;
            this.rdSXTang.TabStop = true;
            this.rdSXTang.Text = "Sắp xếp Tăng";
            this.rdSXTang.UseVisualStyleBackColor = true;
            // 
            // rdSXGiam
            // 
            this.rdSXGiam.AutoSize = true;
            this.rdSXGiam.Location = new System.Drawing.Point(17, 94);
            this.rdSXGiam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdSXGiam.Name = "rdSXGiam";
            this.rdSXGiam.Size = new System.Drawing.Size(161, 29);
            this.rdSXGiam.TabIndex = 1;
            this.rdSXGiam.TabStop = true;
            this.rdSXGiam.Text = "Sắp xếp Giảm";
            this.rdSXGiam.UseVisualStyleBackColor = true;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(276, 44);
            this.btnTinhTong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(100, 117);
            this.btnTinhTong.TabIndex = 11;
            this.btnTinhTong.Text = "Tính\r\ntổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnTimMaxMin
            // 
            this.btnTimMaxMin.Location = new System.Drawing.Point(281, 44);
            this.btnTimMaxMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimMaxMin.Name = "btnTimMaxMin";
            this.btnTimMaxMin.Size = new System.Drawing.Size(100, 97);
            this.btnTimMaxMin.TabIndex = 12;
            this.btnTimMaxMin.Text = "Tìm ";
            this.btnTimMaxMin.UseVisualStyleBackColor = true;
            this.btnTimMaxMin.Click += new System.EventHandler(this.btnTimMaxMin_Click);
            // 
            // btnThayThe
            // 
            this.btnThayThe.Location = new System.Drawing.Point(281, 44);
            this.btnThayThe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThayThe.Name = "btnThayThe";
            this.btnThayThe.Size = new System.Drawing.Size(100, 75);
            this.btnThayThe.TabIndex = 13;
            this.btnThayThe.Text = "Thay thế";
            this.btnThayThe.UseVisualStyleBackColor = true;
            this.btnThayThe.Click += new System.EventHandler(this.btnThayThe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(484, 572);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 46);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(276, 48);
            this.btnSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(100, 75);
            this.btnSapXep.TabIndex = 12;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 634);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbThayThe);
            this.Controls.Add(this.grbSapXep);
            this.Controls.Add(this.grbMaxMin);
            this.Controls.Add(this.grbTinhTong);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXuatMang);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhapMang);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblNhapMang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai7";
            this.grbTinhTong.ResumeLayout(false);
            this.grbTinhTong.PerformLayout();
            this.grbMaxMin.ResumeLayout(false);
            this.grbMaxMin.PerformLayout();
            this.grbSapXep.ResumeLayout(false);
            this.grbSapXep.PerformLayout();
            this.grbThayThe.ResumeLayout(false);
            this.grbThayThe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNhapMang;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtNhapMang;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnXuatMang;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.GroupBox grbTinhTong;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Label lblTongChan;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.TextBox txtTongMang;
        private System.Windows.Forms.Label lblTongLe;
        private System.Windows.Forms.Label lblTongMang;
        private System.Windows.Forms.GroupBox grbMaxMin;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.GroupBox grbSapXep;
        private System.Windows.Forms.RadioButton rdSXGiam;
        private System.Windows.Forms.RadioButton rdSXTang;
        private System.Windows.Forms.GroupBox grbThayThe;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnTimMaxMin;
        private System.Windows.Forms.Button btnThayThe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSapXep;
    }
}

