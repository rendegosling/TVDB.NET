using System;
using System.Collections.Generic;
using RestSharp;

namespace TVDB.NET
{
    public class TVDBNet
    {
        private RestClient _client;


        private const string BaseUrl = "http://thetvdb.com/api/";
        public TVDBNet(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey)) throw new ArgumentException("Valid thetvdb.com Api Key expected!");

            ApiKey = apiKey;

            _client = new RestClient(BaseUrl);

            GetServerTime();
            GetMirrors();
        }


        public string ApiKey { get; set; }


        public IEnumerable<Series> GetSeries(string seriesName)
        {
            var request = new RestRequest("GetSeries.php", Method.GET);
            request.AddParameter("seriesname", seriesName);
            var response = _client.Execute<List<Series>>(request);
            return response.Data;
        }

        private void GetMirrors()
        {
            var requestString = string.Format("{0}/mirrors.xml", ApiKey);
            var request = new RestRequest(requestString, Method.GET);
            var response = _client.Execute<List<Mirror>>(request);

            Mirrors = response.Data;
        }

        private void GetServerTime()
        {
            var request = new RestRequest("Updates.php", Method.GET);
            request.AddParameter("type", "none");
            var response = _client.Execute<TvDbServerTime>(request);
            ServerTime = response.Data.GetTime();
        }

        public DateTime ServerTime { get; set; }
        public IEnumerable<Mirror> Mirrors { get; set; }
    }

    public class TvDbServerTime
    {
        public double Time { get; set; }

        public DateTime GetTime()
        {
            var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(Time);
        }
    }
}
