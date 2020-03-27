using System;
using CodingCampusCSharpHomework;
using System.Globalization;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                char decorSign = task.DecorativeSign;
                int padding = Task2.Padding / 2;
                string decorats = new string(decorSign, padding);
                string spaces = new string(' ', padding);

                NumberFormatInfo info = new NumberFormatInfo();
                info.CurrencySymbol = "$";
                string balance = task.Balance.ToString("C2", info);

                return string.Format("{0}{1}{2}{1}{0}", decorats, spaces, balance);
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
