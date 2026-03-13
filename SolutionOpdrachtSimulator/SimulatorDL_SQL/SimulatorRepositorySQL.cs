using SimulatorBL.Interfaces;

namespace SimulatorDL_SQL
{
    public class SimulatorRepositorySQL : ISimulatorRepository
    {
        string connectionstring;

        public SimulatorRepositorySQL(string connectionstring) { 
            this.connectionstring = connectionstring;
        }
    }
}
