using System;

namespace Kentro
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid grid = new Grid( 9 );
            Console.WriteLine(grid.getCard(1,1, PlayerEnum.Player1).value);
        }     
    }
}
