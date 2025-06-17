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
        private string _name;
        public int Id 
        {
            
            get => _id;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Id must be greater than 0");
                }
                _id= value;
            }
        }
        public string Name 
        { 
            get => _name;
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
                _name= value;
            }
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id: {_id}, Name: {_name}");
        }
    }
}
