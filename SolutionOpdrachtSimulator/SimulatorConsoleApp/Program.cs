using Microsoft.Extensions.Configuration;
using SimulatorBL.Managers;
using SimulatorUtil.Factories;

namespace SimulatorConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var config = builder.Build();
            string connectionstring = config.GetConnectionString("SQLConnection");
            string sourcefile = config.GetSection("AppSettings")["sourcefile"];
            string newSourceFile = config.GetSection("AppSettings")["newSourceFile"];
            string sourceFileType = config.GetSection("AppSettings")["sourceFileType"];
            string newSourceFileType = config.GetSection("AppSettings")["newSourceFileType"];
            string databaseType = config.GetSection("AppSettings")["databaseType"];

            SimulatorManager manager = new SimulatorManager(RepositoryFactory.GeefRepository(databaseType, connectionstring));
        }
    }
}
