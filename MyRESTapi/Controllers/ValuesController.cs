using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MyRESTapi.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public string result { get; set; }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            //var a = new string[] { "value1", "value2" }; //default example

            Friend friend1 = new Friend
            {
                Name = "Teyyub",
                Surname = "Cəfərli"
            };
            Friend friend2 = new Friend
            {
                Name = "Kamal",
                Surname = "Quliyev"
            };

            Person person = new Person
            {
                Name = "Sahib",
                Surname = "Zülfüqarlı",
                Friends = new List<Friend> { friend1, friend2 }
            };

            Person person2 = new Person
            {
                Name = "X",
                Surname = "Man"
            };

            //sahib.Dostlar.Add(dost1); //error
            //sahib.Dostlar.Add(dost2); //error

            return JsonConvert.SerializeObject(person) + "\r\n" + JsonConvert.SerializeObject(person2); //when return value is ActionResult<object> or ActionResult<string>
            //return person; //when return value is ActionResult<object>

            #region XML Converter
            //XmlSerializer xsSubmit = new XmlSerializer(typeof(Person));
            //var xml = "";

            //using (var sww = new StringWriter())
            //{
            //    using (XmlWriter writer = XmlWriter.Create(sww))
            //    {
            //        xsSubmit.Serialize(writer, person);
            //        xml = sww.ToString(); // Your XML
            //    }
            //}
            #endregion

            //return xml;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            //return "value";
            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            result = value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
