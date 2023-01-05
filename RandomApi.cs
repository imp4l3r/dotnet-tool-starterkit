using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;

public class RandomApi
{
    private const string BaseUri = "https://api.chucknorris.io";
    private const string RequestUri = "/jokes/random";

    public async Task CallApi()
    {
        System.Console.WriteLine("Chuck norris joke of the day");

        HttpClient client = new HttpClient();

        Uri RequestUriString = new Uri(BaseUri);
        client.BaseAddress = RequestUriString;

        var response = await client.GetAsync(RequestUri);

        RandomApiResponse result = JsonSerializer.Deserialize<RandomApiResponse>(await response.Content.ReadAsStringAsync());

        if (result == null)
        {
            System.Console.WriteLine("Sorry buddy, no more chuck norris jokes or facts");
            return;
        }

        System.Console.WriteLine($"response: {result.value}");
        System.Console.WriteLine($"id of response: {result.id}");
        System.Console.WriteLine($"url: {result.url}");
    }
}

