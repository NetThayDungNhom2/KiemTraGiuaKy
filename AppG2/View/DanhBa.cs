using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppG2.Controller;
using AppG2.Model;

namespace AppG2.View
{
    public partial class DanhBa : Form
    {

        #region Path data file
        string pathClientDataFile;
        #endregion

        public DanhBa()
        {
            InitializeComponent();
        pathClientDataFile = @"..\..\Data\client.txt";
        bindingSource1.DataSource = null;       
        dataGridView1.AutoGenerateColumns = false;
        List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
        if (client == null)
            throw new Exception("Danh bạ rỗng!");
        else
        {
                bindingSource1.DataSource = client;
        }
            dataGridView1.DataSource = bindingSource1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "A")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach ( ClientContact cl in client.ToList())
            {
                if(cl.FindN!="D")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "G")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "J")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "M")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "P")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "S")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "Y")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.FindN != "Z")
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }
        private void label11_Click(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }
        private void textBox1_keydown(object sender, KeyEventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client)
            {

            }
        }

        private void textBox1_changed(object sender, EventArgs e)
        {
            List<ClientContact> client = ContactService.GetClientContact(pathClientDataFile);
            foreach (ClientContact cl in client.ToList())
            {
                if (cl.Name.Contains(textBox1.Text)==false&&
                    cl.Email.Contains(textBox1.Text) == false&&
                    cl.Phone.Contains(textBox1.Text) == false)
                {
                    client.Remove(cl);
                }
            }
            bindingSource1.DataSource = client;
            dataGridView1.DataSource = bindingSource1;
        }

        private void textBox1_mouseClick(object sender, MouseEventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            if (textBox1.Text == "Search")
                textBox1.Text = "";
        }

        private void textBox1_leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Silver;
                textBox1.Text = "Search";
            }        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show(
                 "Bạn có chắc là muốn cập nhật và lưu dữ liệu không?",
                 "Thông báo",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                string[] listClients = new string[dataGridView1.Rows.Count];
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {

                    ClientContact client = new ClientContact
                    {
                        FindN = (dataGridView1.Rows[rows].Cells[1].Value == null) ? "" : dataGridView1.Rows[rows].Cells[1].ToString().Substring(0, 1),
                        Name = (dataGridView1.Rows[rows].Cells[1].Value == null) ? "" : dataGridView1.Rows[rows].Cells[1].Value.ToString(),
                        Phone = (dataGridView1.Rows[rows].Cells[2].Value == null) ? "" : dataGridView1.Rows[rows].Cells[2].Value.ToString(),
                        Email = (dataGridView1.Rows[rows].Cells[3].Value == null) ? "" : dataGridView1.Rows[rows].Cells[3].Value.ToString(),
                    };
                    int stt = rows + 1;
                    string cli = stt.ToString() + " #" + client.Name + " #" + client.Phone + " #" + client.Email;
                    listClients[rows] = cli;
                };
                File.WriteAllLines(pathClientDataFile, listClients, Encoding.UTF8);
            }
            else
            {
                MessageBox.Show("Bạn đã không lưu");
            }
            Close();
        }
    }
}
