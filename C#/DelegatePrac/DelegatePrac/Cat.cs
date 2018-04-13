using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatePrac1
{
    class Cat
    {
        private string name;
        public Cat(string name)
        {
            this.name = name;
        }

        public delegate void CatShoutEventHandler(object sender, CatShoutEventArgs args);
        public event CatShoutEventHandler CatShout;

        public void Shout()
        {
            Console.WriteLine("喵, 我是{0}", name);
            if (CatShout != null) //指的是是否有人註冊了這個Event
            {
                CatShoutEventArgs e = new CatShoutEventArgs();
                e.Name = this.name;

                CatShout(this, e);
            }
        }
    }
}
