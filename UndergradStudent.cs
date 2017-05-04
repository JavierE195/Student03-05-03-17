using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class UndergradStudent : Student
    {
        private int _credits;
        public int credits
        {
            get { return this._credits; }
            set { if (value <= 0)
                {
                    this._credits = 0;
                }
                else
                {
                    this._credits = value;
                } }
        }

        private string _major;
        public string major
        {
            get { return this._major; }
            set { this._major = value; }
        }


    }
}
