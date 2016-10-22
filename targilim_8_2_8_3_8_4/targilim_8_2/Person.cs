using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_8_2
{
    public class Person:IPrintable
    {
        int _id;
        string _firstName;
        string _lastName;
        Children _children;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public Person(int id, string first, string last)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            _children = new Children();
            

        }
        public override bool Equals(object obj)
        {
            Person person = (Person)obj;
            if (person.Id == this.Id) return true;
            return false;
        }

        public override string ToString()
        {
            return String.Format("First name: {0} Last name: {1} ID: {2}",FirstName,LastName,Id) ;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public void AddChild(string name, int age)
        {
            _children.AddChild(name, age);
        }

        public string GetChildrenDetails()
        {
            return _children.ToString();
        }

        class Children
        {
            List<Child> _personChildren;

            private List<Child> PersonChildren
            {
                get
                {
                    return _personChildren;
                }

                set
                {
                    _personChildren = value;
                }
            }

            struct Child
            {
                string _name;
                int _age;

                internal string Name
                {
                    get
                    {
                        return _name;
                    }

                    set
                    {
                        _name = value;
                    }
                }

                internal int Age
                {
                    get
                    {
                        return _age;
                    }

                    set
                    {
                        _age = value;
                    }
                }

                internal Child(string name, int age)
                {
                    _name = name;
                    _age = age;
                }
            }

            public Children()
            {
                PersonChildren = new List<Child>();
            }

            internal void AddChild(string name, int age)
            {
                PersonChildren.Add(new Child(name, age));
            }

            internal int ChildrenCount()
            {
                return PersonChildren.Count();












































































            }
            public override string ToString()
            {
                string s = "Children names:\r\n";
                foreach (Child child in PersonChildren)
                {
                    s += String.Format("Name: {0}, Age: {1}\r\n", child.Name, child.Age);
                }
                return s;
            }
        }
    }
}
