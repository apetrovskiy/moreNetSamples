namespace StravaAccessSample
{
    using System.Net.Http;
    using System.Net.Http.Headers;

    public class DataLoader
    {
        public void GetActivities(string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var result = client.GetStringAsync("http://strava.com/api/v3/activities/23141?access_token=" + accessToken);
            int i = 1;
        }
    }
}
