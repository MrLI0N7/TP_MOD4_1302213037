using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302213037
{
    internal class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("Halo user " + x);
        }
    }
}
