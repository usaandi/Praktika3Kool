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
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.fname = openFileDialog1.FileName;

                    myConnection = new OleDbConnection("Provider=Microsoft.ACE.oleDB.12.0;Data Source=" + fname);
                    myConnection.Open();
                    US_openDB.Enabled = false;
                    US_openDB.Enabled = false;
                    US_Read.Enabled = true;
                }
             
            }
        }

        private void US_Read_Click(object sender, EventArgs e)
        {
            using (this.openFileDialog1)
            {
                this.openFileDialog1.Filter = "Excel files| *.XLS;*.XLSX;*.XLSM";
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
          myConnection.Close();
            xlWorkBook.Close(0);
            xlApp.Quit();

        }

        private void US_SavetoDatabase_Click(object sender, EventArgs e)
        {
            query = "DELETE * FROM Hinnakiri_sharp";
            OleDbCommand commandd = new OleDbCommand(query, myConnection);
            commandd.ExecuteNonQuery();

            for (int i = 0; i < arv; i++)
            {
                Ex_mas[i, 2] = Ex_mas[i, 2].Replace("'", "''");

                query = "INSERT INTO Hinnakiri_sharp(Grupp, Tootja, Toode, Hind) VALUES('" + Ex_mas[i,0] + "', '" + Ex_mas[i, 1] + "', '" + Ex_mas[i,2] + "', '" +Ex_mas[i,3] + "') ";
                OleDbCommand command = new OleDbCommand(query, myConnection);

                command.ExecuteNonQuery();
            }

            query = "INSERT INTO Tootja (Tootjanimetus)" +
                " SELECT DISTINCT Tootja" +
                " FROM Hinnakiri_sharp AS H" +
                " WHERE NOT EXISTS (SELECT * FROM Tootja AS t WHERE t.Tootjanimetus=H.Tootja)" +
                " Order BY Tootja;";
            OleDbCommand command1 = new OleDbCommand(query, myConnection);
            command1.ExecuteNonQuery();

            query = "INSERT INTO Grupid (Grupinimetus)" +
                " SELECT DISTINCT Grupp" +
                " FROM Hinnakiri_sharp as H" +
                " WHERE NOT EXISTS (SELECT * FROM Grupid AS g WHERE g.Grupinimetus=H.Grupp)" +
                " ORDER BY Grupp";
            OleDbCommand command2 = new OleDbCommand(query, myConnection);
            command2.ExecuteNonQuery();

            query = "INSERT INTO Toode (Tootenimetus, Tootjad_ID, Grupp_ID) " +
                " SELECT DISTINCT h.Toode, t.Tootja_ID, g.Grupp_ID" +
                " FROM Hinnakiri_sharp as h, Tootja as t, Grupid as g" +
                " Where h.Tootja=t.Tootjanimetus AND h.Grupp=g.Grupinimetus" +
                " AND NOT EXISTS (SELECT * FROM Toode as tt WHERE tt.Tootenimetus = h.Toode )" +
                " ORDER BY h.toode;";
            OleDbCommand command3 = new OleDbCommand(query, myConnection);
            command3.ExecuteNonQuery();

            xlRange = xlWorkSheet.Cells[3, 4];
            string nadal = xlRange.Value;
            query="DELETE FROM Hinnakiri WHERE Nadal='" +nadal+ "';";
            OleDbCommand command4 = new OleDbCommand(query, myConnection);
            command4.ExecuteNonQuery();

            query = "INSERT INTO Hinnakiri (Toode, Nadal, Hind )" +
                "SELECT t.Toode, '" + nadal + "',  h.Hind " +
                "FROM Hinnakiri_sharp AS h, Toode AS t " +
                "WHERE h.Toode=t.Tootenimetus " +
                "ORDER BY 1;";
            OleDbCommand command5 = new OleDbCommand(query, myConnection);
            command5.ExecuteNonQuery();
        }

        private void US_addtogrupp_Click(object sender, EventArgs e)
        {
            query = "DELETE * FROM Grupid";
            OleDbCommand commandd = new OleDbCommand(query, myConnection);
            commandd.ExecuteNonQuery();

            for (int i = 0; i < arv; i++)
            {
                query = "SELECT Grupinimetus" +
                    " FROM Grupid " +
                    "WHERE Grupinimetus = '" + Ex_mas[i,0] +  "'";
                OleDbCommand command = new OleDbCommand(query, myConnection);

                object k = (command.ExecuteScalar());
                if (k==null)
                {
                    query = "INSERT INTO Grupid (Grupinimetus) VALUES ('" + Ex_mas[i,0] + "')";
                    OleDbCommand command1 = new OleDbCommand(query, myConnection);
                    command1.ExecuteNonQuery();
                }
            }
        }

        private void US_SaveToTootja_Click(object sender, EventArgs e)
        {
            query = "DELETE * FROM Tootja";
            OleDbCommand commandd = new OleDbCommand(query, myConnection);
            commandd.ExecuteNonQuery();

            for (int i = 0; i < arv; i++)
            {
                query = "SELECT Tootjanimetus" +
                    " FROM Tootja " +
                    "WHERE Tootjanimetus = '" + Ex_mas[i, 1] + "'";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                object k = command.ExecuteScalar();
                if (k == null)
                {
                    query = "INSERT INTO Tootja (Tootjanimetus) VALUES ('" + Ex_mas[i, 1] + "')";
                    OleDbCommand command1 = new OleDbCommand(query, myConnection);
                    command1.ExecuteNonQuery();
                }
            }
        }

        private void US_saveToToode_Click(object sender, EventArgs e)
        {
            query = "DELETE * FROM Toode";
            OleDbCommand commandd = new OleDbCommand(query, myConnection);
            commandd.ExecuteNonQuery();

            for (int i = 0; i < arv; i++)
            {
                Ex_mas[i, 2] = Ex_mas[i, 2].Replace("'", "''");

                query = "SELECT Toode_ID " +
                    " FROM Toode " +
                    " WHERE Tootenimetus = '" + Ex_mas[i, 2] + "'";

               
                OleDbCommand command = new OleDbCommand(query, myConnection);
                object k = command.ExecuteScalar();

                if (k == null)
                {
                    query = "SELECT Grupinimetus" +
                   " FROM Grupid" +
                   " WHERE Grupinimetus = '" + Ex_mas[i, 0] + "'";
                    OleDbCommand Grupid_id = new OleDbCommand(query, myConnection);
                   int grupid= (int)(Grupid_id.ExecuteScalar());



                    query = "SELECT Tootjanimetus" +
                        " FROM Tootja" +
                        " WHERE Tootjanimetus = '" + Ex_mas[i, 1] + "'";
                    OleDbCommand Tootja_id = new OleDbCommand(query, myConnection);                   
                    int tootjaid = (int)(Tootja_id.ExecuteScalar());               

                    query = "INSERT INTO Toode (Tootenimetus, Tootjad_ID,  Grupp_ID) VALUES ('" + Ex_mas[i, 2] + "', '" +tootjaid.ToString() + "', '" +grupid.ToString() + "')";
                    OleDbCommand command1 = new OleDbCommand(query, myConnection);
                    command1.ExecuteNonQuery();
                }
            }
        }

        private void US_päring_Click(object sender, EventArgs e)
        {
          

            string query = "SELECT Tootenimetus, h1.Hind AS Esimene, h2.Hind AS Teine, Esimene - Teine AS Vahe " +
                "FROM Toode, Hinnakiri AS h1, Hinnakiri AS h2 " +
                "WHERE h1.Nadal = '" +US_nadal1.Text+ "' AND Toode.Toode= h1.Toode " +
                "AND h2.Nadal= '" +US_nadal2.Text+ "' AND h1.Toode= h2.Toode AND h1.Hind <> h2.Hind;";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
