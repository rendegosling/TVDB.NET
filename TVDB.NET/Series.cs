using RestSharp.Deserializers;

namespace TVDB.NET
{
    public class Series
    {

        public string Id { get; set; }
        public string Language { get; set; }
        public string Banner { get; set; }
        public string Overview { get; set; }
        public string FirstAired { get; set; }
        public string Network { get; set; }
        public string ImdbId { get; set; }
        public string SeriesName { get; set; }
        public string SeriesId { get; set; }
        public string Zap2ItId { get; set; }
    }
}
