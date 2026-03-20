using SimulatorBL.Domein;
using SimulatorBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorBL.Managers
{
    public class SimulatorManager
    {
        private ISimulatorRepository _repo;
        public SimulatorManager(ISimulatorRepository repo)
        {
            this._repo = repo;
        }

        public List<VoorNamen> GetVoorNaamMannen(int aantal)
        {
            return _repo.GetVoorNaamMannen(aantal);
        }

        public List<VoorNamen> GetVoorNaamVrouwen(int aantal)
        {
            return _repo.GetVoorNaamVrouwen(aantal);
        }

        public VoorNamen GetVoorNaamVrouw(string naam)
        {
            return _repo.GetVoorNaamVrouw(naam);
        }

        public VoorNamen GetVoorNaamMan(string naam) 
        {
            return _repo.GetVoorNaamMan(naam);
        }
    }
}
