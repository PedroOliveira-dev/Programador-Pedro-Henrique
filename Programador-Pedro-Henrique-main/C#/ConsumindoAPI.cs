using System.Net.Http;
using System.Threading.Tasks;

public async Task<string> GetRandomUserAsync()
{
    using (var client = new HttpClient())
    {
        var response = await client.GetStringAsync("https://randomuser.me/api/");
        return response;
    }
}
