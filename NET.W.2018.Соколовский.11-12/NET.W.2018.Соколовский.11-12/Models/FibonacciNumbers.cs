﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Соколовский._11_12.Models
{
    public class FibonacciNumbers
    {
        /// <summary>
        /// Get numbers from Fibonacci sequence.
        /// </summary>
        /// <param name="count"> Count of numbers. </param>
        /// <returns></returns>
        public static IEnumerable<int> GetNumbers(int count)
        {
            if (count < 1)
            {
                throw new ArgumentException(nameof(count));
            }

            int current = 1;
            yield return current;
            int prev = 0;
            
            for (int i = 0; i < count - 1; i++)
            {                
                current = current + prev;
                prev = current - prev;
                yield return current;
            }
        }
    }
}
