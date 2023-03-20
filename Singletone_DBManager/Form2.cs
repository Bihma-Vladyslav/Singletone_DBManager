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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            db =  DBManager.Instance();
            db.connectTo();

        }
        DBManager db;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          var data = db.SelectAll("Країна");
            dataGridView1.Columns.Clear();
            if (data!= null)
            {
                for (int i = 0; i < data[0].Count; i++)
                {
                    dataGridView1.Columns.Add("col" + i.ToString(), "col" + i.ToString());
                }
                for (int i = 0; i < data.Count; i++)
                {
                    dataGridView1.Rows.Add(data[i].ToArray());

                }
            }
        }
    }
}
