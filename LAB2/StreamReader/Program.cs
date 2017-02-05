using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // открываем или создаем (если нет) тхт файл для чтения
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.Read);
            
            // читаем его
            StreamReader sr = new StreamReader(fs);

            // читаем от начала до конца
            string inputLine = sr.ReadToEnd();

            // закрываем поток
            sr.Close();
            fs.Close();
            // разграничиваем пробелом нам массив
            string[] inputs = inputLine.Split(' ');

            // находим минимум и максимум 
            int min = int.Parse(inputs[0]);

            int max = int.Parse(inputs[0]); 

            for (int i=0; i<inputs.Length; ++i)
            {
                int curent = int.Parse(inputs[i]);

                if (curent > max)
                {
                    max = curent;
                }

                if (curent < min)
                {
                    min = curent;
                }                  
            }
            // выводим на экран
            Console.WriteLine("min={0}, max={1}", min, max);
            Console.ReadKey();    
        }

    }
}
