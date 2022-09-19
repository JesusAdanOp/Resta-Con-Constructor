using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resta_Con_Constructor
{
    internal class clresta
    {
        int v1, v2;

        public clresta(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int resta()
        {
            return v1-v2;
        }
    }
}
