namespace Bai4
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
            this.lblTimCVDT = new System.Windows.Forms.Label();
            this.lblShape = new System.Windows.Forms.Label();
            this.grbOption = new System.Windows.Forms.GroupBox();
            this.rdHinhCN = new System.Windows.Forms.RadioButton();
            this.rdHinhTG = new System.Windows.Forms.RadioButton();
            this.rdHinhVuong = new System.Windows.Forms.RadioButton();
            this.rdHinhTron = new System.Windows.Forms.RadioButton();
            this.grbHinhVuong = new System.Windows.Forms.GroupBox();
            this.txtDTHV = new System.Windows.Forms.TextBox();
            this.txtCVHV = new System.Windows.Forms.TextBox();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.lblDTHV = new System.Windows.Forms.Label();
            this.lblCVHV = new System.Windows.Forms.Label();
            this.lblCanh = new System.Windows.Forms.Label();
            this.grbHinhTron = new System.Windows.Forms.GroupBox();
            this.txtDTHT = new System.Windows.Forms.TextBox();
            this.txtCVHT = new System.Windows.Forms.TextBox();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.lblDTHT = new System.Windows.Forms.Label();
            this.lblCVHT = new System.Windows.Forms.Label();
            this.lblBanKinh = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbHCN = new System.Windows.Forms.GroupBox();
            this.txtCVHCN = new System.Windows.Forms.TextBox();
            this.lblChieuRong = new System.Windows.Forms.Label();
            this.txtDTHCN = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.lblDTHCN = new System.Windows.Forms.Label();
            this.lblCVHCN = new System.Windows.Forms.Label();
            this.lblChieuDai = new System.Windows.Forms.Label();
            this.grbHTG = new System.Windows.Forms.GroupBox();
            this.txtCanhB = new System.Windows.Forms.TextBox();
            this.lblCanhB = new System.Windows.Forms.Label();
            this.txtCanhC = new System.Windows.Forms.TextBox();
            this.lblCanhC = new System.Windows.Forms.Label();
            this.txtDTHTG = new System.Windows.Forms.TextBox();
            this.txtCVHTG = new System.Windows.Forms.TextBox();
            this.txtCanhA = new System.Windows.Forms.TextBox();
            this.lblDTHTG = new System.Windows.Forms.Label();
            this.lblCVHTG = new System.Windows.Forms.Label();
            this.lblCanhA = new System.Windows.Forms.Label();
            this.grbOption.SuspendLayout();
            this.grbHinhVuong.SuspendLayout();
            this.grbHinhTron.SuspendLayout();
            this.grbHCN.SuspendLayout();
            this.grbHTG.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimCVDT
            // 
            this.lblTimCVDT.AutoSize = true;
            this.lblTimCVDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimCVDT.ForeColor = System.Drawing.Color.Red;
            this.lblTimCVDT.Location = new System.Drawing.Point(124, 9);
            this.lblTimCVDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimCVDT.Name = "lblTimCVDT";
            this.lblTimCVDT.Size = new System.Drawing.Size(396, 46);
            this.lblTimCVDT.TabIndex = 0;
            this.lblTimCVDT.Text = "Tìm Chu vi Diện tích";
            // 
            // lblShape
            // 
            this.lblShape.ForeColor = System.Drawing.Color.Blue;
            this.lblShape.Location = new System.Drawing.Point(131, 55);
            this.lblShape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(347, 58);
            this.lblShape.TabIndex = 1;
            this.lblShape.Text = "Hình tròn - Hình vuông\r\nHình tam giác - Hình chữ nhật";
            this.lblShape.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grbOption
            // 
            this.grbOption.Controls.Add(this.rdHinhCN);
            this.grbOption.Controls.Add(this.rdHinhTG);
            this.grbOption.Controls.Add(this.rdHinhVuong);
            this.grbOption.Controls.Add(this.rdHinhTron);
            this.grbOption.Location = new System.Drawing.Point(112, 115);
            this.grbOption.Margin = new System.Windows.Forms.Padding(4);
            this.grbOption.Name = "grbOption";
            this.grbOption.Padding = new System.Windows.Forms.Padding(4);
            this.grbOption.Size = new System.Drawing.Size(366, 111);
            this.grbOption.TabIndex = 2;
            this.grbOption.TabStop = false;
            this.grbOption.Text = "Chọn";
            // 
            // rdHinhCN
            // 
            this.rdHinhCN.AutoSize = true;
            this.rdHinhCN.Location = new System.Drawing.Point(202, 68);
            this.rdHinhCN.Margin = new System.Windows.Forms.Padding(4);
            this.rdHinhCN.Name = "rdHinhCN";
            this.rdHinhCN.Size = new System.Drawing.Size(157, 29);
            this.rdHinhCN.TabIndex = 3;
            this.rdHinhCN.TabStop = true;
            this.rdHinhCN.Text = "Hình chữ nhật";
            this.rdHinhCN.UseVisualStyleBackColor = true;
            this.rdHinhCN.CheckedChanged += new System.EventHandler(this.rdHinhCN_CheckedChanged);
            // 
            // rdHinhTG
            // 
            this.rdHinhTG.AutoSize = true;
            this.rdHinhTG.Location = new System.Drawing.Point(202, 31);
            this.rdHinhTG.Margin = new System.Windows.Forms.Padding(4);
            this.rdHinhTG.Name = "rdHinhTG";
            this.rdHinhTG.Size = new System.Drawing.Size(155, 29);
            this.rdHinhTG.TabIndex = 2;
            this.rdHinhTG.TabStop = true;
            this.rdHinhTG.Text = "Hình tam giác";
            this.rdHinhTG.UseVisualStyleBackColor = true;
            this.rdHinhTG.Click += new System.EventHandler(this.rdHinhTG_Click);
            // 
            // rdHinhVuong
            // 
            this.rdHinhVuong.AutoSize = true;
            this.rdHinhVuong.Location = new System.Drawing.Point(9, 68);
            this.rdHinhVuong.Margin = new System.Windows.Forms.Padding(4);
            this.rdHinhVuong.Name = "rdHinhVuong";
            this.rdHinhVuong.Size = new System.Drawing.Size(136, 29);
            this.rdHinhVuong.TabIndex = 1;
            this.rdHinhVuong.TabStop = true;
            this.rdHinhVuong.Text = "Hình vuông";
            this.rdHinhVuong.UseVisualStyleBackColor = true;
            this.rdHinhVuong.CheckedChanged += new System.EventHandler(this.rdHinhVuong_CheckedChanged);
            // 
            // rdHinhTron
            // 
            this.rdHinhTron.AutoSize = true;
            this.rdHinhTron.Location = new System.Drawing.Point(9, 31);
            this.rdHinhTron.Margin = new System.Windows.Forms.Padding(4);
            this.rdHinhTron.Name = "rdHinhTron";
            this.rdHinhTron.Size = new System.Drawing.Size(115, 29);
            this.rdHinhTron.TabIndex = 0;
            this.rdHinhTron.TabStop = true;
            this.rdHinhTron.Text = "Hình tròn";
            this.rdHinhTron.UseVisualStyleBackColor = true;
            this.rdHinhTron.CheckedChanged += new System.EventHandler(this.rdHinhTron_CheckedChanged);
            // 
            // grbHinhVuong
            // 
            this.grbHinhVuong.Controls.Add(this.txtDTHV);
            this.grbHinhVuong.Controls.Add(this.txtCVHV);
            this.grbHinhVuong.Controls.Add(this.txtCanh);
            this.grbHinhVuong.Controls.Add(this.lblDTHV);
            this.grbHinhVuong.Controls.Add(this.lblCVHV);
            this.grbHinhVuong.Controls.Add(this.lblCanh);
            this.grbHinhVuong.Location = new System.Drawing.Point(72, 354);
            this.grbHinhVuong.Margin = new System.Windows.Forms.Padding(4);
            this.grbHinhVuong.Name = "grbHinhVuong";
            this.grbHinhVuong.Padding = new System.Windows.Forms.Padding(4);
            this.grbHinhVuong.Size = new System.Drawing.Size(447, 153);
            this.grbHinhVuong.TabIndex = 3;
            this.grbHinhVuong.TabStop = false;
            this.grbHinhVuong.Text = "Hình vuông";
            // 
            // txtDTHV
            // 
            this.txtDTHV.Location = new System.Drawing.Point(151, 108);
            this.txtDTHV.Margin = new System.Windows.Forms.Padding(4);
            this.txtDTHV.Name = "txtDTHV";
            this.txtDTHV.Size = new System.Drawing.Size(132, 30);
            this.txtDTHV.TabIndex = 5;
            // 
            // txtCVHV
            // 
            this.txtCVHV.Location = new System.Drawing.Point(151, 70);
            this.txtCVHV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVHV.Name = "txtCVHV";
            this.txtCVHV.Size = new System.Drawing.Size(132, 30);
            this.txtCVHV.TabIndex = 4;
            // 
            // txtCanh
            // 
            this.txtCanh.Location = new System.Drawing.Point(151, 32);
            this.txtCanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(132, 30);
            this.txtCanh.TabIndex = 3;
            // 
            // lblDTHV
            // 
            this.lblDTHV.AutoSize = true;
            this.lblDTHV.Location = new System.Drawing.Point(15, 110);
            this.lblDTHV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDTHV.Name = "lblDTHV";
            this.lblDTHV.Size = new System.Drawing.Size(93, 25);
            this.lblDTHV.TabIndex = 2;
            this.lblDTHV.Text = "Diện tích:";
            // 
            // lblCVHV
            // 
            this.lblCVHV.AutoSize = true;
            this.lblCVHV.Location = new System.Drawing.Point(15, 73);
            this.lblCVHV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVHV.Name = "lblCVHV";
            this.lblCVHV.Size = new System.Drawing.Size(79, 25);
            this.lblCVHV.TabIndex = 1;
            this.lblCVHV.Text = "Chu vi: ";
            // 
            // lblCanh
            // 
            this.lblCanh.AutoSize = true;
            this.lblCanh.Location = new System.Drawing.Point(15, 37);
            this.lblCanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanh.Name = "lblCanh";
            this.lblCanh.Size = new System.Drawing.Size(134, 25);
            this.lblCanh.TabIndex = 0;
            this.lblCanh.Text = "Nhập Cạnh a:";
            // 
            // grbHinhTron
            // 
            this.grbHinhTron.Controls.Add(this.txtDTHT);
            this.grbHinhTron.Controls.Add(this.txtCVHT);
            this.grbHinhTron.Controls.Add(this.txtBanKinh);
            this.grbHinhTron.Controls.Add(this.lblDTHT);
            this.grbHinhTron.Controls.Add(this.lblCVHT);
            this.grbHinhTron.Controls.Add(this.lblBanKinh);
            this.grbHinhTron.Location = new System.Drawing.Point(72, 354);
            this.grbHinhTron.Margin = new System.Windows.Forms.Padding(4);
            this.grbHinhTron.Name = "grbHinhTron";
            this.grbHinhTron.Padding = new System.Windows.Forms.Padding(4);
            this.grbHinhTron.Size = new System.Drawing.Size(447, 150);
            this.grbHinhTron.TabIndex = 8;
            this.grbHinhTron.TabStop = false;
            this.grbHinhTron.Text = "Hình tròn";
            // 
            // txtDTHT
            // 
            this.txtDTHT.Location = new System.Drawing.Point(167, 108);
            this.txtDTHT.Margin = new System.Windows.Forms.Padding(4);
            this.txtDTHT.Name = "txtDTHT";
            this.txtDTHT.Size = new System.Drawing.Size(132, 30);
            this.txtDTHT.TabIndex = 5;
            // 
            // txtCVHT
            // 
            this.txtCVHT.Location = new System.Drawing.Point(167, 70);
            this.txtCVHT.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVHT.Name = "txtCVHT";
            this.txtCVHT.Size = new System.Drawing.Size(132, 30);
            this.txtCVHT.TabIndex = 4;
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(167, 34);
            this.txtBanKinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(132, 30);
            this.txtBanKinh.TabIndex = 3;
            // 
            // lblDTHT
            // 
            this.lblDTHT.AutoSize = true;
            this.lblDTHT.Location = new System.Drawing.Point(15, 110);
            this.lblDTHT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDTHT.Name = "lblDTHT";
            this.lblDTHT.Size = new System.Drawing.Size(93, 25);
            this.lblDTHT.TabIndex = 2;
            this.lblDTHT.Text = "Diện tích:";
            // 
            // lblCVHT
            // 
            this.lblCVHT.AutoSize = true;
            this.lblCVHT.Location = new System.Drawing.Point(15, 73);
            this.lblCVHT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVHT.Name = "lblCVHT";
            this.lblCVHT.Size = new System.Drawing.Size(79, 25);
            this.lblCVHT.TabIndex = 1;
            this.lblCVHT.Text = "Chu vi: ";
            // 
            // lblBanKinh
            // 
            this.lblBanKinh.AutoSize = true;
            this.lblBanKinh.Location = new System.Drawing.Point(15, 37);
            this.lblBanKinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanKinh.Name = "lblBanKinh";
            this.lblBanKinh.Size = new System.Drawing.Size(144, 25);
            this.lblBanKinh.TabIndex = 0;
            this.lblBanKinh.Text = "Nhập bán kính:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(236, 250);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(77, 250);
            this.btnThucHien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(129, 45);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(395, 250);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 45);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbHCN
            // 
            this.grbHCN.Controls.Add(this.txtCVHCN);
            this.grbHCN.Controls.Add(this.lblChieuRong);
            this.grbHCN.Controls.Add(this.txtDTHCN);
            this.grbHCN.Controls.Add(this.txtChieuRong);
            this.grbHCN.Controls.Add(this.txtChieuDai);
            this.grbHCN.Controls.Add(this.lblDTHCN);
            this.grbHCN.Controls.Add(this.lblCVHCN);
            this.grbHCN.Controls.Add(this.lblChieuDai);
            this.grbHCN.Location = new System.Drawing.Point(72, 354);
            this.grbHCN.Margin = new System.Windows.Forms.Padding(4);
            this.grbHCN.Name = "grbHCN";
            this.grbHCN.Padding = new System.Windows.Forms.Padding(4);
            this.grbHCN.Size = new System.Drawing.Size(447, 210);
            this.grbHCN.TabIndex = 7;
            this.grbHCN.TabStop = false;
            this.grbHCN.Text = "Hình chữ nhật";
            // 
            // txtCVHCN
            // 
            this.txtCVHCN.Location = new System.Drawing.Point(189, 117);
            this.txtCVHCN.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVHCN.Name = "txtCVHCN";
            this.txtCVHCN.Size = new System.Drawing.Size(132, 30);
            this.txtCVHCN.TabIndex = 7;
            // 
            // lblChieuRong
            // 
            this.lblChieuRong.AutoSize = true;
            this.lblChieuRong.Location = new System.Drawing.Point(15, 79);
            this.lblChieuRong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChieuRong.Name = "lblChieuRong";
            this.lblChieuRong.Size = new System.Drawing.Size(166, 25);
            this.lblChieuRong.TabIndex = 6;
            this.lblChieuRong.Text = "Nhập Chiều rộng:";
            // 
            // txtDTHCN
            // 
            this.txtDTHCN.Location = new System.Drawing.Point(189, 161);
            this.txtDTHCN.Margin = new System.Windows.Forms.Padding(4);
            this.txtDTHCN.Name = "txtDTHCN";
            this.txtDTHCN.Size = new System.Drawing.Size(132, 30);
            this.txtDTHCN.TabIndex = 5;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(189, 76);
            this.txtChieuRong.Margin = new System.Windows.Forms.Padding(4);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(132, 30);
            this.txtChieuRong.TabIndex = 4;
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(189, 34);
            this.txtChieuDai.Margin = new System.Windows.Forms.Padding(4);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(132, 30);
            this.txtChieuDai.TabIndex = 3;
            // 
            // lblDTHCN
            // 
            this.lblDTHCN.AutoSize = true;
            this.lblDTHCN.Location = new System.Drawing.Point(15, 164);
            this.lblDTHCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDTHCN.Name = "lblDTHCN";
            this.lblDTHCN.Size = new System.Drawing.Size(93, 25);
            this.lblDTHCN.TabIndex = 2;
            this.lblDTHCN.Text = "Diện tích:";
            // 
            // lblCVHCN
            // 
            this.lblCVHCN.AutoSize = true;
            this.lblCVHCN.Location = new System.Drawing.Point(15, 120);
            this.lblCVHCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVHCN.Name = "lblCVHCN";
            this.lblCVHCN.Size = new System.Drawing.Size(79, 25);
            this.lblCVHCN.TabIndex = 1;
            this.lblCVHCN.Text = "Chu vi: ";
            // 
            // lblChieuDai
            // 
            this.lblChieuDai.AutoSize = true;
            this.lblChieuDai.Location = new System.Drawing.Point(15, 37);
            this.lblChieuDai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChieuDai.Name = "lblChieuDai";
            this.lblChieuDai.Size = new System.Drawing.Size(153, 25);
            this.lblChieuDai.TabIndex = 0;
            this.lblChieuDai.Text = "Nhập Chiều dài:";
            // 
            // grbHTG
            // 
            this.grbHTG.Controls.Add(this.txtCanhB);
            this.grbHTG.Controls.Add(this.lblCanhB);
            this.grbHTG.Controls.Add(this.txtCanhC);
            this.grbHTG.Controls.Add(this.lblCanhC);
            this.grbHTG.Controls.Add(this.txtDTHTG);
            this.grbHTG.Controls.Add(this.txtCVHTG);
            this.grbHTG.Controls.Add(this.txtCanhA);
            this.grbHTG.Controls.Add(this.lblDTHTG);
            this.grbHTG.Controls.Add(this.lblCVHTG);
            this.grbHTG.Controls.Add(this.lblCanhA);
            this.grbHTG.Location = new System.Drawing.Point(72, 354);
            this.grbHTG.Margin = new System.Windows.Forms.Padding(4);
            this.grbHTG.Name = "grbHTG";
            this.grbHTG.Padding = new System.Windows.Forms.Padding(4);
            this.grbHTG.Size = new System.Drawing.Size(447, 230);
            this.grbHTG.TabIndex = 6;
            this.grbHTG.TabStop = false;
            this.grbHTG.Text = "Hình tam giác";
            // 
            // txtCanhB
            // 
            this.txtCanhB.Location = new System.Drawing.Point(151, 75);
            this.txtCanhB.Margin = new System.Windows.Forms.Padding(4);
            this.txtCanhB.Name = "txtCanhB";
            this.txtCanhB.Size = new System.Drawing.Size(132, 30);
            this.txtCanhB.TabIndex = 9;
            // 
            // lblCanhB
            // 
            this.lblCanhB.AutoSize = true;
            this.lblCanhB.Location = new System.Drawing.Point(15, 80);
            this.lblCanhB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanhB.Name = "lblCanhB";
            this.lblCanhB.Size = new System.Drawing.Size(134, 25);
            this.lblCanhB.TabIndex = 8;
            this.lblCanhB.Text = "Nhập Cạnh b:";
            // 
            // txtCanhC
            // 
            this.txtCanhC.Location = new System.Drawing.Point(151, 115);
            this.txtCanhC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCanhC.Name = "txtCanhC";
            this.txtCanhC.Size = new System.Drawing.Size(132, 30);
            this.txtCanhC.TabIndex = 7;
            // 
            // lblCanhC
            // 
            this.lblCanhC.AutoSize = true;
            this.lblCanhC.Location = new System.Drawing.Point(15, 120);
            this.lblCanhC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanhC.Name = "lblCanhC";
            this.lblCanhC.Size = new System.Drawing.Size(133, 25);
            this.lblCanhC.TabIndex = 6;
            this.lblCanhC.Text = "Nhập Cạnh c:";
            // 
            // txtDTHTG
            // 
            this.txtDTHTG.Location = new System.Drawing.Point(151, 191);
            this.txtDTHTG.Margin = new System.Windows.Forms.Padding(4);
            this.txtDTHTG.Name = "txtDTHTG";
            this.txtDTHTG.Size = new System.Drawing.Size(132, 30);
            this.txtDTHTG.TabIndex = 5;
            // 
            // txtCVHTG
            // 
            this.txtCVHTG.Location = new System.Drawing.Point(151, 153);
            this.txtCVHTG.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVHTG.Name = "txtCVHTG";
            this.txtCVHTG.Size = new System.Drawing.Size(132, 30);
            this.txtCVHTG.TabIndex = 4;
            // 
            // txtCanhA
            // 
            this.txtCanhA.Location = new System.Drawing.Point(151, 32);
            this.txtCanhA.Margin = new System.Windows.Forms.Padding(4);
            this.txtCanhA.Name = "txtCanhA";
            this.txtCanhA.Size = new System.Drawing.Size(132, 30);
            this.txtCanhA.TabIndex = 3;
            // 
            // lblDTHTG
            // 
            this.lblDTHTG.AutoSize = true;
            this.lblDTHTG.Location = new System.Drawing.Point(15, 193);
            this.lblDTHTG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDTHTG.Name = "lblDTHTG";
            this.lblDTHTG.Size = new System.Drawing.Size(93, 25);
            this.lblDTHTG.TabIndex = 2;
            this.lblDTHTG.Text = "Diện tích:";
            // 
            // lblCVHTG
            // 
            this.lblCVHTG.AutoSize = true;
            this.lblCVHTG.Location = new System.Drawing.Point(15, 156);
            this.lblCVHTG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVHTG.Name = "lblCVHTG";
            this.lblCVHTG.Size = new System.Drawing.Size(79, 25);
            this.lblCVHTG.TabIndex = 1;
            this.lblCVHTG.Text = "Chu vi: ";
            // 
            // lblCanhA
            // 
            this.lblCanhA.AutoSize = true;
            this.lblCanhA.Location = new System.Drawing.Point(15, 37);
            this.lblCanhA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanhA.Name = "lblCanhA";
            this.lblCanhA.Size = new System.Drawing.Size(134, 25);
            this.lblCanhA.TabIndex = 0;
            this.lblCanhA.Text = "Nhập Cạnh a:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 620);
            this.Controls.Add(this.grbHinhTron);
            this.Controls.Add(this.grbHCN);
            this.Controls.Add(this.grbHTG);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grbHinhVuong);
            this.Controls.Add(this.grbOption);
            this.Controls.Add(this.lblShape);
            this.Controls.Add(this.lblTimCVDT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm chu vi diện tích";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbOption.ResumeLayout(false);
            this.grbOption.PerformLayout();
            this.grbHinhVuong.ResumeLayout(false);
            this.grbHinhVuong.PerformLayout();
            this.grbHinhTron.ResumeLayout(false);
            this.grbHinhTron.PerformLayout();
            this.grbHCN.ResumeLayout(false);
            this.grbHCN.PerformLayout();
            this.grbHTG.ResumeLayout(false);
            this.grbHTG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimCVDT;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.GroupBox grbOption;
        private System.Windows.Forms.RadioButton rdHinhCN;
        private System.Windows.Forms.RadioButton rdHinhTG;
        private System.Windows.Forms.RadioButton rdHinhVuong;
        private System.Windows.Forms.RadioButton rdHinhTron;
        private System.Windows.Forms.GroupBox grbHinhVuong;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtDTHV;
        private System.Windows.Forms.TextBox txtCVHV;
        private System.Windows.Forms.TextBox txtCanh;
        private System.Windows.Forms.Label lblDTHV;
        private System.Windows.Forms.Label lblCVHV;
        private System.Windows.Forms.Label lblCanh;
        private System.Windows.Forms.GroupBox grbHCN;
        private System.Windows.Forms.TextBox txtDTHCN;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.Label lblDTHCN;
        private System.Windows.Forms.Label lblCVHCN;
        private System.Windows.Forms.Label lblChieuDai;
        private System.Windows.Forms.GroupBox grbHTG;
        private System.Windows.Forms.TextBox txtDTHTG;
        private System.Windows.Forms.TextBox txtCVHTG;
        private System.Windows.Forms.TextBox txtCanhA;
        private System.Windows.Forms.Label lblDTHTG;
        private System.Windows.Forms.Label lblCVHTG;
        private System.Windows.Forms.Label lblCanhA;
        private System.Windows.Forms.GroupBox grbHinhTron;
        private System.Windows.Forms.TextBox txtDTHT;
        private System.Windows.Forms.TextBox txtCVHT;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Label lblDTHT;
        private System.Windows.Forms.Label lblCVHT;
        private System.Windows.Forms.Label lblBanKinh;
        private System.Windows.Forms.TextBox txtCVHCN;
        private System.Windows.Forms.Label lblChieuRong;
        private System.Windows.Forms.TextBox txtCanhB;
        private System.Windows.Forms.Label lblCanhB;
        private System.Windows.Forms.TextBox txtCanhC;
        private System.Windows.Forms.Label lblCanhC;
    }
}

