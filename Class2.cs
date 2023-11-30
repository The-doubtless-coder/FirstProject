using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Class2
    {
        public int name { get; set; }
        public int school { get; set; }
        public int kitchen { get; set; }
        public int wear { get; set; }

        public int ReturnSomeThings()
        {
            return name + school + kitchen + wear;
        }
    }
}
