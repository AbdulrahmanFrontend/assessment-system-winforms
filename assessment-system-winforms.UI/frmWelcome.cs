using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCP.UI
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void tWelcome_Tick(object sender, EventArgs e)
        {
            this.Hide();
            tWelcome.Stop();
            frmStart frm = new frmStart();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
