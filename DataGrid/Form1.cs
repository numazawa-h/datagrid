using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataGrid
{
    public partial class Form1 : Form
    {

        public DataGridList _rows = new DataGridList();

        public Form1()
        {
            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _rows.AssignDataGridView(this.dataGridView1);
        }

        int no =0;

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                ++no;
                _rows.Add(new DataGridRaw(no, $"test{no}", ""));
            }
            _rows.ScrollToEnd();
        }

    }

}
