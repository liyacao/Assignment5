using System;
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
    public partial class SelectForm : Form
    {
        DBModel model = new DBModel();
        public SelectForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.textBox1.Text = ToString(model.products.Find(id));
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(this.dataGridView1.Rows[this.dataGridView1.SelectedRows[0].Index].Cells[0].Value);
                this.textBox1.Text = ToString(model.products.Find(id));
      
        }

        private string ToString(products products)
        {
            return products.manufacturer + " " + products.model + " Priced at : $" + products.cost;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataGridView1.Rows[this.dataGridView1.SelectedRows[0].Index].Cells[0].Value);
            Program.product = model.products.Find(id);
            new ProductInfoForm().Show();
            this.Close();
        }
    }
}
