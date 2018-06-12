namespace Usai_Praktika
{
    partial class Usai_11_06_2018AccessDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usai_11_06_2018AccessDatabase));
            this.button1 = new System.Windows.Forms.Button();
            this.US_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.US_List_Authors = new System.Windows.Forms.ListBox();
            this.US_List_Titles = new System.Windows.Forms.ListBox();
            this.US_timer = new System.Windows.Forms.Label();
            this.US_timer1 = new System.Windows.Forms.Label();
            this.US_textboxAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.US_textYearBorn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.US_Author_Titles = new System.Windows.Forms.Button();
            this.US_authorscount = new System.Windows.Forms.Label();
            this.US_titlescount = new System.Windows.Forms.Label();
            this.US_LoadDataGrid = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // US_openFileDialog1
            // 
            this.US_openFileDialog1.FileName = "US_openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1128, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton1.Text = "Open DB";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton2.Text = "Read Database";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // US_List_Authors
            // 
            this.US_List_Authors.FormattingEnabled = true;
            this.US_List_Authors.ItemHeight = 17;
            this.US_List_Authors.Location = new System.Drawing.Point(12, 28);
            this.US_List_Authors.Name = "US_List_Authors";
            this.US_List_Authors.Size = new System.Drawing.Size(381, 480);
            this.US_List_Authors.TabIndex = 2;
            this.US_List_Authors.SelectedIndexChanged += new System.EventHandler(this.US_List_Authors_SelectedIndexChanged);
            // 
            // US_List_Titles
            // 
            this.US_List_Titles.FormattingEnabled = true;
            this.US_List_Titles.ItemHeight = 17;
            this.US_List_Titles.Location = new System.Drawing.Point(399, 284);
            this.US_List_Titles.Name = "US_List_Titles";
            this.US_List_Titles.Size = new System.Drawing.Size(618, 191);
            this.US_List_Titles.TabIndex = 3;
            // 
            // US_timer
            // 
            this.US_timer.Location = new System.Drawing.Point(188, 520);
            this.US_timer.Name = "US_timer";
            this.US_timer.Size = new System.Drawing.Size(118, 23);
            this.US_timer.TabIndex = 5;
            this.US_timer.Text = "0";
            // 
            // US_timer1
            // 
            this.US_timer1.Location = new System.Drawing.Point(396, 487);
            this.US_timer1.Name = "US_timer1";
            this.US_timer1.Size = new System.Drawing.Size(67, 23);
            this.US_timer1.TabIndex = 6;
            this.US_timer1.Text = "0";
            // 
            // US_textboxAuthor
            // 
            this.US_textboxAuthor.Location = new System.Drawing.Point(496, 28);
            this.US_textboxAuthor.Name = "US_textboxAuthor";
            this.US_textboxAuthor.Size = new System.Drawing.Size(321, 24);
            this.US_textboxAuthor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(399, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Author";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 86);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(640, 86);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // US_textYearBorn
            // 
            this.US_textYearBorn.Location = new System.Drawing.Point(496, 58);
            this.US_textYearBorn.Name = "US_textYearBorn";
            this.US_textYearBorn.Size = new System.Drawing.Size(143, 24);
            this.US_textYearBorn.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(399, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Year Born";
            // 
            // US_Author_Titles
            // 
            this.US_Author_Titles.Location = new System.Drawing.Point(400, 247);
            this.US_Author_Titles.Margin = new System.Windows.Forms.Padding(4);
            this.US_Author_Titles.Name = "US_Author_Titles";
            this.US_Author_Titles.Size = new System.Drawing.Size(112, 30);
            this.US_Author_Titles.TabIndex = 14;
            this.US_Author_Titles.Text = "Titles";
            this.US_Author_Titles.UseVisualStyleBackColor = true;
            this.US_Author_Titles.Click += new System.EventHandler(this.US_Author_Titles_Click);
            // 
            // US_authorscount
            // 
            this.US_authorscount.Location = new System.Drawing.Point(12, 520);
            this.US_authorscount.Name = "US_authorscount";
            this.US_authorscount.Size = new System.Drawing.Size(118, 23);
            this.US_authorscount.TabIndex = 15;
            this.US_authorscount.Text = "0";
            // 
            // US_titlescount
            // 
            this.US_titlescount.Location = new System.Drawing.Point(469, 487);
            this.US_titlescount.Name = "US_titlescount";
            this.US_titlescount.Size = new System.Drawing.Size(67, 23);
            this.US_titlescount.TabIndex = 16;
            this.US_titlescount.Text = "0";
            // 
            // US_LoadDataGrid
            // 
            this.US_LoadDataGrid.Enabled = false;
            this.US_LoadDataGrid.Location = new System.Drawing.Point(934, 13);
            this.US_LoadDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.US_LoadDataGrid.Name = "US_LoadDataGrid";
            this.US_LoadDataGrid.Size = new System.Drawing.Size(181, 30);
            this.US_LoadDataGrid.TabIndex = 18;
            this.US_LoadDataGrid.Text = "Load into Datagrid";
            this.US_LoadDataGrid.UseVisualStyleBackColor = true;
            this.US_LoadDataGrid.Click += new System.EventHandler(this.US_LoadDataGrid_Click);
            // 
            // Usai_11_06_2018AccessDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 544);
            this.Controls.Add(this.US_LoadDataGrid);
            this.Controls.Add(this.US_titlescount);
            this.Controls.Add(this.US_authorscount);
            this.Controls.Add(this.US_Author_Titles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.US_textYearBorn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.US_textboxAuthor);
            this.Controls.Add(this.US_timer1);
            this.Controls.Add(this.US_timer);
            this.Controls.Add(this.US_List_Titles);
            this.Controls.Add(this.US_List_Authors);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Usai_11_06_2018AccessDatabase";
            this.Text = "Usai_11_06_2018AccessDatabase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Usai_11_06_2018AccessDatabase_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog US_openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ListBox US_List_Authors;
        private System.Windows.Forms.ListBox US_List_Titles;
        private System.Windows.Forms.Label US_timer;
        private System.Windows.Forms.Label US_timer1;
        private System.Windows.Forms.TextBox US_textboxAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox US_textYearBorn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button US_Author_Titles;
        private System.Windows.Forms.Label US_authorscount;
        private System.Windows.Forms.Label US_titlescount;
        private System.Windows.Forms.Button US_LoadDataGrid;
    }
}