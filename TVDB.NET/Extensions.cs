using System.Xml.Linq;

namespace TVDB.NET
{
    public static class Extensions
    {
        public static string GetElementValue(this XElement xmlObject, string element)
        {
            var result = xmlObject.Element(element);

            return result != null ? result.Value : null;
        }
    }
}
