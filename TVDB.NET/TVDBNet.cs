using System;
using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;
using RestSharp;

namespace TVDB.NET
{
    public class TVDBNet
    {
        
        private const string BaseUrl = "http://thetvdb.com";
        public TVDBNet(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey)) throw new ArgumentException("Valid thetvdb.com Api Key expected!");

            ApiKey = apiKey;
        }


        public string ApiKey { get; set; }


        public IEnumerable<Series> GetSeries(string seriesName)
        {
            var client = new RestClient(BaseUrl);
            var request = new RestRequest("api/GetSeries.php", Method.GET);
            request.AddParameter("seriesname", seriesName);
            var response = client.Execute<List<Series>>(request);
            return response.Data;
        }
    }
}
