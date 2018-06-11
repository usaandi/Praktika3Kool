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

    public partial class Usai_11_06_2018AccessDatabase : Form
    {
        
        private OleDbConnection myConnection;
        bool connectioninfo = false;
        string selectedAuthor;
        System.Diagnostics.Stopwatch timer = new Stopwatch();

        public Usai_11_06_2018AccessDatabase()
        {
            InitializeComponent();
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            //Open database

            using (US_openFileDialog1)
            {
                if (US_openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    myConnection =  new OleDbConnection(@"Provider=Microsoft.ACE.oleDB.12.0;Data Source=" + US_openFileDialog1.FileName);
                    myConnection.Open();                   
                    toolStripButton1.Enabled = false;
                    connectioninfo = true;
                }
            }        
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            readDB();
            watch.Stop();          
            US_timer.Text = watch.ElapsedMilliseconds.ToString() + "ms";
            US_authorCounter.Text = US_List_Authors.Items.Count.ToString() + " Authors";
        }

        private void US_List_Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAuthor = US_List_Authors.SelectedItem.ToString();
            US_textboxAuthor.Text = selectedAuthor;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            //Update Author database

            string query = "UPDATE Authors Set Author = '" + US_textboxAuthor.Text + "'WHERE author = '"+ selectedAuthor +"'";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
            readDB();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //insert into database

            string query = "INSERT INTO Authors(Author, [year born]) VALUES('" + US_textboxAuthor.Text + "', '" + US_textYearBorn.Text + "') ";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
            readDB();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            //Delete author
            string query = "DELETE FROM Authors WHERE author ='"+ selectedAuthor +"'";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
            readDB();
        }
        private void US_Author_Titles_Click(object sender, EventArgs e)
        {
            //Get author titles
           
            string query= "SELECT Title FROM Authors, [Title Author], Titles WHERE Titles.isbn=[Title Author].isbn AND [Title author].AU_ID=Authors.AU_ID AND Authors.Author='" + selectedAuthor + "'";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            command.ExecuteNonQuery();
            while (reader.Read())
            {

                US_List_Titles.Items.Add(reader[0].ToString());

            }
            reader.Close();
            command.Dispose();

        }
        public void readDB()
        {
            //Read database
         
            string query = "SELECT Author FROM Authors ORDER BY Author";

            OleDbCommand command = new OleDbCommand(query, myConnection);

            OleDbDataReader reader = command.ExecuteReader();

            US_List_Authors.Items.Clear();

            while (reader.Read())
            {               
                US_List_Authors.Items.Add(reader[0].ToString());
            }
            command.Dispose();
            
            reader.Close();
        }
        private void Usai_11_06_2018AccessDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connectioninfo)
            {
                myConnection.Close();
            }

        }

       
    }
}
