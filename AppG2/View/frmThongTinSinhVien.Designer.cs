﻿namespace AppG2.View
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lnkChonAnhDaiDien = new System.Windows.Forms.LinkLabel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.menuAvatar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniXoaAnhDaiDien = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.bdsQuaTrinhHocTap = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên:";
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Location = new System.Drawing.Point(109, 58);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(48, 17);
            this.chkGioiTinh.TabIndex = 3;
            this.chkGioiTinh.Text = "Nam";
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quê quán:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(109, 108);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(286, 53);
            this.txtQueQuan.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(109, 82);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(118, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(109, 6);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(286, 20);
            this.txtMaSinhVien.TabIndex = 6;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(109, 32);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(186, 20);
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
            this.panel1.Location = new System.Drawing.Point(15, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 203);
            this.panel1.TabIndex = 7;
            // 
            // dtgQuaTrinhHocTap
            // 
            this.dtgQuaTrinhHocTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQuaTrinhHocTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dtgQuaTrinhHocTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgQuaTrinhHocTap.Location = new System.Drawing.Point(0, 25);
            this.dtgQuaTrinhHocTap.MultiSelect = false;
            this.dtgQuaTrinhHocTap.Name = "dtgQuaTrinhHocTap";
            this.dtgQuaTrinhHocTap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgQuaTrinhHocTap.Size = new System.Drawing.Size(524, 154);
            this.dtgQuaTrinhHocTap.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 179);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Tổng số mục: 0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(524, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel1.Text = "Quá trình học tập";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = global::AppG2.Properties.Resources.delete;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(45, 22);
            this.toolStripButton3.Text = "Xóa";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = global::AppG2.Properties.Resources.edit;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton2.Text = "Sửa";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::AppG2.Properties.Resources.add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Thêm";
            // 
            // lnkChonAnhDaiDien
            // 
            this.lnkChonAnhDaiDien.AutoSize = true;
            this.lnkChonAnhDaiDien.Location = new System.Drawing.Point(428, 140);
            this.lnkChonAnhDaiDien.Name = "lnkChonAnhDaiDien";
            this.lnkChonAnhDaiDien.Size = new System.Drawing.Size(94, 13);
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
            this.btnCapNhat.Location = new System.Drawing.Point(353, 374);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(96, 33);
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
            this.button1.Location = new System.Drawing.Point(455, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
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
            this.picAnhDaiDien.Location = new System.Drawing.Point(412, 6);
            this.picAnhDaiDien.Name = "picAnhDaiDien";
            this.picAnhDaiDien.Size = new System.Drawing.Size(126, 131);
            this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnhDaiDien.TabIndex = 0;
            this.picAnhDaiDien.TabStop = false;
            this.picAnhDaiDien.DragDrop += new System.Windows.Forms.DragEventHandler(this.PicAnhDaiDien_DragDrop);
            this.picAnhDaiDien.DragEnter += new System.Windows.Forms.DragEventHandler(this.PicAnhDaiDien_DragEnter);
            // 
            // menuAvatar
            // 
            this.menuAvatar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniXoaAnhDaiDien});
            this.menuAvatar.Name = "menuAvatar";
            this.menuAvatar.Size = new System.Drawing.Size(154, 26);
            // 
            // mniXoaAnhDaiDien
            // 
            this.mniXoaAnhDaiDien.Image = global::AppG2.Properties.Resources.deleete2;
            this.mniXoaAnhDaiDien.Name = "mniXoaAnhDaiDien";
            this.mniXoaAnhDaiDien.Size = new System.Drawing.Size(153, 22);
            this.mniXoaAnhDaiDien.Text = "Xóa ảnh đại diện";
            this.mniXoaAnhDaiDien.Click += new System.EventHandler(this.MniXoaAnhDaiDien_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(310, 32);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(85, 20);
            this.txtTen.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDHistoryLearning";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Period";
            this.Column2.HeaderText = "Thời gian học";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Address";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.Name = "Column4";
            // 
            // frmThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 411);
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.LinkLabel lnkChonAnhDaiDien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ContextMenuStrip menuAvatar;
        private System.Windows.Forms.ToolStripMenuItem mniXoaAnhDaiDien;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.BindingSource bdsQuaTrinhHocTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}