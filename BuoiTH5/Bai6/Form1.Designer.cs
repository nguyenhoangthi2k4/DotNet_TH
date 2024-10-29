namespace Bai6
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
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.rdTaoMangNN = new System.Windows.Forms.RadioButton();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.rdLKSoChan = new System.Windows.Forms.RadioButton();
            this.rdTimSoChan = new System.Windows.Forms.RadioButton();
            this.rdDemSoLe = new System.Windows.Forms.RadioButton();
            this.rdTongChan = new System.Windows.Forms.RadioButton();
            this.rdDemSoChan = new System.Windows.Forms.RadioButton();
            this.rdTongLe = new System.Windows.Forms.RadioButton();
            this.rdTimMin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHuy = new System.Windows.Forms.RadioButton();
            this.grbMangGoc.SuspendLayout();
            this.grbKetQua.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMangGoc
            // 
            this.grbMangGoc.Controls.Add(this.txtMangGoc);
            this.grbMangGoc.Location = new System.Drawing.Point(44, 69);
            this.grbMangGoc.Margin = new System.Windows.Forms.Padding(4);
            this.grbMangGoc.Name = "grbMangGoc";
            this.grbMangGoc.Padding = new System.Windows.Forms.Padding(4);
            this.grbMangGoc.Size = new System.Drawing.Size(701, 86);
            this.grbMangGoc.TabIndex = 0;
            this.grbMangGoc.TabStop = false;
            this.grbMangGoc.Text = "Mảng gốc";
            // 
            // txtMangGoc
            // 
            this.txtMangGoc.Location = new System.Drawing.Point(15, 36);
            this.txtMangGoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMangGoc.Name = "txtMangGoc";
            this.txtMangGoc.Size = new System.Drawing.Size(667, 30);
            this.txtMangGoc.TabIndex = 0;
            // 
            // grbKetQua
            // 
            this.grbKetQua.Controls.Add(this.txtKetQua);
            this.grbKetQua.Location = new System.Drawing.Point(44, 174);
            this.grbKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Padding = new System.Windows.Forms.Padding(4);
            this.grbKetQua.Size = new System.Drawing.Size(701, 86);
            this.grbKetQua.TabIndex = 1;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Kết quả";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(15, 36);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(667, 30);
            this.txtKetQua.TabIndex = 0;
            // 
            // rdTaoMangNN
            // 
            this.rdTaoMangNN.AutoSize = true;
            this.rdTaoMangNN.Location = new System.Drawing.Point(7, 20);
            this.rdTaoMangNN.Margin = new System.Windows.Forms.Padding(4);
            this.rdTaoMangNN.Name = "rdTaoMangNN";
            this.rdTaoMangNN.Size = new System.Drawing.Size(228, 29);
            this.rdTaoMangNN.TabIndex = 1;
            this.rdTaoMangNN.TabStop = true;
            this.rdTaoMangNN.Text = "Tạo mảng ngẫu nhiên";
            this.rdTaoMangNN.UseVisualStyleBackColor = true;
            this.rdTaoMangNN.CheckedChanged += new System.EventHandler(this.rdTaoMangNN_CheckedChanged);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.rdLKSoChan);
            this.grbChucNang.Controls.Add(this.rdTimSoChan);
            this.grbChucNang.Controls.Add(this.rdDemSoLe);
            this.grbChucNang.Controls.Add(this.rdTongChan);
            this.grbChucNang.Controls.Add(this.rdDemSoChan);
            this.grbChucNang.Controls.Add(this.rdTongLe);
            this.grbChucNang.Controls.Add(this.rdTimMin);
            this.grbChucNang.Location = new System.Drawing.Point(44, 268);
            this.grbChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Padding = new System.Windows.Forms.Padding(4);
            this.grbChucNang.Size = new System.Drawing.Size(701, 211);
            this.grbChucNang.TabIndex = 2;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // rdLKSoChan
            // 
            this.rdLKSoChan.AutoSize = true;
            this.rdLKSoChan.Location = new System.Drawing.Point(27, 103);
            this.rdLKSoChan.Margin = new System.Windows.Forms.Padding(4);
            this.rdLKSoChan.Name = "rdLKSoChan";
            this.rdLKSoChan.Size = new System.Drawing.Size(173, 29);
            this.rdLKSoChan.TabIndex = 7;
            this.rdLKSoChan.TabStop = true;
            this.rdLKSoChan.Text = "Liệt kê PT chẵn";
            this.rdLKSoChan.UseVisualStyleBackColor = true;
            this.rdLKSoChan.CheckedChanged += new System.EventHandler(this.rdLKSoChan_CheckedChanged);
            // 
            // rdTimSoChan
            // 
            this.rdTimSoChan.AutoSize = true;
            this.rdTimSoChan.Location = new System.Drawing.Point(27, 159);
            this.rdTimSoChan.Margin = new System.Windows.Forms.Padding(4);
            this.rdTimSoChan.Name = "rdTimSoChan";
            this.rdTimSoChan.Size = new System.Drawing.Size(233, 29);
            this.rdTimSoChan.TabIndex = 6;
            this.rdTimSoChan.TabStop = true;
            this.rdTimSoChan.Text = "Tìm số chẵn cuối cùng";
            this.rdTimSoChan.UseVisualStyleBackColor = true;
            this.rdTimSoChan.CheckedChanged += new System.EventHandler(this.rdTimSoChan_CheckedChanged);
            // 
            // rdDemSoLe
            // 
            this.rdDemSoLe.AutoSize = true;
            this.rdDemSoLe.Location = new System.Drawing.Point(407, 159);
            this.rdDemSoLe.Margin = new System.Windows.Forms.Padding(4);
            this.rdDemSoLe.Name = "rdDemSoLe";
            this.rdDemSoLe.Size = new System.Drawing.Size(124, 29);
            this.rdDemSoLe.TabIndex = 4;
            this.rdDemSoLe.TabStop = true;
            this.rdDemSoLe.Text = "Đếm số lẻ";
            this.rdDemSoLe.UseVisualStyleBackColor = true;
            this.rdDemSoLe.CheckedChanged += new System.EventHandler(this.rdDemSoLe_CheckedChanged);
            // 
            // rdTongChan
            // 
            this.rdTongChan.AutoSize = true;
            this.rdTongChan.Location = new System.Drawing.Point(407, 46);
            this.rdTongChan.Margin = new System.Windows.Forms.Padding(4);
            this.rdTongChan.Name = "rdTongChan";
            this.rdTongChan.Size = new System.Drawing.Size(198, 29);
            this.rdTongChan.TabIndex = 3;
            this.rdTongChan.TabStop = true;
            this.rdTongChan.Text = "Tổng các PT chẵn";
            this.rdTongChan.UseVisualStyleBackColor = true;
            this.rdTongChan.CheckedChanged += new System.EventHandler(this.rdTongChan_CheckedChanged);
            // 
            // rdDemSoChan
            // 
            this.rdDemSoChan.AutoSize = true;
            this.rdDemSoChan.Location = new System.Drawing.Point(407, 121);
            this.rdDemSoChan.Margin = new System.Windows.Forms.Padding(4);
            this.rdDemSoChan.Name = "rdDemSoChan";
            this.rdDemSoChan.Size = new System.Drawing.Size(152, 29);
            this.rdDemSoChan.TabIndex = 2;
            this.rdDemSoChan.TabStop = true;
            this.rdDemSoChan.Text = "Đếm số chẵn";
            this.rdDemSoChan.UseVisualStyleBackColor = true;
            this.rdDemSoChan.CheckedChanged += new System.EventHandler(this.rdDemSoChan_CheckedChanged);
            // 
            // rdTongLe
            // 
            this.rdTongLe.AutoSize = true;
            this.rdTongLe.Location = new System.Drawing.Point(407, 84);
            this.rdTongLe.Margin = new System.Windows.Forms.Padding(4);
            this.rdTongLe.Name = "rdTongLe";
            this.rdTongLe.Size = new System.Drawing.Size(170, 29);
            this.rdTongLe.TabIndex = 1;
            this.rdTongLe.TabStop = true;
            this.rdTongLe.Text = "Tổng các PT lẻ";
            this.rdTongLe.UseVisualStyleBackColor = true;
            this.rdTongLe.CheckedChanged += new System.EventHandler(this.rdTongLe_CheckedChanged);
            // 
            // rdTimMin
            // 
            this.rdTimMin.AutoSize = true;
            this.rdTimMin.Location = new System.Drawing.Point(27, 46);
            this.rdTimMin.Margin = new System.Windows.Forms.Padding(4);
            this.rdTimMin.Name = "rdTimMin";
            this.rdTimMin.Size = new System.Drawing.Size(202, 29);
            this.rdTimMin.TabIndex = 0;
            this.rdTimMin.TabStop = true;
            this.rdTimMin.Text = "Tìm giá trị nhỏ nhất";
            this.rdTimMin.UseVisualStyleBackColor = true;
            this.rdTimMin.CheckedChanged += new System.EventHandler(this.rdTimMin_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHuy);
            this.groupBox1.Controls.Add(this.rdTaoMangNN);
            this.groupBox1.Location = new System.Drawing.Point(405, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdHuy
            // 
            this.rdHuy.AutoSize = true;
            this.rdHuy.Location = new System.Drawing.Point(262, 20);
            this.rdHuy.Name = "rdHuy";
            this.rdHuy.Size = new System.Drawing.Size(72, 29);
            this.rdHuy.TabIndex = 2;
            this.rdHuy.TabStop = true;
            this.rdHuy.Text = "Hủy";
            this.rdHuy.UseVisualStyleBackColor = true;
            this.rdHuy.CheckedChanged += new System.EventHandler(this.rdHuy_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbKetQua);
            this.Controls.Add(this.grbMangGoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai5.6";
            this.grbMangGoc.ResumeLayout(false);
            this.grbMangGoc.PerformLayout();
            this.grbKetQua.ResumeLayout(false);
            this.grbKetQua.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            this.grbChucNang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMangGoc;
        private System.Windows.Forms.RadioButton rdTaoMangNN;
        private System.Windows.Forms.TextBox txtMangGoc;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.RadioButton rdLKSoChan;
        private System.Windows.Forms.RadioButton rdTimSoChan;
        private System.Windows.Forms.RadioButton rdDemSoLe;
        private System.Windows.Forms.RadioButton rdTongChan;
        private System.Windows.Forms.RadioButton rdDemSoChan;
        private System.Windows.Forms.RadioButton rdTongLe;
        private System.Windows.Forms.RadioButton rdTimMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHuy;
    }
}

