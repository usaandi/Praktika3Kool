using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Diagnostics;

namespace Usai_Praktika
{
    public partial class UsaiExcel : Form
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range xlRange;
        string[,] Ex_mas = new string[3000,4];
        int arv;
        string nädal;
        Stopwatch timer = new Stopwatch();
        string connectionstring;
        private OleDbConnection myConnection;
        string query;
        string fname;


        public UsaiExcel()
        {
            InitializeComponent();
        }

        private void US_openDB_Click(object sender, EventArgs e)
        {

            using (openFileDialog1)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.fname = openFileDialog1.FileName;

                    myConnection = new OleDbConnection("Provider=Microsoft.ACE.oleDB.12.0;Data Source=" + fname);
                    myConnection.Open();
                    US_openDB.Enabled = false;
                   
          
                }
                US_openDB.Enabled = false;
            }
        }

        private void US_Read_Click(object sender, EventArgs e)
        {
            using (openFileDialog1)
            {
                openFileDialog1.Filter = "Excel files| *.XLS;*.XLSX;*.XLSM";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.fname = openFileDialog1.FileName;

                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Open(fname);
                    xlWorkSheet = xlWorkBook.Worksheets["Täishinnakiri"];

                    timer.Start();

                    arv = 0;
                    U_progessbar.Value = 12;
                    U_progessbar.Maximum = 3000;
                    for (int rn = 12; rn < 3000; rn++)
                    {
                        xlRange = xlWorkSheet.Cells[rn, 4];
                        if (xlRange.Value != null)
                        {
                            double d = xlRange.Value;

                            Ex_mas[arv, 3] = d.ToString();
                            xlRange = xlWorkSheet.Cells[rn, 1];
                            Ex_mas[arv, 0] = xlRange.Value;
                            xlRange = xlWorkSheet.Cells[rn, 2];
                            Ex_mas[arv, 1] = xlRange.Value;
                            xlRange = xlWorkSheet.Cells[rn, 3];
                            Ex_mas[arv, 2] = xlRange.Value;
                            if (Ex_mas[arv,2]!=null)
                                arv++;
                        }
                    }
                    if (U_progessbar.Value<U_progessbar.Maximum)
                    {
                        U_progessbar.Value += 1;
                    }
                    US_Tooted.Items.Clear();
                    for (int i = 0; i < arv; i++)
                    {
                        US_Tooted.Items.Add(Ex_mas[i,2]);
                    }
                    timer.Stop();
                    US_1count.Text = US_Tooted.Items.Count.ToString()+ " rows";
                    US_timer.Text = timer.ElapsedMilliseconds.ToString() + " ms";
                    US_SavetoDatabase.Enabled = true;
                }
            }
        }

        private void UsaiExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
           // myConnection.Close();
         
        }

        private void US_SavetoDatabase_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arv; i++)
            {
                Ex_mas[i, 2] = Ex_mas[i, 2].Replace("'", "''");

                string query = "INSERT INTO Hinnakiri_sharp(Grupp, Tootja, Toode, Hind) VALUES('" + Ex_mas[i,0] + "', '" + Ex_mas[i, 1] + "', '" + Ex_mas[i,2] + "', '" +Ex_mas[i,3] + "') ";
                OleDbCommand command = new OleDbCommand(query, myConnection);

                command.ExecuteNonQuery();
            }
        }

        private void US_addtogrupp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arv; i++)
            {
                query = "SELECT Grupp" +
                    "FROM Grupid " +
                    "WHERE Grupp = '" + +  "'
            }
        }
    }
}
