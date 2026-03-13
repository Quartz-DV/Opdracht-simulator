using SimulatorBL.Interfaces;
using SimulatorDL_SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorUtil.Factories
{
    public class RepositoryFactory
    {
        public static ISimulatorRepository GeefRepository(string databaseType, string connectionstring)
        {
            switch (databaseType)
            {
                case "SQL": return new SimulatorRepositorySQL(connectionstring);
                default: return null;
            }
        }
    }
}
