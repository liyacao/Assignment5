﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new SelectForm().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new SelectForm().Show();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = Convert.ToString(Program.product.productID);
            this.textBox2.Text = Convert.ToString(Program.product.condition);
            this.textBox3.Text = Convert.ToString(Program.product.cost);
            this.textBox4.Text = Convert.ToString(Program.product.platform);
            this.textBox5.Text = Convert.ToString(Program.product.OS);
            this.textBox6.Text = Convert.ToString(Program.product.manufacturer);
            this.textBox7.Text = Convert.ToString(Program.product.model);
            this.textBox8.Text = Convert.ToString(Program.product.RAM_size);
            this.textBox9.Text = Convert.ToString(Program.product.screensize);
            this.textBox10.Text = Convert.ToString(Program.product.HDD_size);
            this.textBox11.Text = Convert.ToString(Program.product.CPU_brand);
            this.textBox12.Text = Convert.ToString(Program.product.CPU_number);
            this.textBox13.Text = Convert.ToString(Program.product.GPU_Type);
            this.textBox14.Text = Convert.ToString(Program.product.CPU_type);
            this.textBox15.Text = Convert.ToString(Program.product.CPU_speed);
            this.textBox16.Text = Convert.ToString(Program.product.webcam);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new OrderForm().Show();
        }
    }
}
