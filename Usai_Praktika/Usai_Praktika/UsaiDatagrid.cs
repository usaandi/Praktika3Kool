using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace Usai_Praktika
{


    public partial class UsaiDatagrid : Form
    {
        private OleDbConnection myConnection;
        string selectedindex;
        string namefield;
        public UsaiDatagrid()
        {
            InitializeComponent();
        }

        private void US_SelectDatabase_Click(object sender, EventArgs e)
        {
            using (US_openFileDialog1)
            {
                if (US_openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fname = US_openFileDialog1.FileName;

                    myConnection = new OleDbConnection("Provider=Microsoft.ACE.oleDB.12.0;Data Source=" + fname);
                    myConnection.Open();
                   US_SelectDatabase.Enabled = false;
                    
                }
            }
        }

        private void US_loadDatabase_Click(object sender, EventArgs e)
        {
            //OleDbCommand command = new OleDbCommand();
            //command.Connection = myConnection;
            // command.CommandText = query;
            /* string query1 = "SELECT a.au_ID, a.Author, t.Title, t.[year published] as [Raamatu ilmumis aasta] " +
                 "FROM authors AS a, [title author] AS ta, titles AS t " +
                 "WHERE(((a.AU_ID) =[ta].[au_ID]) AND((ta.ISBN) =[t].[ISBN])) " +
                 "ORDER BY 1, 2 ";*/
            readDB();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            namefield = dataGridView1.CurrentCell.Value.ToString();
            US_textboxAutor.Text = namefield;


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Authors(Author, [year born]) VALUES('" + US_textboxAutor.Text + "', '" + US_autorYearBorn.Text + "') ";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();

            readDB();

        }

        private void readDB()
        {
            string query = "SELECT * FROM Authors ORDER BY Author";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void US_UpdateList_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Authors Set Author = '" + US_textboxAutor.Text + "'WHERE author = '" + namefield + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
            readDB();
        }
    }
}
