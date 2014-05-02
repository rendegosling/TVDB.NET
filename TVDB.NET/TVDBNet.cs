using System;
using System.Collections.Generic;
using System.Net;
using System.Xml.Linq;

namespace TVDB.NET
{
    public class TVDBNet
    {
        
        private const string BaseUrl = "http://thetvdb.com";
        private TVDBSerializer _serializer ;
        public TVDBNet(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey)) throw new ArgumentException("Valid thetvdb.com Api Key expected!");

            ApiKey = apiKey;
            _serializer = new TVDBSerializer();
        }


        public string ApiKey { get; set; }


        public IEnumerable<Series> Search(string show)
        {
            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(string.Format("{0}/api/GetSeries.php?seriesname={1}", BaseUrl, show));
                return _serializer.Deserialize(response);
            }
        }

        private XDocument GetShow(int id)
        {
            throw new NotImplementedException();
        }
    }
}
