using MySql.Data.MySqlClient;

namespace SportFacilitiesMap
{
    internal class Facility
    {
        internal double Latitude { get; set; }
        internal double Longtitude { get; set; }
        internal string? Name { get; set; }
        internal int Id { get; set; }
        internal string? Type { get; set; }
        internal string? Address { get; set; }
        internal string? Work_hours { get; set; }
        internal int Likes { get; set; }
        internal int Dislikes { get; set; }
        internal string? Photo { get; set; }
        internal string? Name_lower { get; set; }

        internal Facility(int id)
        {
            Id = id;
            Connection.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM facilities WHERE id = @id", Connection.getConnection());
            command.Parameters.AddWithValue("@id", id);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                Latitude = Convert.ToDouble(reader["latitude"]);
                Longtitude = Convert.ToDouble(reader["longtitude"]);
                Name = reader["name"].ToString();
                Type = reader["type"].ToString();
                Address = reader["address"].ToString();
                Work_hours = reader["work_hours"].ToString();
                Likes = Convert.ToInt32(reader["likes"]);
                Dislikes = Convert.ToInt32(reader["dislikes"]);
                Photo = reader["photo"].ToString();
                Name_lower = reader["name_lower"].ToString();
            }
            Connection.closeConnection();
        }

        internal Facility(string name_lower)
        {
            Name_lower = name_lower;
            Connection.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM facilities WHERE name_lower = @name_lower", Connection.getConnection());
            command.Parameters.AddWithValue("@name_lower", name_lower);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                Latitude = Convert.ToDouble(reader["latitude"]);
                Longtitude = Convert.ToDouble(reader["longtitude"]);
                Name = reader["name"].ToString();
                Type = reader["type"].ToString();
                Address = reader["address"].ToString();
                Work_hours = reader["work_hours"].ToString();
                Likes = Convert.ToInt32(reader["likes"]);
                Dislikes = Convert.ToInt32(reader["dislikes"]);
                Photo = reader["photo"].ToString();
                Id = Convert.ToInt32(reader["id"]);
            }
            Connection.closeConnection();
        }
    }
}
