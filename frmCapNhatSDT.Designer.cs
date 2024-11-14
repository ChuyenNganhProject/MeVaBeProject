namespace MeVaBeProject
{
    partial class frmCapNhatSDT
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
            this.txtNewSDT = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtOldSdt = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnDong = new Sunny.UI.UIButton();
            this.btnCapNhat = new Sunny.UI.UIButton();
            this.errorSdt = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorSdt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewSDT
            // 
            this.txtNewSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNewSDT.Location = new System.Drawing.Point(431, 198);
            this.txtNewSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewSDT.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNewSDT.Name = "txtNewSDT";
            this.txtNewSDT.Padding = new System.Windows.Forms.Padding(5);
            this.txtNewSDT.RectColor = System.Drawing.Color.HotPink;
            this.txtNewSDT.ShowText = false;
            this.txtNewSDT.Size = new System.Drawing.Size(211, 37);
            this.txtNewSDT.TabIndex = 5;
            this.txtNewSDT.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNewSDT.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(124, 198);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(271, 37);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "Nhập số điện thoại mới: ";
            // 
            // txtOldSdt
            // 
            this.txtOldSdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldSdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldSdt.Enabled = false;
            this.txtOldSdt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOldSdt.Location = new System.Drawing.Point(431, 130);
            this.txtOldSdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldSdt.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtOldSdt.Name = "txtOldSdt";
            this.txtOldSdt.Padding = new System.Windows.Forms.Padding(5);
            this.txtOldSdt.RectColor = System.Drawing.Color.HotPink;
            this.txtOldSdt.ShowText = false;
            this.txtOldSdt.Size = new System.Drawing.Size(211, 37);
            this.txtOldSdt.TabIndex = 6;
            this.txtOldSdt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtOldSdt.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(124, 130);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(271, 37);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "Nhập số điện thoại cũ: ";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(12, 22);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(776, 64);
            this.uiLabel1.TabIndex = 7;
            this.uiLabel1.Text = "Cập nhật số điện thoại";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.FillColor = System.Drawing.Color.HotPink;
            this.btnDong.FillHoverColor = System.Drawing.Color.PaleVioletRed;
            this.btnDong.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnDong.FillSelectedColor = System.Drawing.Color.DeepPink;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDong.Location = new System.Drawing.Point(493, 291);
            this.btnDong.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDong.Name = "btnDong";
            this.btnDong.RectColor = System.Drawing.Color.HotPink;
            this.btnDong.RectHoverColor = System.Drawing.Color.PaleVioletRed;
            this.btnDong.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnDong.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnDong.Size = new System.Drawing.Size(128, 58);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.TipsFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FillColor = System.Drawing.Color.HotPink;
            this.btnCapNhat.FillHoverColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnCapNhat.FillSelectedColor = System.Drawing.Color.DeepPink;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Location = new System.Drawing.Point(188, 291);
            this.btnCapNhat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.RectColor = System.Drawing.Color.HotPink;
            this.btnCapNhat.RectHoverColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnCapNhat.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnCapNhat.Size = new System.Drawing.Size(128, 58);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TipsFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // errorSdt
            // 
            this.errorSdt.ContainerControl = this;
            // 
            // frmCapNhatSDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.txtNewSDT);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txtOldSdt);
            this.Controls.Add(this.uiLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCapNhatSDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCapNhatSDT";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmCapNhatSDT_Paint_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorSdt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox txtNewSDT;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtOldSdt;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnDong;
        private Sunny.UI.UIButton btnCapNhat;
        private System.Windows.Forms.ErrorProvider errorSdt;
    }
}