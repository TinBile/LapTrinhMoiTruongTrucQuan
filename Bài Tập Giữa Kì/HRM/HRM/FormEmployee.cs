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
    public partial class FormEmployee : Form
    {
        //Tạo datacontext
        HRMDataContext db = new HRMDataContext();
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            #region Đọc danh sách phòng ban
            //tạo nút gốc
            TreeNode root = new TreeNode("Danh Sách Phòng Ban", 0, 0);
            root.Tag = 0;
            //duyệt phòng ban đưa vào nút gốc
            foreach (var dep in db.Departments)
            {
                TreeNode child = new TreeNode(dep.DepartmentName, 1, 1);
                child.Tag = dep.DepartmentId;
                root.Nodes.Add(child);
            }
            //đưa nút gốc lên treeview
            trvDep.Nodes.Add(root);
            //mở các nút ra để xem
           // trvDep.ExpandAll();
            #endregion
        }

        private void lstEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmployee.SelectedItems.Count > 0)
            {
                ListViewItem item = lstEmployee.SelectedItems[0];
                MessageBox.Show(item.Text + ":" + item.SubItems[1].Text + ":" + item.SubItems[2].Text);
            }
        }

        private void trvDep_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //clear lisview
            lstEmployee.Items.Clear();
            //lấy mã phòng ban
            string depid = e.Node.Tag.ToString();
            //lấy danh sach sinh viên theo phòng ban
            var result = from emp in db.Employees
                         where emp.DepartmentId == depid
                         select new
                         {
                             emp.EmployeeId,
                             FullName = emp.FirstName + " " + emp.LastName,
                             emp.BirthDay,
                             emp.Sex,
                             emp.Phone,
                             emp.Email
                         };
            foreach (var emp in result)
            {
                ListViewItem item = new ListViewItem(emp.EmployeeId);
                item.ImageIndex = emp.Sex.Value ? 2 : 3;
                item.SubItems.Add(emp.FullName);
                item.SubItems.Add(emp.BirthDay.Value.ToString("dd/MM/yyyy"));
                item.SubItems.Add(emp.Phone);
                item.SubItems.Add(emp.Email);
                lstEmployee.Items.Add(item);
            }
        }

        private void rdoLargeIcon_Click(object sender, EventArgs e)
        {
            lstEmployee.View = View.LargeIcon;
        }

        private void rdoSmalIIcon_Click(object sender, EventArgs e)
        {
            lstEmployee.View = View.SmallIcon;
        }

        private void rdoDetails_Click(object sender, EventArgs e)
        {
            lstEmployee.View = View.Details;
        }

        private void rdoList_Click(object sender, EventArgs e)
        {
            lstEmployee.View = View.List;
        }

        private void rdoTitel_Click(object sender, EventArgs e)
        {
            lstEmployee.View = View.Tile;
        }
    }
}
