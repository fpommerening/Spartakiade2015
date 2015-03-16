using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FP.Spartakiade2015.UiManipulation.WinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiUserOpen_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm { MdiParent = this };
            frm.Show();
        }

        private void tsmiCustomerOpen_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm {MdiParent = this};
            frm.Show();
        }
    }
}
