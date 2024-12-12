using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleHome.Enums;

namespace ConsoleHome
{
    public class Trade
    {

        //=============================================== Fields =========================================

        #region Fields

        /// <summary>
        /// Код инструмента 
        /// </summary>
        public string SecurityNameCode;

        /// <summary>
        /// Номер транзакции 
        /// </summary>
        public string Id;

        /// <summary>
        /// Объем
        /// </summary>
        public decimal Volume;

        /// <summary>
        /// Цена сделки
        /// </summary>
        public decimal Price;

        /// <summary>
        /// Время заключения сделки
        /// </summary>
        public DateTime Time;

        #endregion

        //=============================================== Enums =========================================

        #region Enums

        /// <summary>
        /// Направление транзакции
        /// </summary>
        public Side Side;

        #endregion
    }
}
