using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Data.CurrentUser.username = this.txt_boxID.Text;
            Data.CurrentUser.userpwd = this.txtBox_pwd.Text;
            MessageBox.Show(this.txt_boxID.Text + "登录！");
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
