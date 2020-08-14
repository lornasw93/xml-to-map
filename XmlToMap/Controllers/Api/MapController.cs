using System;
using System.IO;
using System.Linq;
using System.Web.Http;
using System.Xml.Serialization;
using CsvToMap.Models;

namespace XmlToMap.Controllers.Api
{
    public class MapController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var directory = new DirectoryInfo("C:\\Users\\lornn\\Documents\\XmlToMap");
                if (directory.Exists)
                {
                    var files = directory.GetFiles().FirstOrDefault(f => f.Name.Equals("Locations.xml"));
                    if (files != null)
                    {
                        var serializer = new XmlSerializer(typeof(RootObject), new XmlRootAttribute("Locations"));
                         
                        var fileData = File.ReadAllText(files.FullName);
                        var stringReader = new StringReader(fileData);
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
