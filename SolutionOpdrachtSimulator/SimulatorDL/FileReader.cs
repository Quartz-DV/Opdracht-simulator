using System.IO.Compression;
using System.Runtime.InteropServices.Marshalling;

namespace SimulatorDL
{
    public class InlezenBestand
    {
        string zipPad = "..\\..\\Opdracht-simulator\\dataSim.zip";
        string extractPad = "..\\..\\Opdracht-Simulator\\WegGeschrevenBestand";
        string para = "C:\\Users\\shiva\\Opdracht_Simulator\\Opdracht-simulator\\unzip\\dataSim";



        public void ZipFileExtracten(string zipPad, string extractPad) {
            ZipFile.ExtractToDirectory(zipPad, extractPad);

        }


        public List<string> ben (string para) {

            using (StreamReader adresInfo = new StreamReader(Path.Combine(para, "adresinfo.txt"))) {

                string line;
                adresInfo.ReadLine();

                while ((line = adresInfo.ReadLine()) != null) {

                    string[] ls = line.Trim().Split(',');
                    string provincie = ls[0];
                    string gemeenteNaam = ls[1];
                    string straatNaam = ls[2];


                }

            }

            return null;

            //using (StreamReader zipcodes = new StreamReader(Path.Combine(para, "zipcodes_alpha_nl_2025.csv"))) {

            //    string line;
            //    zipcodes.ReadLine();

            //    while ((line = zipcodes.ReadLine()) != null) {

            //        string[] ls = line.Trim().Split(';');
            //        int postcode = int.Parse(ls[0]);
            //        string gemeenteNaam = ls[3];

            //    }
            //}

            //using (StreamReader familieNamen = new StreamReader(Path.Combine(para, "Familienamen_2024_Belgie.csv"))) {

            //    string line;
            //    familieNamen.ReadLine();

            //    while ((line = familieNamen.ReadLine()) != null) {

            //        string[] ls = line.Trim().Split(";");
            //        int id = int.Parse(ls[0]);
            //        string familieNaam = ls[1];

            //    }

            //}

            //using (StreamReader mannenNamen = new StreamReader(Path.Combine(para, "mannennamen_belgie.csv"))) {

            //    string line;
            //    mannenNamen.ReadLine();

            //    while ((line = mannenNamen.ReadLine()) != null) {

            //        string[] ls = line.Trim().Split(";");
            //        int id = int.Parse(ls[0]);
            //        string mannenVoornaam = ls[1];

            //    }

            //}

            //using (StreamReader vrouwenNamen = new StreamReader(Path.Combine(para, "vrouwennamen_belgie.csv"))) {

            //    string line;
            //    vrouwenNamen.ReadLine();

            //    while ((line = vrouwenNamen.ReadLine()) != null) {

            //        string[] ls = line.Trim().Split(";");
            //        int id = int.Parse(ls[0]);
            //        string vrouwenVoornaam = ls[1];




                }


            }
        }


