namespace QuanLyQuanAn.Components
{
    partial class FSuaMon
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
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ptbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAnh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenMon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.btnSuaMon = new Guna.UI2.WinForms.Guna2Button();
            this.msgSua = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 5;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(404, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 48);
            this.btnTimKiem.TabIndex = 44;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(19, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Nhập mã quán bạn muốn sửa";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(378, 48);
            this.txtSearch.TabIndex = 43;
            // 
            // ptbImage
            // 
            this.ptbImage.BorderRadius = 5;
            this.ptbImage.ImageRotate = 0F;
            this.ptbImage.Location = new System.Drawing.Point(214, 177);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(314, 302);
            this.ptbImage.TabIndex = 54;
            this.ptbImage.TabStop = false;
            // 
            // btnAnh
            // 
            this.btnAnh.BorderRadius = 8;
            this.btnAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAnh.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnh.ForeColor = System.Drawing.Color.White;
            this.btnAnh.Location = new System.Drawing.Point(6, 292);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(180, 45);
            this.btnAnh.TabIndex = 53;
            this.btnAnh.Text = "Chọn Ảnh";
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(270, 132);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(85, 25);
            this.guna2HtmlLabel4.TabIndex = 52;
            this.guna2HtmlLabel4.Text = "Loại Món";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(18, 132);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(75, 25);
            this.guna2HtmlLabel3.TabIndex = 51;
            this.guna2HtmlLabel3.Text = "Giá Tiền";
            // 
            // txtLoai
            // 
            this.txtLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoai.DefaultText = "";
            this.txtLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoai.Location = new System.Drawing.Point(361, 126);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.PasswordChar = '\0';
            this.txtLoai.PlaceholderText = "";
            this.txtLoai.SelectedText = "";
            this.txtLoai.Size = new System.Drawing.Size(143, 31);
            this.txtLoai.TabIndex = 47;
            // 
            // txtGia
            // 
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.DefaultText = "";
            this.txtGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGia.Location = new System.Drawing.Point(109, 126);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.PlaceholderText = "";
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(143, 31);
            this.txtGia.TabIndex = 48;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMon.DefaultText = "";
            this.txtTenMon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenMon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenMon.Location = new System.Drawing.Point(242, 89);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.PasswordChar = '\0';
            this.txtTenMon.PlaceholderText = "";
            this.txtTenMon.SelectedText = "";
            this.txtTenMon.Size = new System.Drawing.Size(275, 31);
            this.txtTenMon.TabIndex = 49;
            // 
            // txtMa
            // 
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.DefaultText = "";
            this.txtMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.Location = new System.Drawing.Point(43, 89);
            this.txtMa.Name = "txtMa";
            this.txtMa.PasswordChar = '\0';
            this.txtMa.PlaceholderText = "";
            this.txtMa.SelectedText = "";
            this.txtMa.Size = new System.Drawing.Size(109, 31);
            this.txtMa.TabIndex = 50;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(158, 95);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(78, 25);
            this.guna2HtmlLabel2.TabIndex = 46;
            this.guna2HtmlLabel2.Text = "Tên Món";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(18, 95);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(19, 25);
            this.guna2HtmlLabel1.TabIndex = 45;
            this.guna2HtmlLabel1.Text = "Id";
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.BorderRadius = 8;
            this.btnSuaMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaMon.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMon.ForeColor = System.Drawing.Color.White;
            this.btnSuaMon.Location = new System.Drawing.Point(158, 529);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(180, 45);
            this.btnSuaMon.TabIndex = 55;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // msgSua
            // 
            this.msgSua.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
            this.msgSua.Caption = "Are u sure ?";
            this.msgSua.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.msgSua.Parent = this;
            this.msgSua.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgSua.Text = "Bạn chắc chắn muốn sửa ?";
            // 
            // FSuaMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 610);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.btnAnh);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtLoai);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnSuaMon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Name = "FSuaMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sua Mon ";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2PictureBox ptbImage;
        private Guna.UI2.WinForms.Guna2Button btnAnh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtGia;
        private Guna.UI2.WinForms.Guna2TextBox txtTenMon;
        private Guna.UI2.WinForms.Guna2TextBox txtMa;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private Guna.UI2.WinForms.Guna2Button btnSuaMon;
        private Guna.UI2.WinForms.Guna2MessageDialog msgSua;
    }
}