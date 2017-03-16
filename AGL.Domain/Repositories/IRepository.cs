using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Domain
{
    public interface IRepository<T>
    {
        List<T> GetData();
    }
}
