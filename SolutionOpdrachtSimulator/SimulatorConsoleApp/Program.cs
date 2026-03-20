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

            string sourceFileAdres = config.GetSection("AppSettings")["sourceFileAdres"];
            string sourceFileFamilienamen = config.GetSection("AppSettings")["sourceFileFamilieNamen"];
            string sourceFileMannennamen = config.GetSection("AppSettings")["sourceFileMannenNamen"];
            string sourceFileVrouwennamen = config.GetSection("AppSettings")["sourceFileVrouwenNamen"];
            string sourceFilePostcodes = config.GetSection("AppSettings")["sourceFilePostcodes"];

            string sourceFileType = config.GetSection("AppSettings")["sourceFileType"];
            string sourceFileAdresType = config.GetSection("AppSettings")["sourceFileAdresType"];
            string sourceFileDataType = config.GetSection("AppSettings")["sourceFileDataType"];
            string databaseType = config.GetSection("AppSettings")["databaseType"];

            SimulatorBeheerder manager = new SimulatorBeheerder(RepositoryFactory.GeefRepository(databaseType, connectionstring));
        }
    }
}
