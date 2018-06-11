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
    }
}
