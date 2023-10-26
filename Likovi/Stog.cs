using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likovi
{
    internal class Stog
    {
        static int MAX = 1000;
        int vrh = -1;
        object[] podaci = new object[MAX];
        public bool JelPrazan => vrh < 0;
        public void Push(object objekt)
        {
            if (vrh >= MAX - 1)
                throw new Exception("Overflow");
            podaci[++vrh] = objekt;
        }
        public object Top
        {
            get
            {
                if(JelPrazan)
                {
                    throw new Exception("Prazan stog");
                }
                return podaci[vrh];
            }
        }
        public void Pop()
        {
            if(JelPrazan)
            {
                throw new Exception("Underflow");
            }
            --vrh;
        }
    }
}
