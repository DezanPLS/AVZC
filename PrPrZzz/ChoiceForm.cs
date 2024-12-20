using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrPrZzz
{
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Открываем новую форму
            form1.Show();

            // Скрываем текущую форму (если нужно)
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RepairAVZ avz = new RepairAVZ();

            // Открываем новую форму
            avz.Show();

            // Скрываем текущую форму (если нужно)
            this.Hide();
        }
    }
}
