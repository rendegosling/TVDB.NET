using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace TVDB.NET
{
    public class TVDBSerializer
    {
        public IEnumerable<Series> Deserialize(string xml)
        {
            XDocument doc = XDocument.Parse(xml);

            IEnumerable<XElement> nodes = (from node in doc.Descendants("Series")
                                            select node);

            return nodes.Select(node => new Series()
            {
                Id = node.GetElementValue("id"), 
                SeriesName = node.GetElementValue("SeriesName"), 
                Banner = node.GetElementValue("banner"), 
                FirstAired = node.GetElementValue("FirstAired"), 
                ImdbId = node.GetElementValue("IMDB_ID"), 
                Language = node.GetElementValue("language"), 
                Network = node.GetElementValue("Network"), 
                Overview = node.GetElementValue("Overview")
            }).ToList();
        }
    }


}
