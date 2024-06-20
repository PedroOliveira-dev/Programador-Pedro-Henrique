public class Log
{
    public ObjectId Id { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }
}

public class LogService
{
    private readonly IMongoCollection<Log> _logs;

    public LogService()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("logdb");
        _logs = database.GetCollection<Log>("logs");
    }

    public void LogAccess(string message)
    {
        var log = new Log
        {
            Message = message,
            Timestamp = DateTime.UtcNow
        };
        _logs.InsertOne(log);
    }
}
