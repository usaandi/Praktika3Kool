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
        Stopwatch timer = new Stopwatch();

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
                    string fname = US_openFileDialog1.FileName;

                    myConnection =  new OleDbConnection("Provider=Microsoft.ACE.oleDB.12.0;Data Source=" + fname);
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
         //   US_authorbooks.Text = US_List_Authors.Items.Count.ToString() + " Authors";
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
            string query;

            query = "SELECT COUNT(ISBN) FROM [title author] WHERE AU_ID IN " +
                "(SELECT Au_ID FROM Authors WHERE author='" + selectedAuthor + "')";

            OleDbCommand command1 = new OleDbCommand(query, myConnection);
            int k = (int)(command1.ExecuteScalar());
            if (k > 0)
            {
                string a = "Kustutada" + k.ToString() + " kirjet tabelist [title author]?";
                DialogResult vastus = MessageBox.Show(a, "Delete", MessageBoxButtons.YesNo);
                if (vastus == DialogResult.No) return;
            }

            query = "DELETE FROM [title author] WHERE Au_ID IN " +
                "(SELECT AU_ID FROM Authors WHERE author ='" + selectedAuthor + ")";
            OleDbCommand command2 = new OleDbCommand(query, myConnection);
            command2.ExecuteNonQuery();


            query = "DELETE FROM Authors WHERE author ='"+ selectedAuthor +"'";
            OleDbCommand command = new OleDbCommand(query, myConnection);

            command.ExecuteNonQuery();
           
            readDB();

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
            US_authorscount.Text = US_List_Authors.Items.Count.ToString();
          reader.Close();
            


        }
        private void US_Author_Titles_Click(object sender, EventArgs e)
        {
            //Get author titles
            var watch = Stopwatch.StartNew();

            string query= "SELECT Title FROM Authors, [Title Author]," +
                " Titles WHERE Titles.ISBN=[Title Author].ISBN AND [Title author].AU_ID=Authors.AU_ID" +
                " AND Author LIKE '" + selectedAuthor + "'";
            OleDbCommand command = new OleDbCommand(query,  myConnection);
          
            OleDbDataReader reader = command.ExecuteReader();
            US_List_Titles.Items.Clear();
         

            while (reader.Read())
            {

                US_List_Titles.Items.Add(reader[0].ToString());
                
            }
          reader.Close();
            US_titlescount.Text = US_List_Titles.Items.Count.ToString();
            US_timer1.Text = watch.ElapsedMilliseconds.ToString() + "ms";
         
        }
               
        private void Usai_11_06_2018AccessDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connectioninfo)
            {
                myConnection.Close();
            }
        }

        private void US_LoadDataGrid_Click(object sender, EventArgs e)
        {
            
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            string query = "SELECT * FROM Authors ORDER BY Author";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //dataGridView1.DataSource = dt;

            
        }
    }
}
