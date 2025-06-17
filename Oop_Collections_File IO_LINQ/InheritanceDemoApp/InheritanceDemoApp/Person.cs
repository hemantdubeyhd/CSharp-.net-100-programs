using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemoApp
{
    internal class Person
    {
        private int _id;
        public int Id 
        {
            
            get => _id;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Id must be greater than 0");
                }
            }
        }
        public string name { get; set; }
    }
}
