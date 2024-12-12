using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static ConsoleHome.Enums;

namespace ConsoleHome
{
    public class Position
    {
        public Position()
        {
            Timer timer = new Timer();

            timer.Interval = 1000;

            timer.Elapsed += NewTrade;

            timer.Start();
        }

        Random random = new Random();

        //===============================================  Methods  =======================================

        #region Methods
        private void NewTrade(object sender, ElapsedEventArgs e)
        {
            Trade trade = new Trade();

            Side Side = Side.None;

            int num = random.Next(-10, 10); 

            if (num > 0)
            {
                Side = Side.Buy;
            }
            else if (num < 0)
            {
                Side = Side.Sell;
            }

            trade.Volume = Math.Abs(num);

            trade.Price = random.Next(70000, 80000);

            int number = EventNewPositionSize();

            string str = "Volume: " + trade.Volume.ToString() + " Price: " + trade.Price.ToString() + " Side: " + Side.ToString() + " NewPositionSize: " + number.ToString();

            Console.WriteLine(str);

            EventChangingPosition();

            Console.WriteLine();
        }

        #endregion

        //=============================================== Delegates ===================================

        #region Delegates

        public delegate void ChangingPosition();

        public delegate int NewPositionSize();

        #endregion

        //=============================================== Events =======================================

        #region Events

        public event NewPositionSize EventNewPositionSize;

        public event ChangingPosition EventChangingPosition;

        #endregion
    }
}
