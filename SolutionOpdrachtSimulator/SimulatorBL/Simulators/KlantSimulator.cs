using SimulatorBL.Domein;
using SimulatorBL.Managers;
using SimulatorBL.Simulators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorBL.Simulator
{
    public class KlantSimulator
    {
        private Random _rand = new Random();
        private SimulatorManager _manager;
        private AdresSimulator _simulator;

        public List<string> Voornamen {  get; set; }
        public List<string> Achternamen { get; set; }
        public List<AdresInfo> Adres { get; set; }
        public List<string> EmailExtenties { get; set; }
        

        public KlantSimulator(SimulatorManager manager, AdresSimulator simulator)
        {
            _manager = manager;
            _simulator = simulator;
        }

        public List<Klant> GeefKlanten(int aantal)
        {
            List<Klant> Klanten = new();

            for (int i = 0; i < aantal; i++)
            {

                // Geef voornaam(random scalair)
                // Geef achternaam
                // Maak emails
                // Maak geboortedatum
            }

            return Klanten;
        }

        public DateTime RandomGeboortedatum(DateTime minDatum, DateTime maxDatum)
        {
            long range = maxDatum.Ticks - minDatum.Ticks;
            long randomTicks = (long)(_rand.NextDouble() * range);

            return new DateTime(randomTicks + minDatum.Ticks);
        }

        public string MaakEmail(string voornaam, string achternaam)
        {
            throw new NotImplementedException();
        }
    }
}
