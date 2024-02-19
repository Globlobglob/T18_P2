using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T18_P2
{
    class DOCHandler:AbstractHandler
    {
        public override void Create()
        {
            Console.WriteLine("You created .doc format");
        }

        public override void Change()
        {
            Console.WriteLine("You change .doc format");
        }

        public override void Open()
        {
            Console.WriteLine("You open .doc format");
        }

        public override void Save()
        {
            Console.WriteLine("You save .doc format");
        }
    }
}
