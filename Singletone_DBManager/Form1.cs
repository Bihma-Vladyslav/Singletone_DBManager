using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singletone_DBManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_каталог_відеопродукціїDataSet1.Країна". При необходимости она может быть перемещена или удалена.
            this.країнаTableAdapter.Fill(this.бД_каталог_відеопродукціїDataSet1.Країна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бД_каталог_відеопродукціїDataSet.Країна_відеопродукції". При необходимости она может быть перемещена или удалена.
            this.країна_відеопродукціїTableAdapter.Fill(this.бД_каталог_відеопродукціїDataSet.Країна_відеопродукції);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
