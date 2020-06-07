using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            lvThongTinSinhVien.View = View.Details;
            lvThongTinSinhVien.FullRowSelect = true;
            lvThongTinSinhVien.Columns.Add("Tên Sinh Viên",150);
            lvThongTinSinhVien.Columns.Add("Ngày Sinh", 150);
            lvThongTinSinhVien.Columns.Add("SDT", 150);
        }
        
        private void add(String  name,String date,String sdt)
        {
            String[] row = { name, date, sdt };
            ListViewItem item = new ListViewItem(row);
            lvThongTinSinhVien.Items.Add(item);
        }
        private void update()
        {
            lvThongTinSinhVien.SelectedItems[0].SubItems[0].Text = txtName.Text;
            lvThongTinSinhVien.SelectedItems[0].SubItems[1].Text = txtPosition.Text;
            lvThongTinSinhVien.SelectedItems[0].SubItems[2].Text = txtTeam.Text;
            txtName.Text = "";
            txtPosition.Text = "";
            txtTeam.Text = "";
        }
        private void delete()
        {
            if (MessageBox.Show("Sure ?? ", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lvThongTinSinhVien.Items.RemoveAt(lvThongTinSinhVien.SelectedIndices[0]);
                txtName.Text = "";
                txtPosition.Text = "";
                txtTeam.Text = "";
            }
        }

        private void lvThongTinSinhVien_Click(object sender, EventArgs e)
        {
            txtName.Text = lvThongTinSinhVien.SelectedItems[0].SubItems[0].Text;
            txtPosition.Text = lvThongTinSinhVien.SelectedItems[0].SubItems[1].Text;
            txtTeam.Text = lvThongTinSinhVien.SelectedItems[0].SubItems[2].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add(txtName.Text, txtPosition.Text, txtTeam.Text);
            txtName.Text = "";
            txtPosition.Text = "";
            txtTeam.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvThongTinSinhVien.Items.Clear();
            txtName.Text = "";
            txtPosition.Text = "";
            txtTeam.Text = "";
        }
    }
}
