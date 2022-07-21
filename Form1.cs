using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Web;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dGView_users.AllowUserToAddRows = false;
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            this.dGView_users.Rows.Add();
            dGView_users.CurrentRow.Cells["Column2"].Value = Data.CurrentUser.username.ToString();

        }

        private void dGView_users_Click(object sender, EventArgs e)
        {
           // DataRowView drv = dGView_users.SelectedRows[0].DataBoundItem as DataRowView;
           // dGView_users.Rows.Remove(dGView_users.CurrentRow);
            //dGView_users.Refresh();
           // MessageBox.Show("删除成功！");
        }

        private void dGView_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGView_users.Rows.Count > 0)
            {
                dGView_users.Rows.Remove(dGView_users.CurrentRow);
                dGView_users.Refresh();
                MessageBox.Show("删除成功！");
            }
        }
       


        private void btn_save_Click(object sender, EventArgs e)
        {
           Data.CurrentUser.username = "d";
        }
    }
}
