namespace bazy
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxLiczbaRatownikow;
        private TextBox textBoxData;
        private TextBox textBoxStawka;
        private TextBox textBoxCzas;
        private TextBox textBoxNrZdarzenia;
        private Button buttonDalej;

        private void InitializeComponent()
        {
            this.textBoxLiczbaRatownikow = new TextBox();
            this.textBoxData = new TextBox();
            this.textBoxStawka = new TextBox();
            this.textBoxCzas = new TextBox();
            this.textBoxNrZdarzenia = new TextBox();
            this.buttonDalej = new Button();
            this.SuspendLayout();
            // 
            // textBoxLiczbaRatownikow
            // 
            this.textBoxLiczbaRatownikow.Location = new System.Drawing.Point(12, 12);
            this.textBoxLiczbaRatownikow.Name = "textBoxLiczbaRatownikow";
            this.textBoxLiczbaRatownikow.Size = new System.Drawing.Size(260, 20);
            this.textBoxLiczbaRatownikow.TabIndex = 0;
            this.textBoxLiczbaRatownikow.PlaceholderText = "Liczba Ratowników";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(12, 38);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(260, 20);
            this.textBoxData.TabIndex = 1;
            this.textBoxData.PlaceholderText = "Data";
            // 
            // textBoxStawka
            // 
            this.textBoxStawka.Location = new System.Drawing.Point(12, 64);
            this.textBoxStawka.Name = "textBoxStawka";
            this.textBoxStawka.Size = new System.Drawing.Size(260, 20);
            this.textBoxStawka.TabIndex = 2;
            this.textBoxStawka.PlaceholderText = "Stawka";
            // 
            // textBoxCzas
            // 
            this.textBoxCzas.Location = new System.Drawing.Point(12, 90);
            this.textBoxCzas.Name = "textBoxCzas";
            this.textBoxCzas.Size = new System.Drawing.Size(260, 20);
            this.textBoxCzas.TabIndex = 3;
            this.textBoxCzas.PlaceholderText = "Czas";
            // 
            // textBoxNrZdarzenia
            // 
            this.textBoxNrZdarzenia.Location = new System.Drawing.Point(12, 116);
            this.textBoxNrZdarzenia.Name = "textBoxNrZdarzenia";
            this.textBoxNrZdarzenia.Size = new System.Drawing.Size(260, 20);
            this.textBoxNrZdarzenia.TabIndex = 4;
            this.textBoxNrZdarzenia.PlaceholderText = "Nr Zdarzenia";
            // 
            // buttonDalej
            // 
            this.buttonDalej.Location = new System.Drawing.Point(12, 142);
            this.buttonDalej.Name = "buttonDalej";
            this.buttonDalej.Size = new System.Drawing.Size(75, 23);
            this.buttonDalej.TabIndex = 5;
            this.buttonDalej.Text = "Dalej";
            this.buttonDalej.UseVisualStyleBackColor = true;
            this.buttonDalej.Click += new EventHandler(this.buttonDalej_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.buttonDalej);
            this.Controls.Add(this.textBoxNrZdarzenia);
            this.Controls.Add(this.textBoxCzas);
            this.Controls.Add(this.textBoxStawka);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxLiczbaRatownikow);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}