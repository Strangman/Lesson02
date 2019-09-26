using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTast
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[11];
            int[] rnd = { 1, 1, 1, 1, 1 };
            Array.Copy(rnd,0 ,  arr, (arr.Length/2)-(rnd.Length/2), rnd.Length);
            for(int i = 0; i < arr.Length; i++)
            {
                
                Console.Write(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
