namespace Phần_mềm_vàng_bạc_trang_sức.GUI_design_file_
{
    partial class FrmBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.subTotal_txt = new System.Windows.Forms.Label();
            this.tax_txt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.discount_txt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.total_txt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.staffID_txt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pictureBox1 = new Phần_mềm_vàng_bạc_trang_sức.Button_Custom.Roundedbutton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(925, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sub total:";
            // 
            // subTotal_txt
            // 
            this.subTotal_txt.AutoSize = true;
            this.subTotal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.subTotal_txt.Location = new System.Drawing.Point(1036, 350);
            this.subTotal_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTotal_txt.Name = "subTotal_txt";
            this.subTotal_txt.Size = new System.Drawing.Size(45, 25);
            this.subTotal_txt.TabIndex = 2;
            this.subTotal_txt.Text = "53$";
            // 
            // tax_txt
            // 
            this.tax_txt.AutoSize = true;
            this.tax_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tax_txt.Location = new System.Drawing.Point(1036, 389);
            this.tax_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tax_txt.Name = "tax_txt";
            this.tax_txt.Size = new System.Drawing.Size(50, 25);
            this.tax_txt.TabIndex = 4;
            this.tax_txt.Text = "5,3$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(925, 389);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tax:";
            // 
            // discount_txt
            // 
            this.discount_txt.AutoSize = true;
            this.discount_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.discount_txt.Location = new System.Drawing.Point(1036, 428);
            this.discount_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.discount_txt.Name = "discount_txt";
            this.discount_txt.Size = new System.Drawing.Size(41, 25);
            this.discount_txt.TabIndex = 6;
            this.discount_txt.Text = "0%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(925, 428);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discount:";
            // 
            // total_txt
            // 
            this.total_txt.AutoSize = true;
            this.total_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.total_txt.Location = new System.Drawing.Point(1036, 464);
            this.total_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_txt.Name = "total_txt";
            this.total_txt.Size = new System.Drawing.Size(61, 25);
            this.total_txt.TabIndex = 8;
            this.total_txt.Text = "58,3$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(925, 464);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total:";
            // 
            // staffID_txt
            // 
            this.staffID_txt.AutoSize = true;
            this.staffID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffID_txt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffID_txt.Location = new System.Drawing.Point(1036, 503);
            this.staffID_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffID_txt.Name = "staffID_txt";
            this.staffID_txt.Size = new System.Drawing.Size(73, 25);
            this.staffID_txt.TabIndex = 10;
            this.staffID_txt.Text = "KD016";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(925, 503);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Staff Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.Name = null;
            this.dataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 335);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Angle = 66F;
            this.pictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox1.BackgroundColor = System.Drawing.Color.Lavender;
            this.pictureBox1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pictureBox1.BorderRadius = 17;
            this.pictureBox1.BorderSize = 0;
            this.pictureBox1.Color0 = System.Drawing.Color.Aquamarine;
            this.pictureBox1.Color1 = System.Drawing.Color.Aqua;
            this.pictureBox1.FlatAppearance.BorderSize = 0;
            this.pictureBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pictureBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(930, 594);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 47);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.Text = "UPDATE";
            this.pictureBox1.TextColor = System.Drawing.Color.Black;
            this.pictureBox1.UseVisualStyleBackColor = false;
            // 
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 937);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.staffID_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.total_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.discount_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tax_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subTotal_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBill";
            this.Text = "FrmBill";
            this.Load += new System.EventHandler(this.FrmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subTotal_txt;
        private System.Windows.Forms.Label tax_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label discount_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label total_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label staffID_txt;
        private System.Windows.Forms.Label label10;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridView1;
        private Button_Custom.Roundedbutton pictureBox1;
    }
}