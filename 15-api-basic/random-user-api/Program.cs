namespace random_user_api_httpclient;
class Program
{
    public static async Task Main(string[] args)
    {
        using HttpClient client = new();
        client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

        try
        {
            HttpResponseMessage response = await client.GetAsync("posts/1");
            
            // Console.WriteLine("Headers         : " + response.Headers);
            // Console.WriteLine("StatusCode      : " + response.StatusCode);
            // Console.WriteLine("ReasonPhrase    : " + response.ReasonPhrase);
            // Console.WriteLine("TrailingHeaders : " + response.TrailingHeaders);
            // Console.WriteLine("IsSucces        : " + response.IsSuccessStatusCode);
            // Console.WriteLine("Version         : " + response.Version);
            
            response.EnsureSuccessStatusCode();
            string jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine(jsonResponse);
        } catch (HttpRequestException e)
        {
            Console.WriteLine($"Message: {e.Message}");
        }
        
    }
}