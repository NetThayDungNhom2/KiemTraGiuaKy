namespace AppG2.View
{
    partial class frmThongTinSinhVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.chkGioiTinh = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgQuaTrinhHocTap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.lnkChonAnhDaiDien = new System.Windows.Forms.LinkLabel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.menuAvatar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniXoaAnhDaiDien = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.bdsQuaTrinhHocTap = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuaTrinhHocTap)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
            this.menuAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuaTrinhHocTap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên:";
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Location = new System.Drawing.Point(145, 71);
            this.chkGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(59, 21);
            this.chkGioiTinh.TabIndex = 3;
            this.chkGioiTinh.Text = "Nam";
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quê quán:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(145, 133);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(380, 64);
            this.txtQueQuan.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(145, 101);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(156, 22);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(145, 7);
            this.txtMaSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(380, 22);
            this.txtMaSinhVien.TabIndex = 6;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(145, 39);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(247, 22);
            this.txtHo.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtgQuaTrinhHocTap);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(20, 206);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 249);
            this.panel1.TabIndex = 7;
            // 
            // dtgQuaTrinhHocTap
            // 
            this.dtgQuaTrinhHocTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQuaTrinhHocTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgQuaTrinhHocTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgQuaTrinhHocTap.Location = new System.Drawing.Point(0, 27);
            this.dtgQuaTrinhHocTap.Margin = new System.Windows.Forms.Padding(4);
            this.dtgQuaTrinhHocTap.MultiSelect = false;
            this.dtgQuaTrinhHocTap.Name = "dtgQuaTrinhHocTap";
            this.dtgQuaTrinhHocTap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgQuaTrinhHocTap.Size = new System.Drawing.Size(699, 195);
            this.dtgQuaTrinhHocTap.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDHistoryLearning";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "YearTo";
            this.Column2.HeaderText = "Từ năm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "YearEnd";
            this.Column3.HeaderText = "Đến năm";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Address";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 222);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(699, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 20);
            this.toolStripStatusLabel1.Text = "Tổng số mục: 0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoa,
            this.btnSua,
            this.btnThem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(699, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(124, 24);
            this.toolStripLabel1.Text = "Quá trình học tập";
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = global::AppG2.Properties.Resources.delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Image = global::AppG2.Properties.Resources.edit;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 24);
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThem.Image = global::AppG2.Properties.Resources.add;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 24);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lnkChonAnhDaiDien
            // 
            this.lnkChonAnhDaiDien.AutoSize = true;
            this.lnkChonAnhDaiDien.Location = new System.Drawing.Point(571, 172);
            this.lnkChonAnhDaiDien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkChonAnhDaiDien.Name = "lnkChonAnhDaiDien";
            this.lnkChonAnhDaiDien.Size = new System.Drawing.Size(123, 17);
            this.lnkChonAnhDaiDien.TabIndex = 8;
            this.lnkChonAnhDaiDien.TabStop = true;
            this.lnkChonAnhDaiDien.Text = "Chọn ảnh đại diện";
            this.lnkChonAnhDaiDien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkChonAnhDaiDien_LinkClicked);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Image = global::AppG2.Properties.Resources.update;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(471, 460);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(128, 41);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::AppG2.Properties.Resources.deleete2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(607, 460);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Bỏ qua";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picAnhDaiDien
            // 
            this.picAnhDaiDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhDaiDien.ContextMenuStrip = this.menuAvatar;
            this.picAnhDaiDien.Image = global::AppG2.Properties.Resources.avatar;
            this.picAnhDaiDien.Location = new System.Drawing.Point(549, 7);
            this.picAnhDaiDien.Margin = new System.Windows.Forms.Padding(4);
            this.picAnhDaiDien.Name = "picAnhDaiDien";
            this.picAnhDaiDien.Size = new System.Drawing.Size(167, 161);
            this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhDaiDien.TabIndex = 0;
            this.picAnhDaiDien.TabStop = false;
            this.picAnhDaiDien.DragDrop += new System.Windows.Forms.DragEventHandler(this.PicAnhDaiDien_DragDrop);
            this.picAnhDaiDien.DragEnter += new System.Windows.Forms.DragEventHandler(this.PicAnhDaiDien_DragEnter);
            // 
            // menuAvatar
            // 
            this.menuAvatar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAvatar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniXoaAnhDaiDien});
            this.menuAvatar.Name = "menuAvatar";
            this.menuAvatar.Size = new System.Drawing.Size(195, 30);
            // 
            // mniXoaAnhDaiDien
            // 
            this.mniXoaAnhDaiDien.Image = global::AppG2.Properties.Resources.deleete2;
            this.mniXoaAnhDaiDien.Name = "mniXoaAnhDaiDien";
            this.mniXoaAnhDaiDien.Size = new System.Drawing.Size(194, 26);
            this.mniXoaAnhDaiDien.Text = "Xóa ảnh đại diện";
            this.mniXoaAnhDaiDien.Click += new System.EventHandler(this.MniXoaAnhDaiDien_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(413, 39);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(112, 22);
            this.txtTen.TabIndex = 6;
            // 
            // frmThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 506);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnkChonAnhDaiDien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.chkGioiTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAnhDaiDien);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongTinSinhVien";
            this.Text = "Thông tin sinh viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuaTrinhHocTap)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
            this.menuAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuaTrinhHocTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnhDaiDien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgQuaTrinhHocTap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.LinkLabel lnkChonAnhDaiDien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ContextMenuStrip menuAvatar;
        private System.Windows.Forms.ToolStripMenuItem mniXoaAnhDaiDien;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.BindingSource bdsQuaTrinhHocTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}