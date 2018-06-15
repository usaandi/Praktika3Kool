namespace Usai_Praktika
{
    partial class UsaiExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsaiExcel));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.US_openDB = new System.Windows.Forms.ToolStripButton();
            this.US_Read = new System.Windows.Forms.ToolStripButton();
            this.US_SavetoDatabase = new System.Windows.Forms.ToolStripButton();
            this.US_addtogrupp = new System.Windows.Forms.ToolStripButton();
            this.US_SaveToTootja = new System.Windows.Forms.ToolStripButton();
            this.US_saveToToode = new System.Windows.Forms.ToolStripButton();
            this.U_progessbar = new System.Windows.Forms.ToolStripProgressBar();
            this.US_Tooted = new System.Windows.Forms.ListBox();
            this.US_1count = new System.Windows.Forms.Label();
            this.US_timer = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.US_nadal2 = new System.Windows.Forms.TextBox();
            this.US_nadal1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.US_päring = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.US_openDB,
            this.US_Read,
            this.US_SavetoDatabase,
            this.US_addtogrupp,
            this.US_SaveToTootja,
            this.US_saveToToode,
            this.U_progessbar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // US_openDB
            // 
            this.US_openDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.US_openDB.Image = ((System.Drawing.Image)(resources.GetObject("US_openDB.Image")));
            this.US_openDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.US_openDB.Name = "US_openDB";
            this.US_openDB.Size = new System.Drawing.Size(58, 22);
            this.US_openDB.Text = "Open DB";
            this.US_openDB.Click += new System.EventHandler(this.US_openDB_Click);
            // 
            // US_Read
            // 
            this.US_Read.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.US_Read.Enabled = false;
            this.US_Read.Image = ((System.Drawing.Image)(resources.GetObject("US_Read.Image")));
            this.US_Read.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.US_Read.Name = "US_Read";
            this.US_Read.Size = new System.Drawing.Size(86, 22);
            this.US_Read.Text = "Read hinnakiri";
            this.US_Read.Click += new System.EventHandler(this.US_Read_Click);
            // 
            // US_SavetoDatabase
            // 
            this.US_SavetoDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.US_SavetoDatabase.Enabled = false;
            this.US_SavetoDatabase.Image = ((System.Drawing.Image)(resources.GetObject("US_SavetoDatabase.Image")));
            this.US_SavetoDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.US_SavetoDatabase.Name = "US_SavetoDatabase";
            this.US_SavetoDatabase.Size = new System.Drawing.Size(53, 22);
            this.US_SavetoDatabase.Text = "Save DB";
            this.US_SavetoDatabase.Click += new System.EventHandler(this.US_SavetoDatabase_Click);
            // 
            // US_addtogrupp
            // 
            this.US_addtogrupp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.US_addtogrupp.Enabled = false;
            this.US_addtogrupp.Image = ((System.Drawing.Image)(resources.GetObject("US_addtogrupp.Image")));
            this.US_addtogrupp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.US_addtogrupp.Name = "US_addtogrupp";
            this.US_addtogrupp.Size = new System.Drawing.Size(96, 22);
            this.US_addtogrupp.Text = "Save To gruppid";
            this.US_addtogrupp.Click += new System.EventHandler(this.US_addtogrupp_Click);
            // 
            // US_SaveToTootja
            // 
            this.US_SaveToTootja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.US_SaveToTootja.Enabled = false;
            this.US_SaveToTootja.Image = ((System.Drawing.Image)(resources.GetObject("US_SaveToTootja.Image")));
            this.US_SaveToTootja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.US_SaveToTootja.Name = "US_SaveToTootja";
            this.US_SaveToTootja.Size = new System.Drawing.Size(87, 22);
            this.US_SaveToTootja.Text = "Save To Tootja";
            this.US_SaveToTootja.Click += new System.EventHandler(this.US_SaveToTootja_Click);
            // 
            // US_saveToToode
            // 
            this.US_saveToToode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.US_saveToToode.Enabled = false;
            this.US_saveToToode.Image = ((System.Drawing.Image)(resources.GetObject("US_saveToToode.Image")));
            this.US_saveToToode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.US_saveToToode.Name = "US_saveToToode";
            this.US_saveToToode.Size = new System.Drawing.Size(87, 22);
            this.US_saveToToode.Text = "Save To Toode";
            this.US_saveToToode.Click += new System.EventHandler(this.US_saveToToode_Click);
            // 
            // U_progessbar
            // 
            this.U_progessbar.Name = "U_progessbar";
            this.U_progessbar.Size = new System.Drawing.Size(100, 22);
            // 
            // US_Tooted
            // 
            this.US_Tooted.FormattingEnabled = true;
            this.US_Tooted.Location = new System.Drawing.Point(12, 28);
            this.US_Tooted.Name = "US_Tooted";
            this.US_Tooted.Size = new System.Drawing.Size(776, 43);
            this.US_Tooted.TabIndex = 1;
            // 
            // US_1count
            // 
            this.US_1count.Location = new System.Drawing.Point(9, 418);
            this.US_1count.Name = "US_1count";
            this.US_1count.Size = new System.Drawing.Size(118, 23);
            this.US_1count.TabIndex = 17;
            this.US_1count.Text = "0";
            // 
            // US_timer
            // 
            this.US_timer.Location = new System.Drawing.Point(133, 418);
            this.US_timer.Name = "US_timer";
            this.US_timer.Size = new System.Drawing.Size(118, 23);
            this.US_timer.TabIndex = 16;
            this.US_timer.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 248);
            this.dataGridView1.TabIndex = 18;
            // 
            // US_nadal2
            // 
            this.US_nadal2.Location = new System.Drawing.Point(148, 360);
            this.US_nadal2.Name = "US_nadal2";
            this.US_nadal2.Size = new System.Drawing.Size(100, 20);
            this.US_nadal2.TabIndex = 19;
            // 
            // US_nadal1
            // 
            this.US_nadal1.Location = new System.Drawing.Point(9, 360);
            this.US_nadal1.Name = "US_nadal1";
            this.US_nadal1.Size = new System.Drawing.Size(100, 20);
            this.US_nadal1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Esimene nädal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Teine nädal";
            // 
            // US_päring
            // 
            this.US_päring.Location = new System.Drawing.Point(79, 386);
            this.US_päring.Name = "US_päring";
            this.US_päring.Size = new System.Drawing.Size(101, 23);
            this.US_päring.TabIndex = 23;
            this.US_päring.Text = "Päri andmeid";
            this.US_päring.UseVisualStyleBackColor = true;
            this.US_päring.Click += new System.EventHandler(this.US_päring_Click);
            // 
            // UsaiExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.US_päring);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.US_nadal1);
            this.Controls.Add(this.US_nadal2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.US_1count);
            this.Controls.Add(this.US_timer);
            this.Controls.Add(this.US_Tooted);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UsaiExcel";
            this.Text = "UsaiExcel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsaiExcel_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton US_openDB;
        private System.Windows.Forms.ToolStripButton US_Read;
        private System.Windows.Forms.ListBox US_Tooted;
        private System.Windows.Forms.Label US_1count;
        private System.Windows.Forms.Label US_timer;
        private System.Windows.Forms.ToolStripButton US_SavetoDatabase;
        private System.Windows.Forms.ToolStripProgressBar U_progessbar;
        private System.Windows.Forms.ToolStripButton US_addtogrupp;
        private System.Windows.Forms.ToolStripButton US_SaveToTootja;
        private System.Windows.Forms.ToolStripButton US_saveToToode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox US_nadal2;
        private System.Windows.Forms.TextBox US_nadal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button US_päring;
    }
}