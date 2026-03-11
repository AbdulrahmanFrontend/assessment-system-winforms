using System;
using System.Windows.Forms;

namespace CSCP
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmExam frm = new frmExam();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
