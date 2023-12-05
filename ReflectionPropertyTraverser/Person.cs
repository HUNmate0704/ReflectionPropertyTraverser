using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPropertyTraverser
{
    internal class Person : IComparable<Person>
    {

        public string Name { get; }
        public int Age { get; }
        public bool IsMan { get; private set; }
        public Person(string name, int age, bool isMan)
        {
            Name = name;
            Age = age;
            IsMan = isMan;
        }

        public void ChangeIsMan()
        {
            IsMan = !IsMan;
        }

        public int Highest<T>()
        {
            if (Name.Length > Age)
            {
                return Name.Length;
            }
            else
            {
                return Age;
            }
        }

        public int CompareTo(Person other)
        {
            if (Age > other.Age)
            {
                return 1;
            }
            else if (Age < other.Age)
            {
                return -1;
            }
            else
            {
                if (IsMan)
                {
                    return -1;
                }
                else if (other.IsMan)
                {
                    return 1;
                }


                return 0;
            }
        }
    }
}
