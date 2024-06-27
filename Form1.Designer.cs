namespace bazy
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.Button buttonDeleteTable;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.ListBox listBoxTables;

        private void InitializeComponent()
        {
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.buttonDeleteTable = new System.Windows.Forms.Button();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.listBoxTables = new System.Windows.Forms.ListBox();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(278, 10);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.Location = new System.Drawing.Point(278, 68);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTable.TabIndex = 2;
            this.buttonAddTable.Text = "Add Table";
            this.buttonAddTable.UseVisualStyleBackColor = true;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.Location = new System.Drawing.Point(278, 97);
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTable.TabIndex = 3;
            this.buttonDeleteTable.Text = "Delete Table";
            this.buttonDeleteTable.UseVisualStyleBackColor = true;
            this.buttonDeleteTable.Click += new System.EventHandler(this.buttonDeleteTable_Click);
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(12, 70);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(260, 20);
            this.textBoxTableName.TabIndex = 4;
            // 
            // listBoxTables
            // 
            this.listBoxTables.FormattingEnabled = true;
            this.listBoxTables.Location = new System.Drawing.Point(12, 97);
            this.listBoxTables.Name = "listBoxTables";
            this.listBoxTables.Size = new System.Drawing.Size(260, 147);
            this.listBoxTables.TabIndex = 5;
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(260, 21);
            this.comboBoxTables.TabIndex = 6;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(278, 126);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(365, 256);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.listBoxTables);
            this.Controls.Add(this.textBoxTableName);
            this.Controls.Add(this.buttonDeleteTable);
            this.Controls.Add(this.buttonAddTable);
            this.Controls.Add(this.buttonRefresh);
            this.Name = "Form1";
            this.Text = "Database Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}