﻿using AppG2.Controller;
using AppG2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2.View
{
    public partial class frmThongTinSinhVien : Form
    {
        #region Variables to process Image Avatar 
        Image image;
        string pathDirectoryImg;
        string pathAvatarImg;
        #endregion

        #region Path data file
        string pathStudentDataFile;
        string pathLearningHistoryDataFile;
        #endregion

        public frmThongTinSinhVien(string maSinhVien)
        {
            InitializeComponent();

            pathDirectoryImg = Application.StartupPath + "\\Img";
            pathAvatarImg = pathDirectoryImg + "\\avatar.png";
            picAnhDaiDien.AllowDrop = true;

            pathStudentDataFile = Application.StartupPath + @"\Data\student.txt";
            pathLearningHistoryDataFile = Application.StartupPath + @"\Data\learninghistory.txt";
            if (File.Exists(pathAvatarImg))
            {
                FileStream fileStream = new FileStream(pathAvatarImg, FileMode.Open, FileAccess.Read);
                picAnhDaiDien.Image = Image.FromStream(fileStream);
                fileStream.Close();
            }

            bdsQuaTrinhHocTap.DataSource = null;
            dtgQuaTrinhHocTap.AutoGenerateColumns = false;

            //var student = StudentService.GetStudent(maSinhVien);
            var student = StudentService.GetStudent(pathStudentDataFile, maSinhVien);
            if (student == null)
                throw new Exception("Không tồn tại sinh viên này");
            else
            {
                student.ListHistoryLearning = StudentService.GetHistoryLearning(
                    pathLearningHistoryDataFile, maSinhVien);
                txtMaSinhVien.Text = student.IDStudent;
                txtHo.Text = student.LastName;
                txtTen.Text = student.FirstName;
                txtQueQuan.Text = student.POB;
                dtpNgaySinh.Value = student.DOB;
                chkGioiTinh.Checked = student.Gender == GENDER.Male;
                if (student.ListHistoryLearning != null)
                {
                    bdsQuaTrinhHocTap.DataSource = student.ListHistoryLearning;
                }
            }
            dtgQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;
        }

        private void LnkChonAnhDaiDien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh đại diện";
            openFileDialog.Filter = "File ảnh(*.png, *.jpg)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                picAnhDaiDien.Image = image;
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            #region Cập nhật hình đại diện
            bool imageSave = false;
            if (image != null)
            {
                if (!Directory.Exists(pathDirectoryImg))
                {
                    Directory.CreateDirectory(pathDirectoryImg);
                }
                image.Save(pathAvatarImg);
                imageSave = true;
            }
            #endregion

            if (imageSave)
            {
                MessageBox.Show(
                    "Đã cập nhật thông tin sinh viên thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void PicAnhDaiDien_DragDrop(object sender, DragEventArgs e)
        {
            var rs = (string[])e.Data.GetData(DataFormats.FileDrop);
            var filePath = rs.FirstOrDefault();
            image = Image.FromFile(filePath);
            picAnhDaiDien.Image = image;
        }

        private void PicAnhDaiDien_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void MniXoaAnhDaiDien_Click(object sender, EventArgs e)
        {
            picAnhDaiDien.Image = Properties.Resources.avatar;
            File.Delete(pathAvatarImg);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show(
                 "Bạn có chắc là muốn xóa dữ liệu này không?",
                 "Thông báo",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                //Viết code xóa dữ liệu tại đây
                var history = bdsQuaTrinhHocTap.Current as HistoryLearning;
                MessageBox.Show(
                    "Bạn đã xóa thành công. Địa chỉ: " + history.Address);
            }
            else
            {
                MessageBox.Show("Bạn đã không xóa");
            }
        }
    }
}
