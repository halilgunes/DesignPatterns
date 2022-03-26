using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> partList1 = new List<string>  {
             "Patates",
             "Zeytin",
             "Mayonez",
             "Peynir"
            };

            List<string> partList2 = new List<string> {
             "Patates",
             "Salata",
             "Ketçap",
             "Turşu"
            };

            Director director = new Director();
            director.Construct(new ConcreteBuilder1(), partList1);
            director.Construct(new ConcreteBuilder1(), partList2);
        }

    }
}
