using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Domain
{
    public class Repository : IRepository<Person>
    {
        private IAGLService<Person> service;

        public Repository(IAGLService<Person> service)
        {
            this.service = service;
        }

        public List<Person> GetData()
        {
            return service.GetData();
        }
    }
}
