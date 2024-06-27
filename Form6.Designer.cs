namespace bazy
{
    partial class Form6
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
            dataGridViewWystapienia = new DataGridView();
            buttonDrukuj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWystapienia).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewWystapienia
            // 
            dataGridViewWystapienia.AllowUserToAddRows = false;
            dataGridViewWystapienia.AllowUserToDeleteRows = false;
            dataGridViewWystapienia.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewWystapienia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWystapienia.Dock = DockStyle.Fill;
            dataGridViewWystapienia.Location = new Point(0, 0);
            dataGridViewWystapienia.Name = "dataGridViewWystapienia";
            dataGridViewWystapienia.ReadOnly = true;
            dataGridViewWystapienia.RowHeadersVisible = false;
            dataGridViewWystapienia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewWystapienia.Size = new Size(1114, 450);
            dataGridViewWystapienia.TabIndex = 0;
            // 
            // buttonDrukuj
            // 
            buttonDrukuj.Location = new Point(1030, 12);
            buttonDrukuj.Name = "buttonDrukuj";
            buttonDrukuj.Size = new Size(75, 23);
            buttonDrukuj.TabIndex = 1;
            buttonDrukuj.Text = "Drukuj";
            buttonDrukuj.UseVisualStyleBackColor = true;
            buttonDrukuj.Click += buttonDrukuj_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 450);
            Controls.Add(buttonDrukuj);
            Controls.Add(dataGridViewWystapienia);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWystapienia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWystapienia;
        private System.Windows.Forms.Button buttonDrukuj;
    }
}
