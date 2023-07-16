using System.Net.Http.Headers;

namespace HomeWork17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 1) Создаем счет
            /// 2) Создаем калькулятор для подсчета процентной ставки.
            /// Конструктор принимает 2 объекта: первый - сам счет, второй - интерфейс необходимой нам реализации. 
            /// P.S Логика расчета помещена в конкретной реализации интерфейса чтобы не засорять испольняемый метод Main
            ///3) Аналогично п.2 только для типа счета - Зарплатый
            ///
            /// Надеюсь верно понял работу паттерна Open/close
            ///
            /// </summary>

            var account = new Account { Type = "Обычный", Balance = 100000, Interest = 2};
            var ordinary = new Calculator(account, new TypeOrdinaryInterest());
            var salary = new Calculator(account, new TypeSalaryInterest());

        }
    }
}