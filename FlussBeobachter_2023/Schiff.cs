using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlussBeobachter_2023 {
    internal class Schiff : Beobachter  {
        public string Name { get; set; }

        public void OnWasserstand(object source, EventArgs e) {
            Console.WriteLine("Fluß: ich wurde gerufen");
        }

        //public void beobachten(object source, EventArgs e) {
        //    if ( ((Fluss)source).Wasserstand < 250 || ((Fluss)source).Wasserstand > 8000) {
        //        EinEvent(this, new EventArgs());
        //    }
        //}
    }
}
