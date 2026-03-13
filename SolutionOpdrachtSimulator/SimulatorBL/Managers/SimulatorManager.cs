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
    }
}
