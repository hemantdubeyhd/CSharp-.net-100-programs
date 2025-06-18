using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemoApp
{
    internal class Admin
    {
        private string _department;

        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null, empty or whotespaces!!");
                }
                _department = value;
            }
        }
    }
}
