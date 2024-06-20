[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly string connString = "Host=myserver;Username=mylogin;Password=mypass;Database=mydatabase";

    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = new List<User>();
        using (var conn = new NpgsqlConnection(connString))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand("SELECT * FROM Users", conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Username = reader["Username"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString()),
                        Country = reader["Country"].ToString()
                    });
                }
            }
        }
        return Ok(users);
    }
}
