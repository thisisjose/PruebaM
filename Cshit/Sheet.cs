using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaM.Cshit
{
    internal class Sheet
    {
        public void Burbuja()
        {
            int n;
            Console.WriteLine("Que tan grande master");
            n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("escribeme el numero we", (i+1));
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int vec;
                    if (num[i] > num[j])
                    {
                        vec = num[i];
                        num[i] = num[j];
                        num[j] = vec;
                    }
                }
            }
            Console.WriteLine("Estos son: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
    }
}
