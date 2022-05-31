using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDB
{
    public class App
    {
        public void Run()
        {

            List<int> Listik = new List<int>();
            using var sr = new StreamReader("");
            using var sw = new StreamWriter("");
            var line = sr.ReadLine();
            //trim

            while (line != null) {
                var splited = line.Split(";");
                Listik.Add(new oop { oopsplited[0});

           


            while(true)
            {
                Console.WriteLine("Zadejte rok"); var inp = int.Parse(Console.ReadLine());
                var count = 0;
                if (inp == 0)
                {
                    break;
                }

                foreach(var items in Listik)
                {
                    if (items == inp)
                    {
                        count++;
                    }
                }
            }
        }
    }

    class oop
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public string Author { get; set; }
        }
    }
}
