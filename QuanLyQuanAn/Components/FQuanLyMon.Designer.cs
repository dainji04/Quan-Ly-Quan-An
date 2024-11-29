namespace QuanLyQuanAn.Components
{
    partial class FQuanLyMon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFood = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenMon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.btnThemMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnDessert = new Guna.UI2.WinForms.Guna2Button();
            this.btnDrink = new Guna.UI2.WinForms.Guna2Button();
            this.btnSoup = new Guna.UI2.WinForms.Guna2Button();
            this.btnFood = new Guna.UI2.WinForms.Guna2Button();
            this.ptbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSuaMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.cbxLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFood
            // 
            this.dgvFood.AllowDrop = true;
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.AllowUserToResizeColumns = false;
            this.dgvFood.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvFood.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFood.ColumnHeadersHeight = 50;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFood,
            this.TenFood,
            this.Price,
            this.Type});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFood.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFood.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFood.Location = new System.Drawing.Point(29, 318);
            this.dgvFood.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.RowHeadersWidth = 45;
            this.dgvFood.Size = new System.Drawing.Size(1161, 450);
            this.dgvFood.TabIndex = 6;
            this.dgvFood.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFood.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvFood.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvFood.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvFood.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvFood.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvFood.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFood.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvFood.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFood.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFood.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFood.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvFood.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvFood.ThemeStyle.ReadOnly = true;
            this.dgvFood.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvFood.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFood.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFood.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFood.ThemeStyle.RowsStyle.Height = 22;
            this.dgvFood.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvFood.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvFood.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_RowEnter);
            // 
            // idFood
            // 
            this.idFood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idFood.DataPropertyName = "Ma";
            this.idFood.FillWeight = 25.90674F;
            this.idFood.HeaderText = "ID";
            this.idFood.MinimumWidth = 6;
            this.idFood.Name = "idFood";
            this.idFood.ReadOnly = true;
            this.idFood.Width = 50;
            // 
            // TenFood
            // 
            this.TenFood.DataPropertyName = "Tenmon";
            this.TenFood.FillWeight = 118.5233F;
            this.TenFood.HeaderText = "Tên Món";
            this.TenFood.MinimumWidth = 6;
            this.TenFood.Name = "TenFood";
            this.TenFood.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Giatien";
            this.Price.FillWeight = 118.5233F;
            this.Price.HeaderText = "Giá Tiền";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Loaimon";
            this.Type.FillWeight = 118.5233F;
            this.Type.HeaderText = "Loại";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 14.26415F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(738, 102);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(125, 49);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Chọn Ảnh";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.btnChonAnh);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(337, 108);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(85, 25);
            this.guna2HtmlLabel4.TabIndex = 14;
            this.guna2HtmlLabel4.Text = "Loại Món";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(34, 108);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(75, 25);
            this.guna2HtmlLabel3.TabIndex = 12;
            this.guna2HtmlLabel3.Text = "Giá Tiền";
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
            this.txtGia.Location = new System.Drawing.Point(125, 102);
            this.txtGia.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.PlaceholderText = "";
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(206, 36);
            this.txtGia.TabIndex = 13;
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
            this.txtTenMon.Location = new System.Drawing.Point(258, 30);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.PasswordChar = '\0';
            this.txtTenMon.PlaceholderText = "";
            this.txtTenMon.SelectedText = "";
            this.txtTenMon.Size = new System.Drawing.Size(398, 45);
            this.txtTenMon.TabIndex = 11;
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
            this.txtMa.Location = new System.Drawing.Point(59, 30);
            this.txtMa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMa.Name = "txtMa";
            this.txtMa.PasswordChar = '\0';
            this.txtMa.PlaceholderText = "";
            this.txtMa.SelectedText = "";
            this.txtMa.Size = new System.Drawing.Size(109, 45);
            this.txtMa.TabIndex = 9;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(174, 36);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(78, 25);
            this.guna2HtmlLabel2.TabIndex = 10;
            this.guna2HtmlLabel2.Text = "Tên Món";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(34, 36);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(19, 25);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Id";
            // 
            // btnThemMon
            // 
            this.btnThemMon.BorderRadius = 8;
            this.btnThemMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMon.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.Location = new System.Drawing.Point(965, 30);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(180, 45);
            this.btnThemMon.TabIndex = 18;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnAll
            // 
            this.btnAll.BorderRadius = 20;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(30, 250);
            this.btnAll.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(147, 45);
            this.btnAll.TabIndex = 19;
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnDessert
            // 
            this.btnDessert.BorderRadius = 20;
            this.btnDessert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDessert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDessert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDessert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDessert.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDessert.ForeColor = System.Drawing.Color.White;
            this.btnDessert.Location = new System.Drawing.Point(330, 250);
            this.btnDessert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(147, 45);
            this.btnDessert.TabIndex = 20;
            this.btnDessert.Text = "Dessert";
            this.btnDessert.Click += new System.EventHandler(this.btnDessert_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.BorderRadius = 20;
            this.btnDrink.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDrink.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDrink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDrink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDrink.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrink.ForeColor = System.Drawing.Color.White;
            this.btnDrink.Location = new System.Drawing.Point(630, 250);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(147, 45);
            this.btnDrink.TabIndex = 21;
            this.btnDrink.Text = "Drink";
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // btnSoup
            // 
            this.btnSoup.BorderRadius = 20;
            this.btnSoup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSoup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSoup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSoup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSoup.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoup.ForeColor = System.Drawing.Color.White;
            this.btnSoup.Location = new System.Drawing.Point(480, 250);
            this.btnSoup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(147, 45);
            this.btnSoup.TabIndex = 22;
            this.btnSoup.Text = "Soup";
            this.btnSoup.Click += new System.EventHandler(this.btnSoup_Click);
            // 
            // btnFood
            // 
            this.btnFood.BorderRadius = 20;
            this.btnFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFood.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.Location = new System.Drawing.Point(180, 250);
            this.btnFood.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(147, 45);
            this.btnFood.TabIndex = 23;
            this.btnFood.Text = "Food";
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // ptbImage
            // 
            this.ptbImage.ImageRotate = 0F;
            this.ptbImage.Location = new System.Drawing.Point(692, 30);
            this.ptbImage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(217, 206);
            this.ptbImage.TabIndex = 17;
            this.ptbImage.TabStop = false;
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
            this.btnSuaMon.Location = new System.Drawing.Point(965, 90);
            this.btnSuaMon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(180, 45);
            this.btnSuaMon.TabIndex = 56;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 8;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(965, 150);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 45);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 8;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(965, 210);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 45);
            this.btnReset.TabIndex = 70;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbxLoai
            // 
            this.cbxLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbxLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxLoai.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxLoai.ItemHeight = 30;
            this.cbxLoai.Items.AddRange(new object[] {
            "food",
            "dessert",
            "soup",
            "drink"});
            this.cbxLoai.Location = new System.Drawing.Point(428, 102);
            this.cbxLoai.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(228, 36);
            this.cbxLoai.TabIndex = 71;
            // 
            // FQuanLyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 799);
            this.Controls.Add(this.cbxLoai);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSuaMon);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnDessert);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnSoup);
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.ptbImage);
            this.Font = new System.Drawing.Font("Times New Roman", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FQuanLyMon";
            this.Text = "FQuanLyMon";
            this.Load += new System.EventHandler(this.FQuanLyMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvFood;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtGia;
        private Guna.UI2.WinForms.Guna2TextBox txtTenMon;
        private Guna.UI2.WinForms.Guna2TextBox txtMa;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private Guna.UI2.WinForms.Guna2Button btnThemMon;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private Guna.UI2.WinForms.Guna2Button btnDessert;
        private Guna.UI2.WinForms.Guna2Button btnDrink;
        private Guna.UI2.WinForms.Guna2Button btnSoup;
        private Guna.UI2.WinForms.Guna2Button btnFood;
        private Guna.UI2.WinForms.Guna2PictureBox ptbImage;
        private Guna.UI2.WinForms.Guna2Button btnSuaMon;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private Guna.UI2.WinForms.Guna2ComboBox cbxLoai;
    }
}