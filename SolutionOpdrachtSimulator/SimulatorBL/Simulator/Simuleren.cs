using SimulatorBL.Domein;
using SimulatorBL.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorBL.Simulator
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
        private SimulatorManager _manager;

        public Simuleren(int minimumLeeftijd, int maximumLeeftijd, SimulatorManager manager)
        {
            _minimumLeeftijd = minimumLeeftijd;
            _maximumLeeftijd = maximumLeeftijd;
            _manager = manager;
        }

        public void RandomGeboortedatum()
        {
            // DateTime.Now() - (maximumLeeftijd/minimumLeeftijd) voor geboortedatum
            int leeftijd = _rand.Next(_minimumLeeftijd, _maximumLeeftijd);
            DateTime dateTime = DateTime.Now;
            DateTime leeftijdJaar = new DateTime(leeftijd, 0, 0);
            
            var dateTimeTicks = dateTime.Ticks;
            var leeftijdTicks = leeftijdJaar.Ticks;

            var dateTicks = dateTimeTicks - leeftijdTicks;
            DateTime randomBday = new DateTime(dateTicks);

            geboortedata.Add(randomBday);
        }

        public List<VoorNamen> GetListVoorNamen(int aantalKlanten)
        {
            int aantalMannen = _rand.Next(0, aantalKlanten);
            int aantalVrouwen = _rand.Next(0, aantalKlanten - aantalMannen);

            voorNamenMannen =  _manager.GetVoorNaamMannen(aantalMannen);
            voorNamenVrouwen = _manager.GetVoorNaamVrouwen(aantalVrouwen);

            List<VoorNamen> voorNamen = new();

            foreach (var man in voorNamenMannen)
            {
                voorNamen.Add(man);
            }

            foreach(var vrouw in voorNamenVrouwen)
            {
                voorNamen.Add(vrouw);
            }

            return voorNamen;
        }

        public void ListAchterNamen(int aantalKlanten)
        {
            achterNamen = _manager.GetAchterNamen(aantalKlanten);
        }

        public void ListAdresInfo(int aantalKlanten)
        {
            adresInfo = _manager.GetAdresInfo(aantalKlanten);
        }

        public void MakeEmails()
        {
            int achterNamenIndex = voorNamenMannen.Count;
            for (int i = 0; i < voorNamenMannen.Count; i++)
            {
                emails.Add($"{voorNamenMannen[i]}.{achterNamen[i]}@mail.com");
            }

            for(int i = 0; i < voorNamenVrouwen.Count; i++)
            {
                emails.Add($"{voorNamenMannen[i]}.{achterNamen[achterNamenIndex + i]}@mail.com");
            }
        }
    }
}
