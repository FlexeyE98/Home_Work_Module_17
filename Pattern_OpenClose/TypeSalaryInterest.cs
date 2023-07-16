using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    /// <summary>
    /// Класс для подсчета процентной ставки - Зарплатный
    /// </summary>
    public class TypeSalaryInterest : ICalculatorInterest
    {
        public void Interest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
