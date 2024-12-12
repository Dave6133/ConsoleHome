using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position();

            position.EventChangingPosition += ChangingPosition;

            position.EventNewPositionSize += NewPositionSize;

            Console.ReadLine();
        }

        //===============================================  Methods  =======================================

        #region Methods
        static void ChangingPosition()
        {
            Console.WriteLine("Позиция изменилась");
        }

        static int NewPositionSize()
        {

            Random random = new Random();

            return random.Next(1, 10);

        }
        #endregion
    }
}
