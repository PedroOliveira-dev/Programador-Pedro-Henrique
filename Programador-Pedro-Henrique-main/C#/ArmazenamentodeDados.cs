using Newtonsoft.Json.Linq;

public async Task StoreRandomUserAsync()
{
    var json = await GetRandomUserAsync();
    var user = JObject.Parse(json)["results"][0];

    using (var conn = new NpgsqlConnection(connString))
    {
        conn.Open();

        using (var cmd = new NpgsqlCommand())
        {
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Users (FirstName, LastName, Email, Username, Gender, DateOfBirth, Country) VALUES (@FirstName, @LastName, @Email, @Username, @Gender, @DateOfBirth, @Country)";
            cmd.Parameters.AddWithValue("FirstName", user["name"]["first"].ToString());
            cmd.Parameters.AddWithValue("LastName", user["name"]["last"].ToString());
            cmd.Parameters.AddWithValue("Email", user["email"].ToString());
            cmd.Parameters.AddWithValue("Username", user["login"]["username"].ToString());
            cmd.Parameters.AddWithValue("Gender", user["gender"].ToString());
            cmd.Parameters.AddWithValue("DateOfBirth", DateTime.Parse(user["dob"]["date"].ToString()));
            cmd.Parameters.AddWithValue("Country", user["location"]["country"].ToString());
            cmd.ExecuteNonQuery();
        }
    }
}
