using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class frmMessengerFormater : Form
    {
        public frmMessengerFormater()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            label5.Text = txtName.Text + ":" + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtName.Clear();
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Black;
        }

        private void chkMessageVailable_CheckedChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = chkMessageVailable.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSmall_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = true;
            picSmall.Visible = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
