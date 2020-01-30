using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentro
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid( 9 );
            Console.WriteLine(grid.getCard(1,1,PlayerEnum.Player1).value);


        }

        
    }
}
