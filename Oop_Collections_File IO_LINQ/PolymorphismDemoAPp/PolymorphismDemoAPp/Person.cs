using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoApp
{
    internal class Person
    {
        private int _id;
        private string _name;

        public int Id { 
            get 
            { 
                return _id; 
            } 
            set 
            { 
                if(value <= 0)
                {
                    throw new ArgumentException("Id must be grater than 0");
                }
                _id = value;
            } 
        }

        public string Name
        {
            get
            { 
                return _name; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null, empty or whotespaces!!");
                }
                _name = value;
            }
        }

    }
}
