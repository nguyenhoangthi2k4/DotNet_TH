namespace Bai1
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblKiemTra = new System.Windows.Forms.Label();
            this.lblLstSNT = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtKiemTra = new System.Windows.Forms.TextBox();
            this.txtLstSNT = new System.Windows.Forms.TextBox();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider_checkInput = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_checkInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(145, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Kiểm tra và  Tìm SNT";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(48, 72);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(177, 25);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Nhập số nguyên n:";
            // 
            // lblKiemTra
            // 
            this.lblKiemTra.AutoSize = true;
            this.lblKiemTra.Location = new System.Drawing.Point(89, 122);
            this.lblKiemTra.Name = "lblKiemTra";
            this.lblKiemTra.Size = new System.Drawing.Size(136, 25);
            this.lblKiemTra.TabIndex = 2;
            this.lblKiemTra.Text = "Kiểm tra SNT:";
            // 
            // lblLstSNT
            // 
            this.lblLstSNT.AutoSize = true;
            this.lblLstSNT.Location = new System.Drawing.Point(34, 174);
            this.lblLstSNT.Name = "lblLstSNT";
            this.lblLstSNT.Size = new System.Drawing.Size(191, 25);
            this.lblLstSNT.TabIndex = 3;
            this.lblLstSNT.Text = "Dãy SNT nhỏ hơn n:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(231, 69);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(294, 30);
            this.txtInput.TabIndex = 4;
            // 
            // txtKiemTra
            // 
            this.txtKiemTra.Location = new System.Drawing.Point(231, 119);
            this.txtKiemTra.Name = "txtKiemTra";
            this.txtKiemTra.Size = new System.Drawing.Size(294, 30);
            this.txtKiemTra.TabIndex = 5;
            // 
            // txtLstSNT
            // 
            this.txtLstSNT.Location = new System.Drawing.Point(231, 171);
            this.txtLstSNT.Name = "txtLstSNT";
            this.txtLstSNT.Size = new System.Drawing.Size(294, 30);
            this.txtLstSNT.TabIndex = 6;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(152, 243);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(143, 40);
            this.btnLamLai.TabIndex = 7;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(382, 243);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 40);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider_checkInput
            // 
            this.errorProvider_checkInput.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 305);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.txtLstSNT);
            this.Controls.Add(this.txtKiemTra);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblLstSNT);
            this.Controls.Add(this.lblKiemTra);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_checkInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblKiemTra;
        private System.Windows.Forms.Label lblLstSNT;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtKiemTra;
        private System.Windows.Forms.TextBox txtLstSNT;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider_checkInput;
    }
}

