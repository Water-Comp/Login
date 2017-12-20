using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class node
    {

        public string name;
        public string parent;
        public node(string Parent ="", string Name = "")
        {
            parent = Parent;
            name = Name;
        }
        public void ChangeValues(string Parent = "", string Name = "")
        {
            parent = Parent;
            name = Name;
        }
    }
}
