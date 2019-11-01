using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG2.Model;

namespace AppG2.View
{
    public partial class Form1 : Form
    {
        HistoryLearning history;
        public Form1(HistoryLearning history = null)
        {
            InitializeComponent();
            this.history = history;
            if(history != null)
            {
                //Chỉnh sửa
                this.Text = "Chỉnh sửa quá trình học tập";
                numTuNam.Value = history.YearFrom;
                numDenNam.Value = history.YearEnd;
            }
            else
            {
                //Thêm mới
                this.Text = "Thêm mới quá trình học tập";
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(history != null)
            {
                //Cập nhật
            }
            else
            {
                //Thêm mới
            }
            MessageBox.Show("Đã cập nhật dữ liệu thành công");
            DialogResult = DialogResult.OK;
        }
    }
}
