using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usai_Praktika
{
    public partial class Form1 : Form
    {
        Form F1 = new Usai_11_06_2018AccessDatabase();
        Form F2 = new UsaiDatagrid();
        Form F3 = new UsaiExcel();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (F1.Visible == false) F1 = new Usai_11_06_2018AccessDatabase();
            F1.Visible = true;
            F1.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (F2.Visible == false) F2 = new UsaiDatagrid();
            F2.Visible = true;
            F2.Activate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if (F3.Visible == false) F3 = new UsaiExcel();
            F3.Visible = true;
            F3.Activate();
        }
    }
}
