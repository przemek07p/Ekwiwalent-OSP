using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace bazy
{
    public partial class Form6 : Form
    {
        private string selectedTable;
        private string imieNazwisko;
        private string connectionString = "server=localhost;user=root;password=;database=Kwartalna;";

        public Form6(string selectedTable, string imieNazwisko)
        {
            InitializeComponent();
            this.selectedTable = selectedTable;
            this.imieNazwisko = imieNazwisko;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Zapytanie SQL, aby pobrać wszystkie wystąpienia imienia i nazwiska w tabeli selectedTable
                    string query = $"SELECT * FROM {selectedTable} WHERE `Imię i Nazwisko` = @ImieNazwisko";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ImieNazwisko", imieNazwisko);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Ustawienie źródła danych dla dataGridViewWystapienia
                    dataGridViewWystapienia.DataSource = dataTable;
                    int columnWidth = 200; // Ustaw szerokość kolumny na 200
                    foreach (DataGridViewColumn column in dataGridViewWystapienia.Columns)
                    {
                        column.Width = columnWidth;
                    }

                    // Automatyczne dopasowanie wysokości nagłówków kolumn
                    dataGridViewWystapienia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridViewWystapienia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDrukuj_Click(object sender, EventArgs e)
        {

        }
    }
}
