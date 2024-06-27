using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace bazy
{
    public partial class Form5 : Form
    {
        private string selectedTable;
        private string connectionString = "server=localhost;user=root;password=;database=Kwartalna;";

        public Form5(string selectedTable)
        {
            InitializeComponent();
            this.selectedTable = selectedTable;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie SQL, aby pobrać unikalne osoby z tabeli selectedTable
                    string query = $"SELECT DISTINCT `Imię i Nazwisko` FROM {selectedTable}";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Ustawienie źródła danych dla dataGridViewOsoby
                    dataGridViewOsoby.DataSource = dataTable;

                    int columnWidth = 200; // Ustaw szerokość kolumny na 200
                    foreach (DataGridViewColumn column in dataGridViewOsoby.Columns)
                    {
                        column.Width = columnWidth;
                    }

                    // Automatyczne dopasowanie wysokości nagłówków kolumn
                    dataGridViewOsoby.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridViewOsoby_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sprawdź, czy kliknięto na komórkę (a nie nagłówek kolumny)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOsoby.Rows[e.RowIndex];
                string imieNazwisko = row.Cells["Imię i Nazwisko"].Value.ToString();

                // Otwórz Form6 i przekaż imię i nazwisko do konstruktora
                Form6 form6 = new Form6(selectedTable, imieNazwisko);
                form6.ShowDialog(); // ShowDialog blokuje interakcję z Form5, aż do zamknięcia Form6
            }
        }
    }
}
