namespace Bai5
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
            this.grbMangGoc = new System.Windows.Forms.GroupBox();
            this.txtMangGoc = new System.Windows.Forms.TextBox();
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.btnXuatPT = new System.Windows.Forms.Button();
            this.btnTimMin = new System.Windows.Forms.Button();
            this.btnTangGT2 = new System.Windows.Forms.Button();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnSXGiam = new System.Windows.Forms.Button();
            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnSXTang = new System.Windows.Forms.Button();
            this.btnDemPTLe = new System.Windows.Forms.Button();
            this.grbMangGoc.SuspendLayout();
            this.grbKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMangGoc
            // 
            this.grbMangGoc.Controls.Add(this.txtMangGoc);
            this.grbMangGoc.Location = new System.Drawing.Point(63, 38);
            this.grbMangGoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMangGoc.Name = "grbMangGoc";
            this.grbMangGoc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbMangGoc.Size = new System.Drawing.Size(701, 104);
            this.grbMangGoc.TabIndex = 0;
            this.grbMangGoc.TabStop = false;
            this.grbMangGoc.Text = "Mảng gốc";
            // 
            // txtMangGoc
            // 
            this.txtMangGoc.Location = new System.Drawing.Point(8, 48);
            this.txtMangGoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMangGoc.Name = "txtMangGoc";
            this.txtMangGoc.Size = new System.Drawing.Size(684, 30);
            this.txtMangGoc.TabIndex = 0;
            // 
            // grbKetQua
            // 
            this.grbKetQua.Controls.Add(this.txtOutPut);
            this.grbKetQua.Location = new System.Drawing.Point(63, 169);
            this.grbKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbKetQua.Size = new System.Drawing.Size(701, 104);
            this.grbKetQua.TabIndex = 1;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả";
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(8, 48);
            this.txtOutPut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(684, 30);
            this.txtOutPut.TabIndex = 0;
            // 
            // btnXuatPT
            // 
            this.btnXuatPT.Location = new System.Drawing.Point(63, 299);
            this.btnXuatPT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatPT.Name = "btnXuatPT";
            this.btnXuatPT.Size = new System.Drawing.Size(333, 40);
            this.btnXuatPT.TabIndex = 2;
            this.btnXuatPT.Text = "Xuất phần tử mảng ngẫu nhiên";
            this.btnXuatPT.UseVisualStyleBackColor = true;
            this.btnXuatPT.Click += new System.EventHandler(this.btnXuatPT_Click);
            // 
            // btnTimMin
            // 
            this.btnTimMin.Location = new System.Drawing.Point(431, 299);
            this.btnTimMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimMin.Name = "btnTimMin";
            this.btnTimMin.Size = new System.Drawing.Size(333, 40);
            this.btnTimMin.TabIndex = 3;
            this.btnTimMin.Text = "Tìm giá trị nhỏ nhất";
            this.btnTimMin.UseVisualStyleBackColor = true;
            this.btnTimMin.Click += new System.EventHandler(this.btnTimMin_Click);
            // 
            // btnTangGT2
            // 
            this.btnTangGT2.Location = new System.Drawing.Point(431, 346);
            this.btnTangGT2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTangGT2.Name = "btnTangGT2";
            this.btnTangGT2.Size = new System.Drawing.Size(333, 40);
            this.btnTangGT2.TabIndex = 5;
            this.btnTangGT2.Text = "Tăng PT mảng lên 2";
            this.btnTangGT2.UseVisualStyleBackColor = true;
            this.btnTangGT2.Click += new System.EventHandler(this.btnTangGT2_Click);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(63, 346);
            this.btnTinhTong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(333, 40);
            this.btnTinhTong.TabIndex = 4;
            this.btnTinhTong.Text = "Tính tổng giá trị mảng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnSXGiam
            // 
            this.btnSXGiam.Location = new System.Drawing.Point(431, 441);
            this.btnSXGiam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSXGiam.Name = "btnSXGiam";
            this.btnSXGiam.Size = new System.Drawing.Size(333, 40);
            this.btnSXGiam.TabIndex = 9;
            this.btnSXGiam.Text = "Sắp mảng giảm";
            this.btnSXGiam.UseVisualStyleBackColor = true;
            this.btnSXGiam.Click += new System.EventHandler(this.btnSXGiam_Click);
            // 
            // btnTongLe
            // 
            this.btnTongLe.Location = new System.Drawing.Point(63, 441);
            this.btnTongLe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTongLe.Name = "btnTongLe";
            this.btnTongLe.Size = new System.Drawing.Size(333, 40);
            this.btnTongLe.TabIndex = 8;
            this.btnTongLe.Text = "Tính tổng số phần tử lẻ";
            this.btnTongLe.UseVisualStyleBackColor = true;
            this.btnTongLe.Click += new System.EventHandler(this.btnTongLe_Click);
            // 
            // btnSXTang
            // 
            this.btnSXTang.Location = new System.Drawing.Point(431, 394);
            this.btnSXTang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSXTang.Name = "btnSXTang";
            this.btnSXTang.Size = new System.Drawing.Size(333, 40);
            this.btnSXTang.TabIndex = 7;
            this.btnSXTang.Text = "Sắp mảng tăng";
            this.btnSXTang.UseVisualStyleBackColor = true;
            this.btnSXTang.Click += new System.EventHandler(this.btnSXTang_Click);
            // 
            // btnDemPTLe
            // 
            this.btnDemPTLe.Location = new System.Drawing.Point(63, 394);
            this.btnDemPTLe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDemPTLe.Name = "btnDemPTLe";
            this.btnDemPTLe.Size = new System.Drawing.Size(333, 40);
            this.btnDemPTLe.TabIndex = 6;
            this.btnDemPTLe.Text = "Điểm số phần tử lẻ";
            this.btnDemPTLe.UseVisualStyleBackColor = true;
            this.btnDemPTLe.Click += new System.EventHandler(this.btnDemPTLe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 542);
            this.Controls.Add(this.btnSXGiam);
            this.Controls.Add(this.btnTongLe);
            this.Controls.Add(this.btnSXTang);
            this.Controls.Add(this.btnDemPTLe);
            this.Controls.Add(this.btnTangGT2);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.btnTimMin);
            this.Controls.Add(this.btnXuatPT);
            this.Controls.Add(this.grbKetQua);
            this.Controls.Add(this.grbMangGoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Working with Array";
            this.grbMangGoc.ResumeLayout(false);
            this.grbMangGoc.PerformLayout();
            this.grbKetQua.ResumeLayout(false);
            this.grbKetQua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMangGoc;
        private System.Windows.Forms.TextBox txtMangGoc;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Button btnXuatPT;
        private System.Windows.Forms.Button btnTimMin;
        private System.Windows.Forms.Button btnTangGT2;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnSXGiam;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnSXTang;
        private System.Windows.Forms.Button btnDemPTLe;
    }
}

