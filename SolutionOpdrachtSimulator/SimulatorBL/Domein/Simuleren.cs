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
        List<AdresInfo> adresInfo = new();
        Dictionary<int, string> gemeentes = new();
        private Random _rand = new Random();
        private int _minimumLeeftijd;
        private int _maximumLeeftijd;

        public Simuleren(int minimumLeeftijd, int maximumLeeftijd)
        {
            _minimumLeeftijd = minimumLeeftijd;
            _maximumLeeftijd = maximumLeeftijd;
        }

        
        //public void RandomGeboortedatum()
        //{
        //   // DateTime.Now() - (maximumLeeftijd/minimumLeeftijd) voor geboortedatum
        //   int leeftijd = _rand.Next(_minimumLeeftijd, _maximumLeeftijd);
        //    DateTime dateTime = DateTime.Now;
        //    DateTime leeftijdJaar = new DateTime(leeftijd, 0, 0);
        //    TimeSpan geboorteDatum = dateTime - leeftijdJaar;
            
        //}
        
    }
}
