using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likovi
{
    internal class Lista
    {
        object[] elementi;
        public Lista(object[] elementi)
            => this.elementi = elementi;
        public class Iterator
        {
            Lista lista;
            int i;
            public Iterator(Lista lista, int i)
            {
                this.lista = lista;
                this.i = i;
            }
            public object Element => lista.elementi[i];
            public static Iterator operator ++(Iterator pozicija)
                => new Iterator(pozicija.lista, pozicija.i + 1);
            public static bool operator ==(Iterator i1, Iterator i2)
                => i1.lista == i2.lista && i1.i == i2.i;
            public static bool operator !=(Iterator i1, Iterator i2)
                => !(i1 == i2);
            public override bool Equals(object? obj)
                => obj is Iterator && this == (Iterator)obj;
            public override int GetHashCode()
                => i.GetHashCode();
        }
        public Iterator Begin
            => new(this, 0);
        public Iterator End
            => new(this, elementi.Length);
    }
}
