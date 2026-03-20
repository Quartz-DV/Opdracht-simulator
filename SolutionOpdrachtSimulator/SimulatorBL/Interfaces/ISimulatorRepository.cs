using SimulatorBL.Domein;

namespace SimulatorBL.Interfaces
{
    public interface ISimulatorRepository
    {
        VoorNamen GetVoorNaamMan(string naam);
        VoorNamen GetVoorNaamVrouw(string naam);
        List<VoorNamen> GetVoorNaamMannen(int aantal);
        List<VoorNamen> GetVoorNaamVrouwen(int aantal);
    }
}