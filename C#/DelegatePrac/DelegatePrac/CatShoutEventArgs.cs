using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatePrac1
{
    class CatShoutEventArgs : EventArgs
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
