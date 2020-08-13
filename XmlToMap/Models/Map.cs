using System.Collections.Generic;
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
     
    public class RootObject
    {
        [XmlElement("Location")]
        public List<Map> Location { get; set; }
    }
}