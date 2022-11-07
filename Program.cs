using System;

namespace ArregloValoresSum10
{
    public  class Program
    {
        static int[] myarray = { 1, 8, 6, 7, 2, 5 };
        static void Main(string[] args)
        {
            int masusado, suma ,posicion,s,o= 0;
            int n = myarray.Length;
            for (int i = 0; i < n; i++)
            {
                s = myarray[i];
                for (int j = 0; j < n; j++)
                {
                    if (myarray[j] != s)
                    {
                        suma = s + myarray[j];
                        if (suma == 10)
                        {
                            Console.WriteLine(s + " " + myarray[j]);
                        }
                    }

                   
                }
            }
        }
    }
}
