using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlussBeobachter_2023 {
    internal class Fluss {
        public string Name { get; set; }
        public int Wasserstand { get; set; } = 0;

        Random zzG = new Random();
        
        public int GetPegel() {
            Wasserstand = zzG.Next(100, 10001);
            return Wasserstand;
        }


    }
}
