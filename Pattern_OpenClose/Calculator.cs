using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    /// <summary>
    /// Класс калькулятор
    /// Конструктор принимает объект аккаунт и интерфейс калькулятор
    /// </summary>
    public class Calculator
    {
       public Calculator(Account account, ICalculatorInterest calculator) 
        {
            calculator.Interest(account);

        }

   

    }
}
