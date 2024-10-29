namespace Bai3
{
    partial class frmMain
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
            this.gbPhanSo1 = new System.Windows.Forms.GroupBox();
            this.lblMauSo1 = new System.Windows.Forms.Label();
            this.lblTuSo1 = new System.Windows.Forms.Label();
            this.txtMauSo1 = new System.Windows.Forms.TextBox();
            this.txtTuSo1 = new System.Windows.Forms.TextBox();
            this.gbPhepTinh = new System.Windows.Forms.GroupBox();
            this.btnTinhThuong = new System.Windows.Forms.Button();
            this.btnTinhHieu = new System.Windows.Forms.Button();
            this.btnTinhTich = new System.Windows.Forms.Button();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbPhanSo2 = new System.Windows.Forms.GroupBox();
            this.lblMauSo2 = new System.Windows.Forms.Label();
            this.lblTuSo2 = new System.Windows.Forms.Label();
            this.txtMauSo2 = new System.Windows.Forms.TextBox();
            this.txtTuSo2 = new System.Windows.Forms.TextBox();
            this.gbKetQua = new System.Windows.Forms.GroupBox();
            this.lblMauSoKQ = new System.Windows.Forms.Label();
            this.lblTuSoKQ = new System.Windows.Forms.Label();
            this.txtMauSoKQ = new System.Windows.Forms.TextBox();
            this.txtTuSoKQ = new System.Windows.Forms.TextBox();
            this.errorProvider_MS1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_MS2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPhanSo1.SuspendLayout();
            this.gbPhepTinh.SuspendLayout();
            this.gbPhanSo2.SuspendLayout();
            this.gbKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MS2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(260, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phép tính Phân số";
            // 
            // gbPhanSo1
            // 
            this.gbPhanSo1.Controls.Add(this.lblMauSo1);
            this.gbPhanSo1.Controls.Add(this.lblTuSo1);
            this.gbPhanSo1.Controls.Add(this.txtMauSo1);
            this.gbPhanSo1.Controls.Add(this.txtTuSo1);
            this.gbPhanSo1.Location = new System.Drawing.Point(52, 77);
            this.gbPhanSo1.Margin = new System.Windows.Forms.Padding(4);
            this.gbPhanSo1.Name = "gbPhanSo1";
            this.gbPhanSo1.Padding = new System.Windows.Forms.Padding(4);
            this.gbPhanSo1.Size = new System.Drawing.Size(293, 141);
            this.gbPhanSo1.TabIndex = 0;
            this.gbPhanSo1.TabStop = false;
            this.gbPhanSo1.Text = "Phân số 1";
            // 
            // lblMauSo1
            // 
            this.lblMauSo1.AutoSize = true;
            this.lblMauSo1.Location = new System.Drawing.Point(28, 95);
            this.lblMauSo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMauSo1.Name = "lblMauSo1";
            this.lblMauSo1.Size = new System.Drawing.Size(83, 25);
            this.lblMauSo1.TabIndex = 3;
            this.lblMauSo1.Text = "Mẫu số:";
            // 
            // lblTuSo1
            // 
            this.lblTuSo1.AutoSize = true;
            this.lblTuSo1.Location = new System.Drawing.Point(28, 46);
            this.lblTuSo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuSo1.Name = "lblTuSo1";
            this.lblTuSo1.Size = new System.Drawing.Size(68, 25);
            this.lblTuSo1.TabIndex = 2;
            this.lblTuSo1.Text = "Tử số:";
            // 
            // txtMauSo1
            // 
            this.txtMauSo1.Location = new System.Drawing.Point(135, 88);
            this.txtMauSo1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMauSo1.Name = "txtMauSo1";
            this.txtMauSo1.Size = new System.Drawing.Size(132, 30);
            this.txtMauSo1.TabIndex = 1;
            // 
            // txtTuSo1
            // 
            this.txtTuSo1.Location = new System.Drawing.Point(135, 40);
            this.txtTuSo1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuSo1.Name = "txtTuSo1";
            this.txtTuSo1.Size = new System.Drawing.Size(132, 30);
            this.txtTuSo1.TabIndex = 0;
            // 
            // gbPhepTinh
            // 
            this.gbPhepTinh.Controls.Add(this.btnTinhThuong);
            this.gbPhepTinh.Controls.Add(this.btnTinhHieu);
            this.gbPhepTinh.Controls.Add(this.btnTinhTich);
            this.gbPhepTinh.Controls.Add(this.btnTinhTong);
            this.gbPhepTinh.Location = new System.Drawing.Point(52, 238);
            this.gbPhepTinh.Margin = new System.Windows.Forms.Padding(4);
            this.gbPhepTinh.Name = "gbPhepTinh";
            this.gbPhepTinh.Padding = new System.Windows.Forms.Padding(4);
            this.gbPhepTinh.Size = new System.Drawing.Size(293, 153);
            this.gbPhepTinh.TabIndex = 2;
            this.gbPhepTinh.TabStop = false;
            this.gbPhepTinh.Text = "Phép tính";
            // 
            // btnTinhThuong
            // 
            this.btnTinhThuong.Location = new System.Drawing.Point(166, 90);
            this.btnTinhThuong.Name = "btnTinhThuong";
            this.btnTinhThuong.Size = new System.Drawing.Size(95, 44);
            this.btnTinhThuong.TabIndex = 3;
            this.btnTinhThuong.Text = "Thương";
            this.btnTinhThuong.UseVisualStyleBackColor = true;
            this.btnTinhThuong.Click += new System.EventHandler(this.btnTinhThuong_Click);
            // 
            // btnTinhHieu
            // 
            this.btnTinhHieu.Location = new System.Drawing.Point(166, 30);
            this.btnTinhHieu.Name = "btnTinhHieu";
            this.btnTinhHieu.Size = new System.Drawing.Size(95, 44);
            this.btnTinhHieu.TabIndex = 1;
            this.btnTinhHieu.Text = "Hiệu";
            this.btnTinhHieu.UseVisualStyleBackColor = true;
            this.btnTinhHieu.Click += new System.EventHandler(this.btnTinhHieu_Click);
            // 
            // btnTinhTich
            // 
            this.btnTinhTich.Location = new System.Drawing.Point(33, 90);
            this.btnTinhTich.Name = "btnTinhTich";
            this.btnTinhTich.Size = new System.Drawing.Size(95, 44);
            this.btnTinhTich.TabIndex = 2;
            this.btnTinhTich.Text = "Nhân";
            this.btnTinhTich.UseVisualStyleBackColor = true;
            this.btnTinhTich.Click += new System.EventHandler(this.btnTinhTich_Click);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(33, 30);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(95, 44);
            this.btnTinhTong.TabIndex = 0;
            this.btnTinhTong.Text = "Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(242, 405);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(122, 33);
            this.btnTiepTuc.TabIndex = 3;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(427, 405);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbPhanSo2
            // 
            this.gbPhanSo2.Controls.Add(this.lblMauSo2);
            this.gbPhanSo2.Controls.Add(this.lblTuSo2);
            this.gbPhanSo2.Controls.Add(this.txtMauSo2);
            this.gbPhanSo2.Controls.Add(this.txtTuSo2);
            this.gbPhanSo2.Location = new System.Drawing.Point(453, 77);
            this.gbPhanSo2.Margin = new System.Windows.Forms.Padding(4);
            this.gbPhanSo2.Name = "gbPhanSo2";
            this.gbPhanSo2.Padding = new System.Windows.Forms.Padding(4);
            this.gbPhanSo2.Size = new System.Drawing.Size(293, 141);
            this.gbPhanSo2.TabIndex = 1;
            this.gbPhanSo2.TabStop = false;
            this.gbPhanSo2.Text = "Phân số 2";
            // 
            // lblMauSo2
            // 
            this.lblMauSo2.AutoSize = true;
            this.lblMauSo2.Location = new System.Drawing.Point(28, 95);
            this.lblMauSo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMauSo2.Name = "lblMauSo2";
            this.lblMauSo2.Size = new System.Drawing.Size(83, 25);
            this.lblMauSo2.TabIndex = 3;
            this.lblMauSo2.Text = "Mẫu số:";
            // 
            // lblTuSo2
            // 
            this.lblTuSo2.AutoSize = true;
            this.lblTuSo2.Location = new System.Drawing.Point(28, 46);
            this.lblTuSo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuSo2.Name = "lblTuSo2";
            this.lblTuSo2.Size = new System.Drawing.Size(68, 25);
            this.lblTuSo2.TabIndex = 2;
            this.lblTuSo2.Text = "Tử số:";
            // 
            // txtMauSo2
            // 
            this.txtMauSo2.Location = new System.Drawing.Point(135, 88);
            this.txtMauSo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMauSo2.Name = "txtMauSo2";
            this.txtMauSo2.Size = new System.Drawing.Size(132, 30);
            this.txtMauSo2.TabIndex = 2;
            // 
            // txtTuSo2
            // 
            this.txtTuSo2.Location = new System.Drawing.Point(135, 40);
            this.txtTuSo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuSo2.Name = "txtTuSo2";
            this.txtTuSo2.Size = new System.Drawing.Size(132, 30);
            this.txtTuSo2.TabIndex = 1;
            // 
            // gbKetQua
            // 
            this.gbKetQua.Controls.Add(this.lblMauSoKQ);
            this.gbKetQua.Controls.Add(this.lblTuSoKQ);
            this.gbKetQua.Controls.Add(this.txtMauSoKQ);
            this.gbKetQua.Controls.Add(this.txtTuSoKQ);
            this.gbKetQua.Location = new System.Drawing.Point(453, 238);
            this.gbKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.gbKetQua.Name = "gbKetQua";
            this.gbKetQua.Padding = new System.Windows.Forms.Padding(4);
            this.gbKetQua.Size = new System.Drawing.Size(293, 153);
            this.gbKetQua.TabIndex = 8;
            this.gbKetQua.TabStop = false;
            this.gbKetQua.Text = "Kết quả";
            // 
            // lblMauSoKQ
            // 
            this.lblMauSoKQ.AutoSize = true;
            this.lblMauSoKQ.Location = new System.Drawing.Point(28, 95);
            this.lblMauSoKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMauSoKQ.Name = "lblMauSoKQ";
            this.lblMauSoKQ.Size = new System.Drawing.Size(83, 25);
            this.lblMauSoKQ.TabIndex = 3;
            this.lblMauSoKQ.Text = "Mẫu số:";
            // 
            // lblTuSoKQ
            // 
            this.lblTuSoKQ.AutoSize = true;
            this.lblTuSoKQ.Location = new System.Drawing.Point(28, 46);
            this.lblTuSoKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuSoKQ.Name = "lblTuSoKQ";
            this.lblTuSoKQ.Size = new System.Drawing.Size(68, 25);
            this.lblTuSoKQ.TabIndex = 2;
            this.lblTuSoKQ.Text = "Tử số:";
            // 
            // txtMauSoKQ
            // 
            this.txtMauSoKQ.Location = new System.Drawing.Point(135, 88);
            this.txtMauSoKQ.Margin = new System.Windows.Forms.Padding(4);
            this.txtMauSoKQ.Name = "txtMauSoKQ";
            this.txtMauSoKQ.Size = new System.Drawing.Size(132, 30);
            this.txtMauSoKQ.TabIndex = 1;
            // 
            // txtTuSoKQ
            // 
            this.txtTuSoKQ.Location = new System.Drawing.Point(135, 40);
            this.txtTuSoKQ.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuSoKQ.Name = "txtTuSoKQ";
            this.txtTuSoKQ.Size = new System.Drawing.Size(132, 30);
            this.txtTuSoKQ.TabIndex = 0;
            // 
            // errorProvider_MS1
            // 
            this.errorProvider_MS1.ContainerControl = this;
            // 
            // errorProvider_MS2
            // 
            this.errorProvider_MS2.ContainerControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.gbKetQua);
            this.Controls.Add(this.gbPhanSo2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.gbPhepTinh);
            this.Controls.Add(this.gbPhanSo1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân số";
            this.gbPhanSo1.ResumeLayout(false);
            this.gbPhanSo1.PerformLayout();
            this.gbPhepTinh.ResumeLayout(false);
            this.gbPhanSo2.ResumeLayout(false);
            this.gbPhanSo2.PerformLayout();
            this.gbKetQua.ResumeLayout(false);
            this.gbKetQua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_MS2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPhanSo1;
        private System.Windows.Forms.Label lblMauSo1;
        private System.Windows.Forms.Label lblTuSo1;
        private System.Windows.Forms.TextBox txtMauSo1;
        private System.Windows.Forms.TextBox txtTuSo1;
        private System.Windows.Forms.GroupBox gbPhepTinh;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinhThuong;
        private System.Windows.Forms.Button btnTinhHieu;
        private System.Windows.Forms.Button btnTinhTich;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.GroupBox gbPhanSo2;
        private System.Windows.Forms.Label lblMauSo2;
        private System.Windows.Forms.Label lblTuSo2;
        private System.Windows.Forms.TextBox txtMauSo2;
        private System.Windows.Forms.TextBox txtTuSo2;
        private System.Windows.Forms.GroupBox gbKetQua;
        private System.Windows.Forms.Label lblMauSoKQ;
        private System.Windows.Forms.Label lblTuSoKQ;
        private System.Windows.Forms.TextBox txtMauSoKQ;
        private System.Windows.Forms.TextBox txtTuSoKQ;
        private System.Windows.Forms.ErrorProvider errorProvider_MS1;
        private System.Windows.Forms.ErrorProvider errorProvider_MS2;
    }
}

