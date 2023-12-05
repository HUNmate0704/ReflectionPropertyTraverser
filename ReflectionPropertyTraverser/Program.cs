using System;
using System.Collections.Generic;

namespace ReflectionPropertyTraverser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime now = DateTime.Now;
            //Traverser(now);

            List<DateTime> dates = new List<DateTime>()
            {
                DateTime.Now.AddYears(1),
                DateTime.Now.AddYears(2),
                DateTime.Now.AddYears(3),
            };

            CollectionTraverser(dates);

        }

        static void Traverser(object o)
        {
            Type t = o.GetType();
            var props = t.GetProperties();
            foreach (var item in props)
            {
                Console.WriteLine(item.Name + " : " + item.GetValue(o));
            }

        }

        static void CollectionTraverser<T>(IEnumerable<T> collection)
        {
            Type t = typeof(T);
            foreach (var item in t.GetProperties())
            {
                Console.Write(item.Name.Length > 7 ? item.Name.Substring(0,7) : item.Name + "\t");

            }
            Console.WriteLine();
            foreach (var item in collection)
            {
                foreach (var prop in t.GetProperties())
                {
                    if (prop.GetValue(item).ToString().Length > 7)
                    {
                        Console.Write(prop.GetValue(item).ToString().Substring(0,7) + "\t");
                    }
                    else
                    {
                        Console.Write(prop.GetValue(item) + "\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
