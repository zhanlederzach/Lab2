using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            FileStream fs2 = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            StreamReader sr = new StreamReader(fs);

            string str = sr.ReadToEnd();

            sr.Close();
            fs.Close();

            string[] input = str.Split(' ');

            int result = -4;

            for (int i = 1; i<input.Length;++i)
            {
                int current = int.Parse(input[i]);
                bool isPrime = true;
                if (current != 2)
                {
                    for (int j = 2; j <= Math.Sqrt(current); j++)
                    {
                        if (current % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime == true && result == -4) {
                    result = current;
                } else
                {
                    if (isPrime == true) {
                        if (current < result)
                            result = current;
                    }
                }

            }

            sw.WriteLine(result);
            sw.Close();

        }
       
    }
}
