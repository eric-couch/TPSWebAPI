using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPSWebAPI;

public class OmdbApiClient
{
    private static readonly HttpClient _httpClient = new HttpClient();
    private const string apiKey = "86c39163";
    private const string baseURL = "https://www.omdbapi.com/";

    public async Task<OMDBMovie> GetMovieDataAsync(string title)
    {
        var requestURL = $"{baseURL}?apikey={apiKey}&t={title}";

        var movie = await _httpClient.GetFromJsonAsync<OMDBMovie>(requestURL);

        //HttpResponseMessage response = await _httpClient.GetAsync(requestURL);

        //response.EnsureSuccessStatusCode();

        //string responseBody = await response.Content.ReadAsStringAsync();

        //OMDBMovie movie = JsonSerializer.Deserialize<OMDBMovie>(responseBody);

        return movie;
    }
}
