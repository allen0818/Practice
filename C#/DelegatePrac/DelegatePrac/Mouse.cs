using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatePrac1
{
    class Mouse
    {
        private string name;
        public Mouse(string name)
        {
            this.name = name;
        }

        public void Run(object sender, CatShoutEventArgs args)
        {
            Console.WriteLine("老貓{0}來了， {1}快跑!", args.Name, name);
        }
    }
}
