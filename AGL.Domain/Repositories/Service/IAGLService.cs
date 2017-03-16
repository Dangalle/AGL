using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Domain
{
    public interface IAGLService<T>
    {
        List<T> GetData();
    }
}
