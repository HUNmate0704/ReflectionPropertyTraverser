using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPropertyTraverser
{
    internal class Person
    {
        
        public string Name { get;}
        public int Age { get;}
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
    }
}
