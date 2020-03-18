using System.Collections.Generic;

namespace MyRESTapi.Controllers
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Friend> Friends { get; set; }
    }
}
