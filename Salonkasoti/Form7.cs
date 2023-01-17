using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salonkasoti
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonkrasotiDataSet.Предстоящие_записи". При необходимости она может быть перемещена или удалена.
            this.предстоящие_записиTableAdapter.Fill(this.salonkrasotiDataSet.Предстоящие_записи);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 reg = new Form3();
            reg.Show();
            this.Hide();
        }
    }
}
