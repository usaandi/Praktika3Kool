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
        string selectedautor;
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
         

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //insert into database

            string query = "INSERT INTO Authors(Author, [year born]) VALUES('" + US_textboxAutor.Text + "', '" + US_autorYearBorn.Text + "') ";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();

            readDB();

        }

        private void readDB()
        {
            // read database
            string query = "SELECT author, [year born] FROM Authors ORDER BY Author";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void US_UpdateList_Click(object sender, EventArgs e)
        {
            //update database
            string query = "UPDATE Authors Set Author = '" + US_textboxAutor.Text + "'WHERE author = '" + namefield + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
            readDB();
        }

        private void US_Delete_Click(object sender, EventArgs e)
        {
            //delete item from database
            string query;

            query = "SELECT COUNT(ISBN) FROM [title author] WHERE AU_ID IN " +
                "(SELECT Au_ID FROM Authors WHERE author='" + selectedautor + "')";

            OleDbCommand command1 = new OleDbCommand(query, myConnection);
            int k = (int)(command1.ExecuteScalar());
            if (k > 0)
            {
                string a = "Kustutada" + k.ToString() + " kirjet tabelist [title author]?";
                DialogResult vastus = MessageBox.Show(a, "Delete", MessageBoxButtons.YesNo);
                if (vastus == DialogResult.No) return;
            }

            query = "DELETE FROM [title author] WHERE Au_ID IN " +
                "(SELECT AU_ID FROM Authors WHERE author ='" + selectedautor + "')";
            OleDbCommand command2 = new OleDbCommand(query, myConnection);
            command2.ExecuteNonQuery();


            query = "DELETE FROM Authors WHERE author ='" + selectedautor + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();

            readDB();
        }
        public void title()
        {
            //get author titles
            string query = "SELECT Title as [Autori raamatud]" +
                " FROM Authors, [Title Author]," +
                " Titles WHERE Titles.ISBN=[Title Author].ISBN AND [Title author].AU_ID=Authors.AU_ID" +
                " AND Author LIKE '" + selectedautor + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            US_dataGridView2.DataSource = dt;
        }

        private void US_autorTitles_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*CellEnter selected item */

            namefield = dataGridView1.CurrentCell.Value.ToString();
            US_textboxAutor.Text = namefield;
            selectedautor = namefield;
            title();
        }
    }
}
