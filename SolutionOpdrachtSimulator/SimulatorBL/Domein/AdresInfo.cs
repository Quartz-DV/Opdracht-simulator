using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace SimulatorBL.Domein {
    public class AdresInfo
    {
        public AdresInfo(string gemeente, int postcode, string straatNaam)
        {
            Gemeente = gemeente;
            Postcode = postcode;
            StraatNaam = straatNaam;
        }

        public string Gemeente { get; set; }
        public int Postcode { get; set; }
        public string StraatNaam { get; set; }


    }
}
