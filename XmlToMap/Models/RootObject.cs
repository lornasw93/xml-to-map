using System.Collections.Generic;
using System.Xml.Serialization;
using XmlToMap.Models;

namespace CsvToMap.Models
{
    public class RootObject
    {
        [XmlElement("Location")]
        public List<Map> Location { get; set; }
    }
}