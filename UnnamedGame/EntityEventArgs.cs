using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    class EntityEventArgs : EventArgs
    {
        public enum Reason { Test }


        public Reason Rsn { get; set; }

        public EntityEventArgs(Reason rsn)
        {
            Rsn = rsn;
        }
    }
}
