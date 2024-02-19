using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T18_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which file you wnat to manipulate");
            Console.WriteLine("1-.doc\n2-.txt\n3-.xml\n");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
               case 1 :
                    List<DOCHandler> doc = new List<DOCHandler>();
                    doc.Add(new DOCHandler());
                    foreach(var item in doc)
                    {
                        item.Create();
                        item.Change();
                        item.Open();
                        item.Save();
                    }
                    break;

                case 2:
                    List<TXTHandler> txt = new List<TXTHandler>();
                    foreach(var item in txt)
                    {
                        item.Create();
                        item.Change();
                        item.Open();
                        item.Save();
                    }
                    break;

                case 3:
                    List<XMLHandler> xml = new List<XMLHandler>();
                    foreach(var item in xml)
                    {
                        item.Create();
                        item.Change();
                        item.Open();
                        item.Save();
                    }

                    break;

                case 0:
                    goto mark 1;
                      
                
                    Console.WriteLine("Not found");
                    break;
            }
            Console.ReadKey();  
        }
    }
}
