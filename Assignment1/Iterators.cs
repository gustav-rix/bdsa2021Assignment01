using System;
using System.Collections.Generic;

namespace Assignment1
{
    public static class Iterators
    {
        
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            List<T> list = new List<T>();
            foreach (var item in items)
            {
                list.AddRange(item);
            }
            return list;
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            List<T> list = new List<T>();
            foreach (var item in items)
            {
                list.Add(item);
            }
            
            List<T> newList = list.FindAll(predicate);
            return newList;
        }

        public static bool Even(int i)
        {
            return i % 2 == 0;
        }
    }
}
