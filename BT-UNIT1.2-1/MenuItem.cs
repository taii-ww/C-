using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_UNIT1._2_1
{
    internal class MenuItem
    {
        protected String name;
        public MenuItem(String name)
        {
            this.name = name;
        }
        public virtual void printToScreen()
        { }

    }
}
