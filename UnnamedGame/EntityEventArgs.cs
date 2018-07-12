using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    public class EntityEventArgs : EventArgs
    {
        public enum Reason { Test, Time }


        public Reason Rsn { get; set; }

        public EntityEventArgs(Reason rsn)
        {
            Rsn = rsn;
        }
    }
}
