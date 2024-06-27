using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bazy
{
    public partial class Form2 : Form
    {
        private string selectedTable;

        public Form2(string selectedTable)
        {
            InitializeComponent();
            this.selectedTable = selectedTable;
        }

        private void buttonDalej_Click(object sender, EventArgs e)
        {
            int liczbaRatownikow;
            if (!int.TryParse(textBoxLiczbaRatownikow.Text, out liczbaRatownikow) || liczbaRatownikow <= 0)
            {
                MessageBox.Show("Wpisz Liczbę ratowników.");
                return;
            }

            string data = textBoxData.Text;
            string stawka = textBoxStawka.Text;
            string czas = textBoxCzas.Text;
            string nrZdarzenia = textBoxNrZdarzenia.Text;

            Form3 form3 = new Form3(selectedTable, liczbaRatownikow, data, stawka, czas, nrZdarzenia);
            form3.Show();
            this.Hide();
        }

        private void buttonCofnij_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(selectedTable);
            form5.Show();
            this.Hide();
        }
    }
}