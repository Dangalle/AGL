using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Domain
{
    public class PersonService : IAGLService<Person>
    {
        public List<Person> GetData()
        {
            string json = "";
            using (WebClient wc = new WebClient())
            {
                try
                {
                    json = wc.DownloadString("http://agl-developer-test.azurewebsites.net/people.json");
                }
                catch 
                {
                    throw new Exception();
                }
            }
            
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(json);

            return people;
        }
    }
}
