using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface Observer
    {
        void update (Subject s, string tipo);
    }
}
