using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroLibrary
{
    public interface IRequest
    {
        string DoRequest(string url);

    }
}
