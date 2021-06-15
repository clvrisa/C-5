using System;

namespace Exercise8
{
    class A
    {
        int x;
        public abstract void f(int n);
        public virtual void g(uint n)
        {
            x = (int)n;
        }
        public string ToString()
        {
            return x.ToString();
        }
    }
}
