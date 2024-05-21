
internal class Program
{
    private static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();

        HttpResponseMessage response =
          await client.GetAsync("http://www.onet.pl/");

        WriteLine("Apple's home page has {0:N0} bytes.",
          response.Content.Headers.ContentLength);
    }
}