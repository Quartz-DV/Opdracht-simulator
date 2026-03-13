using SimulatorBL.Interfaces;
using System.Data;

namespace SimulatorDL_SQL
{
    public class SimulatorRepositorySQL : ISimulatorRepository
    {
        string connectionstring;

        public SimulatorRepositorySQL(string connectionstring) { 
            this.connectionstring = connectionstring;
        }

        public void importData ()
        {
            string GemeenteQuery = "INSERT INTO Gemeente (Gemeente_Id, Gemeentenaam, Postcode) VALUES (@gemeente_id, @gemeentenaam, @postcode)";
            string AdresQuery = "INSERT INTO Adres (Adres_Id, Straatnaam, Gemeente_Id) VALUES (@adres_id, @straatnaam; @gemeente_id)";
            string KlantQuery = "INSERT INTO Klant (Klant_Id, Voornaam_Mannen, Voornaam_Vrouwen, Achternamen, Adres_Id) VALUES (@klant_id, @voornaam_mannen, @voornaam_vrouwen, @achternamen, @adres_id)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmdGemeente = conn.CreateCommand())
            using (SqlCommand cmdAdres = conn.CreateCommand())
            using (SqlCommand cmdKlant = conn.CreateCommand())
            {
                conn.Open ();
                SqlTransaction transaction = conn.BeginTransaction();

                cmdGemeente.Transaction = transaction;
                cmdAdres.Transaction = transaction;
                cmdKlant.Transaction = transaction;

                cmdGemeente.CommandText = GemeenteQuery;
                cmdGemeente.Parameters.Add(new SqlParameter("@gemeente_id", SqlDbType.Int));
                cmdGemeente.Parameters.Add(new SqlParameter("@gemeentenaam", SqlDbType.NVarChar));
                cmdGemeente.Parameters.Add(new SqlParameter("@postcode", SqlDbType.Int));

                cmdAdres.CommandText = AdresQuery;
                cmdAdres.Parameters.Add(new SqlParameter("@adres_id", SqlDbType.Int));
                cmdAdres.Parameters.Add(new SqlParameter("@straatnaam", SqlDbType.NVarChar));
                cmdAdres.Parameters.Add(new SqlParameter("@gemeente_id", SqlDbType.Int));

                cmdKlant.CommandText = KlantQuery;
                cmdKlant.Parameters.Add(new SqlParameter("@klant_id", SqlDbType.Int));
                cmdKlant.Parameters.Add(new SqlParameter("@voornaam_mannen", SqlDbType.NVarChar));
                cmdKlant.Parameters.Add(new SqlParameter("@voornaam_vrouwen", SqlDbType.NVarChar));
                cmdKlant.Parameters.Add(new SqlParameter("@achternamen", SqlDbType.NVarChar));
                cmdKlant.Parameters.Add(new SqlParameter("@adres_id", SqlDbType.Int));

            }



    }



}
