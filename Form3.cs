using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
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
            PopulateComboBox();
        }

        private void InitializeGrid()
        {
            // Ustawienie kolumn w DataGridView
            dataGridView1.ColumnCount = 5; // 5 kolumn: Imię i Nazwisko, Nr Zdarzenia, Czas, Stawka, Data

            // Ustawienie pierwszej kolumny jako ComboBoxColumn
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.HeaderText = "Imię i Nazwisko";
            comboColumn.Name = "comboColumn";
            dataGridView1.Columns.Insert(0, comboColumn);

            dataGridView1.Columns[1].Name = "Nr Zdarzenia";
            dataGridView1.Columns[2].Name = "Czas";
            dataGridView1.Columns[3].Name = "Stawka";
            dataGridView1.Columns[4].Name = "Data";

            // Dodanie wierszy dla ratowników
            for (int i = 0; i < liczbaRatownikow; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[1].Value = nrZdarzenia;
                dataGridView1.Rows[i].Cells[2].Value = czas;
                dataGridView1.Rows[i].Cells[3].Value = stawka;
                dataGridView1.Rows[i].Cells[4].Value = data;
            }

            // Wypełnienie kolumny ComboBoxa tylko raz
            DataGridViewComboBoxCell comboCell;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                comboCell = (DataGridViewComboBoxCell)row.Cells["comboColumn"];
                if (comboCell.Items.Count == 0) // Sprawdź, czy nie ma już dodanych elementów
                {
                    // Pobierz imiona i nazwiska z bazy danych i dodaj do ComboBoxa
                }
            }

            // Ustawienie kolumn jako tylko do odczytu (ReadOnly)
            dataGridView1.Columns["Nr Zdarzenia"].ReadOnly = true;
            dataGridView1.Columns["Czas"].ReadOnly = true;
            dataGridView1.Columns["Stawka"].ReadOnly = true;
            dataGridView1.Columns["Data"].ReadOnly = true;
        }

        private void PopulateComboBox()
        {
            string connectionString = "server=localhost;user=root;password=;database=ratownicy;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT `Imie i Nazwisko` FROM ratownicy";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Pobieranie ComboBoxColumn z DataGridView
                    DataGridViewComboBoxColumn comboColumn = (DataGridViewComboBoxColumn)dataGridView1.Columns["comboColumn"];

                    // Dodanie pozycji do ComboBoxa w kolumnie
                    while (reader.Read())
                    {
                        string imieNazwisko = reader["Imie i Nazwisko"].ToString();
                        comboColumn.Items.Add(imieNazwisko);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

                        string imieNazwisko = row.Cells["comboColumn"].Value?.ToString();
                        string nrZdarzenia = row.Cells["Nr Zdarzenia"].Value?.ToString();
                        string czas = row.Cells["Czas"].Value?.ToString();
                        string stawka = row.Cells["Stawka"].Value?.ToString();
                        string data = row.Cells["Data"].Value?.ToString();

                        string insertQuery = @"
                            INSERT INTO " + selectedTable + " (`Imię i Nazwisko`, `Nr Zdarzenia`, `Czas`, `Stawka`, `Data`) " +
                            "VALUES (@ImięNazwisko, @NrZdarzenia, @Czas, @Stawka, @Data)";

                        MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                        cmd.Parameters.AddWithValue("@ImięNazwisko", imieNazwisko);
                        cmd.Parameters.AddWithValue("@NrZdarzenia", nrZdarzenia);
                        cmd.Parameters.AddWithValue("@Czas", czas);
                        cmd.Parameters.AddWithValue("@Stawka", stawka);
                        cmd.Parameters.AddWithValue("@Data", data);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dodano Zdarzenie");
                    
                }
                Form2 form2 = new Form2(selectedTable);
                form2.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
    }
}
