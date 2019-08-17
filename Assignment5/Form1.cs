using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(startForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        private void startForm()
        {
            Application.Run(new SplashForm());
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new SelectForm().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(Program.selectedId == 0)
            {
                MessageBox.Show("There is not any saved order!");
            }
            else
            {
                Program.product = new DBModel().products.Find(Program.selectedId);
                new OrderForm().Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
