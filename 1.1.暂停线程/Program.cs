﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Infrastructure;

namespace _1._1.暂停线程
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Common.PrintNumbersWithDelay);
            thread.Start();
            Common.PrintNumbers();
            Console.ReadKey();
        }

        
    }
}
