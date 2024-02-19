using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T18_P2
{
    class TXTHandler:AbstractHandler
    {
        public override void Create()
        {
            Console.WriteLine("You created .txt format");
        }

        public override void Change()
        {
            Console.WriteLine("You change .txt format");
        }

        public override void Open()
        {
            Console.WriteLine("You open .txt format");
        }

        public override void Save()
        {
            Console.WriteLine("You save .txt format");
        }
    }
}
