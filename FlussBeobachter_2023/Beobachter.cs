using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlussBeobachter_2023 {
    internal abstract class Beobachter {
        public event EventHandler<EventArgs> EinEvent;
    }

    //internal class WasserstandsHandlerArgs : EventArgs {
    //    public int Wasserstand { get; set; }
    //}
}
