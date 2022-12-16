using Phần_mềm_vàng_bạc_trang_sức.DAO_database_callback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
            LoadStaff();
        }
        void LoadStaff()
        {
            StaffGridView.DataSource = AccountDAO.Instance.GetListAccount();
            StaffGridView.Columns[1].HeaderText = "Name";
            StaffGridView.Columns[2].HeaderText = "Gender";
            StaffGridView.Columns[3].HeaderText = "Contact Phone";
            StaffGridView.Columns[4].HeaderText = "Email";
            StaffGridView.Columns[5].HeaderText = "Shift";
        }
        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedbutton2_MouseEnter(object sender, EventArgs e)
        {
            roundedbutton2.Color1 = Color.Blue;
        }

        private void roundedbutton2_Click(object sender, EventArgs e)
        {
            
        }

        private void roundedbutton2_MouseLeave(object sender, EventArgs e)
        {
            roundedbutton2.Color1 = Color.Aqua;
        }

        private void roundedbutton1_MouseEnter(object sender, EventArgs e)
        {
            roundedbutton1.Color1 = Color.Blue;
        }

        private void roundedbutton1_MouseLeave(object sender, EventArgs e)
        {
            roundedbutton1.Color1 = Color.Aqua;
        }

        private void roundedbutton3_MouseEnter(object sender, EventArgs e)
        {
            roundedbutton3.Color1 = Color.Blue;
        }

        private void roundedbutton3_MouseLeave(object sender, EventArgs e)
        {
            roundedbutton3.Color1 = Color.Aqua;

        }
        void DeleteAccount(string userName)
        {

            if (AccountDAO.Instance.DeleteAccount(userName) /*&& AccountInfoDAL.Instance.DeleteAccountInfo(userName)*/)
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadStaff();
        }
        private void StaffGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DeleteAccount((string)StaffGridView.CurrentRow.Cells["StaffName"].Value);
        }
    }
}
