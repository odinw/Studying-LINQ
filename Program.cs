﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Studing_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //TakeWhile();
            //Distinct();
            Fail_Where_Set();
        }

        /// <summary>
        /// TakeWhile: 持續複製元素，直到指定條件為 true 就停止複製
        /// </summary>
        static void TakeWhile()
        {
            // reference: https://docs.microsoft.com/zh-tw/dotnet/api/system.linq.enumerable.takewhile?view=net-5.0
            string[] fruits = { "apple", "banana", "mango", "passionfruit", "orange", "grape" };

            // before
            fruits.ToList().ForEach(item => Console.WriteLine(item));
            Console.WriteLine();

            // after
            IEnumerable<string> query = fruits.TakeWhile(fruit => String.Compare("orange", fruit, true) != 0);
            query.ToList().ForEach(item => Console.WriteLine(item));
            Console.WriteLine();
            fruits.ToList().ForEach(item => Console.WriteLine(item));
        }

        static void Distinct()
        {
            IEnumerable<int> data = new int[] { 1, 1, 1, 2, 3};

            Console.WriteLine("before");
            data.ToList().ForEach(item => Console.WriteLine(item));

            Console.WriteLine("after");
            data.Distinct().ToList().ForEach(item => Console.WriteLine(item)); // 1, 2, 3
        }

        static void Fail_Where_Set()
        {
            List<int> data = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("before");
            data.ForEach(item => Console.WriteLine(item));

            var result = data.Where( item => 
            {
                if (item < 3)
                { 
                    item = 666;
                    return true;
                }
                return false;
            }).ToList();
            Console.WriteLine("after data");
            data.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("result");
            result.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("after data");
            data.ForEach(item => Console.WriteLine(item));
        }

        static void Set()
        {
            List<int> data = new List<int> { 1, 2, 3, 4, 5 };
            var result = data.ForEach(x => x += 1);
        }
    }
}
