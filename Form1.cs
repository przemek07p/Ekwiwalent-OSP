using MySql.Data.MySqlClient;

namespace bazy
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=Kwartalna;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void LoadTables()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("SHOW TABLES;", connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listBoxTables.Items.Clear();
                    comboBoxTables.Items.Clear();
                    while (reader.Read())
                    {
                        listBoxTables.Items.Add(reader[0].ToString());
                        comboBoxTables.Items.Add(reader[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            string tableName = textBoxTableName.Text;

            if (string.IsNullOrWhiteSpace(tableName))
            {
                MessageBox.Show("Please enter a table name.");
                return;
            }

            string createTableQuery = $@"
                CREATE TABLE `{tableName}` (
                    `id` INT AUTO_INCREMENT PRIMARY KEY,
                    `Imiê i Nazwisko` VARCHAR(255),
                    `Czas` TIME,
                    `Stawka` DECIMAL(10,2),
                    `Data` DATE,
                    `NrZdarzenia` INT
                );";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(createTableQuery, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Table '{tableName}' created successfully.");
                    LoadTables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {
            string tableName = listBoxTables.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(tableName))
            {
                MessageBox.Show("Please select a table to delete.");
                return;
            }

            string dropTableQuery = $"DROP TABLE `{tableName}`;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(dropTableQuery, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Table '{tableName}' deleted successfully.");
                    LoadTables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBoxTables.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedTable))
            {
                MessageBox.Show("Please select a table.");
                return;
            }

            Form2 form2 = new Form2(selectedTable);
            form2.Show();
            this.Hide();
        }
    }
}