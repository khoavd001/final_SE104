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
    public partial class FrmBill : Form
    {
        public static List<ItemTemp> itemTemps = new List<ItemTemp>();
        public FrmBill()
        {
            InitializeComponent();
            MakeData();
        }

        private void MakeData()
        {
            double subtotal = 0;
            double tax = 0;
            
            itemTemps.Add(new ItemTemp { ItemName = "Couple rings", Price = 5, Amount = 1, Discount = 0, Total = 5 });
            itemTemps.Add(new ItemTemp { ItemName = "Single ring", Price = 15, Amount = 2, Discount = 0, Total = 30 });
            itemTemps.Add(new ItemTemp { ItemName = "Couple rings", Price = 5, Amount = 1, Discount = 0, Total = 5 });
            itemTemps.Add(new ItemTemp { ItemName = "Single ring", Price = 5, Amount = 1, Discount = 0, Total = 5 });
            itemTemps.Add(new ItemTemp { ItemName = "Couple ring", Price = 5, Amount = 1, Discount = 0, Total = 5 });
            itemTemps.Add(new ItemTemp { ItemName = "Single ring", Price = 5, Amount = 1, Discount = 0, Total = 5 });
         
            dataGridView1.DataSource = itemTemps;
            foreach(var item in itemTemps)
            {
                subtotal += item.Total;
            }
            subTotal_txt.Text = subtotal.ToString();
            tax = (subtotal * 0.1);
            tax_txt.Text = tax.ToString();
            total_txt.Text = (subtotal+tax).ToString();
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.DefaultCellStyle.BackColor = Color.Red;
        }
        public class ItemTemp
        { 
            
            public string ItemName { get; set; }
            public int Price { get; set; }
            public int Amount { get; set; }
            public int Discount { get; set; }
            public int Total { get; set; }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];// get you required index
                                                         // check the cell value under your specific column and then you can toggle your colors
            row.DefaultCellStyle.BackColor = Color.FromArgb(215,245,244);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;
        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            
        }

       private void FrmBill_Click(object sender, EventArgs e)
        {
            /*DateTime today = DateTime.Today;
            //AddBill(today, CustomerID, staffID, int.Parse(total_txt.Text));
            foreach (var item in itemTemps)
            {
                AddBillDetails(PID, item.Amount, item.Price, item.Discount, int.Parse(tax_txt.Text), item.Total);
            }*/
        }
    }
}
