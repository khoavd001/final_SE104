using Phần_mềm_vàng_bạc_trang_sức.Button_Custom;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomer();
        }
        void LoadCustomer()
        {
            CustomerGridView.DataSource = CustomerDAO.Instance.GetListCustomer();
            CustomerGridView.Columns[0].HeaderText = "Id";
            CustomerGridView.Columns[1].HeaderText = "Name";
            CustomerGridView.Columns[2].HeaderText = "Gender";
            CustomerGridView.Columns[3].HeaderText = "Address";
            CustomerGridView.Columns[4].HeaderText = "Number";
            CustomerGridView.Columns[5].HeaderText = "Money";
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            
        }
        
        private void roundedbutton1_Click(object sender, EventArgs e)
        {

        }
        Color color0;
        private void roundedbutton1_MouseEnter(object sender, EventArgs e)
        {
            
            
            DeleteCustomerButton.Color1 = Color.Blue;
        }

        private void roundedbutton1_MouseLeave(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Aqua;
            
        }

        private void roundedbutton3_Click(object sender, EventArgs e)
        {

        }

        private void roundedbutton2_MouseEnter(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Blue;

        }

        private void roundedbutton2_MouseLeave(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Aqua;
        }

        private void roundedbutton3_Click_1(object sender, EventArgs e)
        {

        }

        private void roundedbutton3_MouseEnter_1(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Blue;
        }

        private void roundedbutton3_Click_2(object sender, EventArgs e)
        {

        }
        
        private void roundedbutton2_Click_1(object sender, EventArgs e)
        {

        }

        private void roundedbutton2_MouseEnter_1(object sender, EventArgs e)
        {
            UpdateCustomerButton.Color1 = Color.Blue;
        }

        private void roundedbutton2_MouseLeave_1(object sender, EventArgs e)
        {
            UpdateCustomerButton.Color1= Color.Aqua;
        }

        private void roundedbutton3_MouseEnter_2(object sender, EventArgs e)
        {
            CustomerAddButton.Color1 = Color.Blue;
        }

        private void roundedbutton3_MouseLeave_1(object sender, EventArgs e)
        {
            CustomerAddButton.Color1= Color.Aqua;
        }

        private void roundedbutton4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CumstomerDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roundedbutton1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.CustomerGridView.SelectedRows)
            {
                CustomerGridView.Rows.RemoveAt(item.Index);
            }
        }

        private void roundedbutton1_MouseEnter_1(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Blue;
        }

        private void DeleteCustomerButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteCustomerButton.Color1 = Color.Aqua;
        }

        private void CustomerAddButton_MouseEnter(object sender, EventArgs e)
        {
            CustomerAddButton.Color1 = Color.Blue;
        }

        private void CustomerAddButton_MouseLeave(object sender, EventArgs e)
        {
            CustomerAddButton.Color1 = Color.Aqua;
        }

        private void UpdateCustomerButton_MouseEnter(object sender, EventArgs e)
        {
            UpdateCustomerButton.Color1 = Color.Blue;
        }

        private void UpdateCustomerButton_MouseLeave(object sender, EventArgs e)
        {
            UpdateCustomerButton.Color1 = Color.Aqua;
        }

        private void CustomerAddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
