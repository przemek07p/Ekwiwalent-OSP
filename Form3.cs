using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bazy
{
    public partial class Form3 : Form
    {
        private string selectedTable;
        private int liczbaRatownikow;
        private string data;
        private string stawka;
        private string czas;
        private string nrZdarzenia;

        public Form3(string selectedTable, int liczbaRatownikow, string data, string stawka, string czas, string nrZdarzenia)
        {
            InitializeComponent();
            this.selectedTable = selectedTable;
            this.liczbaRatownikow = liczbaRatownikow;
            this.data = data;
            this.stawka = stawka;
            this.czas = czas;
            this.nrZdarzenia = nrZdarzenia;
            InitializeGrid();
        }


        private void InitializeGrid()
        {
            // Kolumny: Imię i Nazwisko, Czas, Stawka, Data, Nr Zdarzenia
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Imię i Nazwisko";
            dataGridView1.Columns[1].Name = "Czas";
            dataGridView1.Columns[2].Name = "Stawka";
            dataGridView1.Columns[3].Name = "Data";
            dataGridView1.Columns[4].Name = "Nr Zdarzenia";

            // Dodanie wierszy dla ratowników
            for (int i = 0; i < liczbaRatownikow; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[1].Value = czas;
                dataGridView1.Rows[i].Cells[2].Value = stawka;
                dataGridView1.Rows[i].Cells[3].Value = data;
                dataGridView1.Rows[i].Cells[4].Value = nrZdarzenia;
            }
        }




        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=;database=Kwartalna;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string imieNazwisko = row.Cells[0].Value?.ToString();
                        string czas = row.Cells[1].Value?.ToString();
                        string stawka = row.Cells[2].Value?.ToString();
                        string data = row.Cells[3].Value?.ToString();
                        string nrZdarzenia = row.Cells[4].Value?.ToString();

                        string insertQuery = $@"
                    INSERT INTO {selectedTable} (`Imię i Nazwisko`, Czas, Stawka, Data, NrZdarzenia)
                    VALUES (@ImięNazwisko, @Czas, @Stawka, @Data, @NrZdarzenia);";

                        MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                        cmd.Parameters.AddWithValue("@ImięNazwisko", imieNazwisko);
                        cmd.Parameters.AddWithValue("@Czas", czas);
                        cmd.Parameters.AddWithValue("@Stawka", stawka);
                        cmd.Parameters.AddWithValue("@Data", data);
                        cmd.Parameters.AddWithValue("@NrZdarzenia", nrZdarzenia);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}