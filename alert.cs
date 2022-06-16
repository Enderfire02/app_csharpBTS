using app_csharpBTS.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_csharpBTS
{
    public partial class alert : Form
    {
        ProductManager productManager = new ProductManager();
        public alert()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void execute_Click(object sender, EventArgs e)
        {
            productManager.psStock();
        }
    }
}
