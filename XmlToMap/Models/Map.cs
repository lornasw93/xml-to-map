using System.Xml.Serialization;

namespace XmlToMap.Models
{ 
    public class Map
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Latitude")]
        public double Latitude { get; set; }

        [XmlAttribute("Longitude")]
        public double Longitude { get; set; }
    }
}