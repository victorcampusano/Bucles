using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    public class Varios
    {

        public void tablaMultiplicar(int x, int lim)
        {
            for (int i = 1; i <= lim; i++)
            {
                int r = x * i;
                Console.WriteLine(String.Format("{0} x {1} = {2}",x,i,r));
            }
        }


    }
}
