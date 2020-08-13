using System;
using System.IO;
using System.Linq;
using System.Web.Http;
using System.Xml.Serialization;
using XmlToMap.Models;

namespace XmlToMap.Controllers
{
    [Route("api/Map")]
    public class MapController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var directory = new DirectoryInfo("C:\\Users\\lornn\\Documents\\CsvToMap");
                if (directory.Exists)
                {
                    var files = directory.GetFiles().FirstOrDefault(f => f.Name.Equals("Locations.xml"));
                    if (files != null)
                    {
                        var file = files.FullName;
                        var json = File.ReadAllText(file);

                        var serializer = new XmlSerializer(typeof(RootObject), new XmlRootAttribute("Locations"));
                        var stringReader = new StringReader(json);
                        var productList = serializer.Deserialize(stringReader);

                        return Ok(productList);
                    }

                    return NotFound();
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
