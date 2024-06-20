public void GetAllUsers()
{
    using (var conn = new NpgsqlConnection(connString))
    {
        conn.Open();
        using (var cmd = new NpgsqlCommand("SELECT * FROM Users", conn))
        using (var reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["FirstName"]} {reader["LastName"]}, Email: {reader["Email"]}");
            }
        }
    }
}
