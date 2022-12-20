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
    public partial class FrmServiceDetail : Form
    {
        public FrmServiceDetail()
        {
            InitializeComponent();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Cursor = Cursors.Hand;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Cursor = Cursors.Default;
        }

        private void FrmServiceDetail_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
