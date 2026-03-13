using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorBL.Domein {
    public class Voornamen {

        public Voornamen(string vrouwenNamen,string mannenNamen) {

            VrouwenNamen = vrouwenNamen;
            MannenNamen = mannenNamen;

        }

        public string VrouwenNamen { get; set; }
        public string MannenNamen { get; set; }


    }
}
