using MySql.Data.MySqlClient;

namespace SportFacilitiesMap
{
    internal class Connection
    {
        internal static MySqlConnection connection = new MySqlConnection(Config.connectionString);

        internal static void openConnection() { try { connection.Open(); } catch (Exception ex) { MessageBox.Show("Ошибка: " + ex.Message); } }
        internal static void closeConnection() { try { connection.Close(); } catch (Exception ex) { MessageBox.Show("Ошибка: " + ex.Message); } }
        internal static MySqlConnection getConnection() { return connection; }
    }
}
