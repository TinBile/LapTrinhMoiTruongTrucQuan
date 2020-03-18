using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmSimple : Form
    {
        public frmSimple()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was click.");
        }

        private void frmSimple_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi,Wellcom to c# 2010 programming!");
        }
        private void frmSimple_Click(object sender, EventArgs e)
        {
            MessageBox.Show("form was click!");
        }
    }
}
