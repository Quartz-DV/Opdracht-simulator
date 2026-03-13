using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorBL.Domein
{
    public class Simuleren
    {
        List<VoorNamen> voorNamenMannen = new();
        List <VoorNamen> voorNamenVrouwen = new();
        List<AchterNamen> achterNamen = new();
        List<DateTime> geboortedata = new();
        List<string> emails = new();
        Dictionary<int, AdresInfo.Gemeente> gemeentes = new();

    }
}
