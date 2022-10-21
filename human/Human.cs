using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace human
{
    abstract class Human
    {
        protected string _name;
        protected string _surname;

        public virtual void Work()
        {

        }
        public abstract void ChangeWork();
    }
}
