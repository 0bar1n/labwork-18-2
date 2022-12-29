using System;

namespace labwork_18_2
{
    class Program
    {
        static void Main()
        {
            RevStr letter = new RevStr();//функция реверсии
            letter.DisplayRev("abc"); //задание строки
            Console.ReadLine(); //прорамма ждет нажатия клавиши для завершения работы
        }
    }
    class RevStr
    {

        public void DisplayRev(string str) 
        {
            if (str.Length > 0) //выполнять, пока в строке не останется символов
                DisplayRev(str.Substring(1, str.Length - 1)); //выполнить реверсию
            else//другой исход
                return;//повторить реверсию

            Console.WriteLine(str[0]); //вывод символов строки в обратном порядке
        }
    }
}
