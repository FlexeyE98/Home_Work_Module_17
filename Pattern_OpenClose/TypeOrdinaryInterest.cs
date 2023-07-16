using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    /// <summary>
    /// Класс для подсчета процентной ставки - Обычный
    /// Реализует интерфейс ICalculatorInterest, т.к возможно несколько реализаций для подсчета ставки
    /// </summary>
    public class TypeOrdinaryInterest : ICalculatorInterest
    {
        public void Interest(Account account)
        {
            if (account.Type == "Обычный")
            {

                account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;

                if (account.Balance >= 1000)
                    account.Interest -= account.Balance * 0.4;

            }
        }
    }
}
