namespace Usai_Praktika
{
    partial class UsaiDatagrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsaiDatagrid));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.US_SelectDatabase = new System.Windows.Forms.ToolStripButton();
            this.US_loadDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.US_UpdateList = new System.Windows.Forms.ToolStripButton();
            this.US_Delete = new System.Windows.Forms.ToolStripButton();
            this.US_openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.US_textboxAutor = new System.Windows.Forms.TextBox();
            this.US_autorYearBorn = new System.Windows.Forms.TextBox();
            this.US_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.US_autorTitles = new System.Windows.Forms.Button();
            this.US_Watch = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.US_dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.US_SelectDatabase,
            this.US_loadDatabase,
            this.toolStripButton1,
            this.US_UpdateList,
            this.US_Delete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // US_SelectDatabase
            // 
            this.US_SelectDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.US_SelectDatabase.Image = ((System.Drawing.Image)(resources.GetObject("US_SelectDatabase.Image")));
            this.US_SelectDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.US_SelectDatabase.Name = "US_SelectDatabase";
            this.US_SelectDatabase.Size = new System.Drawing.Size(93, 22);
            this.US_SelectDatabase.Text = "Select Database";
            this.US_SelectDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.US_SelectDatabase.Click += new System.EventHandler(this.US_SelectDatabase_Click);
            // 
            // US_loadDatabase
            // 
            this.US_loadDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.US_loadDatabase.Image = ((System.Drawing.Image)(resources.GetObject("US_loadDatabase.Image")));
            this.US_loadDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.US_loadDatabase.Name = "US_loadDatabase";
            this.US_loadDatabase.Size = new System.Drawing.Size(88, 22);
            this.US_loadDatabase.Text = "Load Database";
            this.US_loadDatabase.Click += new System.EventHandler(this.US_loadDatabase_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton1.Text = "Insert";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // US_UpdateList
            // 
            this.US_UpdateList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.US_UpdateList.Image = ((System.Drawing.Image)(resources.GetObject("US_UpdateList.Image")));
            this.US_UpdateList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.US_UpdateList.Name = "US_UpdateList";
            this.US_UpdateList.Size = new System.Drawing.Size(49, 22);
            this.US_UpdateList.Text = "Update";
            this.US_UpdateList.Click += new System.EventHandler(this.US_UpdateList_Click);
            // 
            // US_Delete
            // 
            this.US_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.US_Delete.Image = ((System.Drawing.Image)(resources.GetObject("US_Delete.Image")));
            this.US_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.US_Delete.Name = "US_Delete";
            this.US_Delete.Size = new System.Drawing.Size(44, 22);
            this.US_Delete.Text = "Delete";
            this.US_Delete.Click += new System.EventHandler(this.US_Delete_Click);
            // 
            // US_openFileDialog1
            // 
            this.US_openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 258);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // US_textboxAutor
            // 
            this.US_textboxAutor.Location = new System.Drawing.Point(12, 28);
            this.US_textboxAutor.Multiline = true;
            this.US_textboxAutor.Name = "US_textboxAutor";
            this.US_textboxAutor.Size = new System.Drawing.Size(306, 20);
            this.US_textboxAutor.TabIndex = 2;
            // 
            // US_autorYearBorn
            // 
            this.US_autorYearBorn.Location = new System.Drawing.Point(12, 54);
            this.US_autorYearBorn.Multiline = true;
            this.US_autorYearBorn.Name = "US_autorYearBorn";
            this.US_autorYearBorn.Size = new System.Drawing.Size(306, 20);
            this.US_autorYearBorn.TabIndex = 3;
            // 
            // US_dataGridView2
            // 
            this.US_dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.US_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.US_dataGridView2.Location = new System.Drawing.Point(12, 373);
            this.US_dataGridView2.Name = "US_dataGridView2";
            this.US_dataGridView2.Size = new System.Drawing.Size(776, 171);
            this.US_dataGridView2.TabIndex = 4;
            // 
            // US_autorTitles
            // 
            this.US_autorTitles.Location = new System.Drawing.Point(12, 344);
            this.US_autorTitles.Name = "US_autorTitles";
            this.US_autorTitles.Size = new System.Drawing.Size(75, 23);
            this.US_autorTitles.TabIndex = 5;
            this.US_autorTitles.Text = "Titles";
            this.US_autorTitles.UseVisualStyleBackColor = true;
            this.US_autorTitles.Click += new System.EventHandler(this.US_autorTitles_Click);
            // 
            // US_Watch
            // 
            this.US_Watch.AutoSize = true;
            this.US_Watch.Location = new System.Drawing.Point(333, 57);
            this.US_Watch.Name = "US_Watch";
            this.US_Watch.Size = new System.Drawing.Size(13, 13);
            this.US_Watch.TabIndex = 6;
            this.US_Watch.Text = "0";
            // 
            // UsaiDatagrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.US_Watch);
            this.Controls.Add(this.US_autorTitles);
            this.Controls.Add(this.US_dataGridView2);
            this.Controls.Add(this.US_autorYearBorn);
            this.Controls.Add(this.US_textboxAutor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UsaiDatagrid";
            this.Text = "UsaiDatagrid";
            this.Load += new System.EventHandler(this.UsaiDatagrid_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.US_dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton US_SelectDatabase;
        private System.Windows.Forms.ToolStripButton US_loadDatabase;
        private System.Windows.Forms.OpenFileDialog US_openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox US_textboxAutor;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox US_autorYearBorn;
        private System.Windows.Forms.ToolStripButton US_UpdateList;
        private System.Windows.Forms.ToolStripButton US_Delete;
        private System.Windows.Forms.DataGridView US_dataGridView2;
        private System.Windows.Forms.Button US_autorTitles;
        private System.Windows.Forms.Label US_Watch;
    }
}