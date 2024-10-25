using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Unitaire_1
{
    public class Calculatrice
    {
        public Calculatrice() { }
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
        public int avg(int[] tab)
        {
            int result = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                result+= tab[i];
            }
            return result / tab.Length;
        }
    }
}
