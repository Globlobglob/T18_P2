using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T18_P2
{
    class XMLHandler:AbstractHandler
    {
        public override void Create()
        {
            Console.WriteLine("You created .xml format");
        }

        public override void Change()
        {
            Console.WriteLine("You change .xml format");
        }

        public override void Open()
        {
            Console.WriteLine("You open .xml format");
        }

        public override void Save()
        {
            Console.WriteLine("You save .xml format");
        }
    }
}
