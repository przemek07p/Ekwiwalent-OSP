namespace bazy
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button buttonZapisz;

        private void InitializeComponent()
        {
            this.dataGridView1 = new DataGridView();
            this.buttonZapisz = new Button();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(697, 425);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 1;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new EventHandler(this.buttonZapisz_Click);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
        }
    }
}