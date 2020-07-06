﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IfElseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                if (number < 0)
                    Console.WriteLine($"{number}은(는) 음수");
                else if (number > 0)
                    Console.WriteLine($"{number}은(는) 양수");
                else
                    Console.WriteLine($"{number}은(는) 0");

                if (number % 2 == 0)
                    Console.WriteLine($"{number}은(는) 짝수");
                else
                    Console.WriteLine($"{number}은(는) 홀수");
            }
            else
            {
                Console.WriteLine("입력값이 숫자가 아닙니다.");
                return;
            }
        }
    }
}
