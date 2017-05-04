using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Student
    {
        private string _name;
        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        private double _gpa;
        public double gpa
        {
            get { return this._gpa; }
            set
            {
                if (value >= 4.0)
                {
                    _gpa = 4;
                }
                else if (value <= 0.0)
                {
                    _gpa = 0;
                }
                else
                {
                    this._gpa = value;
                }
            }
        }
    
    }
}
