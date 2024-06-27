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
            textBoxLiczbaRatownikow = new TextBox();
            textBoxData = new TextBox();
            textBoxStawka = new TextBox();
            textBoxCzas = new TextBox();
            textBoxNrZdarzenia = new TextBox();
            buttonDalej = new Button();
            buttonCofnij = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxLiczbaRatownikow
            // 
            textBoxLiczbaRatownikow.Location = new Point(12, 12);
            textBoxLiczbaRatownikow.Name = "textBoxLiczbaRatownikow";
            textBoxLiczbaRatownikow.PlaceholderText = "Liczba Ratowników";
            textBoxLiczbaRatownikow.Size = new Size(260, 23);
            textBoxLiczbaRatownikow.TabIndex = 0;
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(12, 38);
            textBoxData.Name = "textBoxData";
            textBoxData.PlaceholderText = "Data";
            textBoxData.Size = new Size(260, 23);
            textBoxData.TabIndex = 1;
            // 
            // textBoxStawka
            // 
            textBoxStawka.Location = new Point(12, 64);
            textBoxStawka.Name = "textBoxStawka";
            textBoxStawka.PlaceholderText = "Stawka";
            textBoxStawka.Size = new Size(260, 23);
            textBoxStawka.TabIndex = 2;
            // 
            // textBoxCzas
            // 
            textBoxCzas.Location = new Point(12, 90);
            textBoxCzas.Name = "textBoxCzas";
            textBoxCzas.PlaceholderText = "Czas";
            textBoxCzas.Size = new Size(260, 23);
            textBoxCzas.TabIndex = 3;
            // 
            // textBoxNrZdarzenia
            // 
            textBoxNrZdarzenia.Location = new Point(12, 116);
            textBoxNrZdarzenia.Name = "textBoxNrZdarzenia";
            textBoxNrZdarzenia.PlaceholderText = "Nr Zdarzenia";
            textBoxNrZdarzenia.Size = new Size(260, 23);
            textBoxNrZdarzenia.TabIndex = 4;
            // 
            // buttonDalej
            // 
            buttonDalej.Location = new Point(12, 142);
            buttonDalej.Name = "buttonDalej";
            buttonDalej.Size = new Size(75, 23);
            buttonDalej.TabIndex = 5;
            buttonDalej.Text = "Dalej";
            buttonDalej.UseVisualStyleBackColor = true;
            buttonDalej.Click += buttonDalej_Click;
            // 
            // buttonCofnij
            // 
            buttonCofnij.Location = new Point(197, 140);
            buttonCofnij.Name = "buttonCofnij";
            buttonCofnij.Size = new Size(75, 23);
            buttonCofnij.TabIndex = 6;
            buttonCofnij.Text = "Cofnij";
            buttonCofnij.UseVisualStyleBackColor = true;
            buttonCofnij.Click += buttonCofnij_Click;
            // 
            // button1
            // 
            button1.Location = new Point(103, 142);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Lista Akcji";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(287, 175);
            Controls.Add(button1);
            Controls.Add(buttonCofnij);
            Controls.Add(buttonDalej);
            Controls.Add(textBoxNrZdarzenia);
            Controls.Add(textBoxCzas);
            Controls.Add(textBoxStawka);
            Controls.Add(textBoxData);
            Controls.Add(textBoxLiczbaRatownikow);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonCofnij;
        private Button button1;
    }
}