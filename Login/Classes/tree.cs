using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Login
{
    class tree
    {
        int k = 1;
        node[] nodes = null;
        public tree(node Main)
        {
            nodes[0] = Main;
        }
        public void AddNode(node tmp)
        {
            nodes[k] = tmp;
        }
        public node[] GetNames(node parent)
        {
            node[] result = null;
            int j = 0;
            for (int i = 0; i < nodes.Length; i++)
            {

                if (nodes[i].parent == parent.name)
                {
                    result[j] = nodes[i];
                    j++;
                }
            }
            return result;
        }
        public void CreateTree()
        {
            DB db = new DB("db.sqlite");
            int size = db.getsize();
            node actual = new node("0", "main");
            for (int i = 0; i < size; i++)
            {

            }

        }
        private void FindChild(node parent, node previous)
        {
            DB db = new DB("db.sqlite");
            db.Query("select name from structure where parent = '" + parent.name + "'");
        }
    }
}*/
