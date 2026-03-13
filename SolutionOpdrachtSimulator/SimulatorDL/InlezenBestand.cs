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

        
        public LeesBestanden(string para) {

            using (StreamReader adresInfo = new StreamReader(Path.Combine(para, "adresinfo.txt"))) {

                string line;
                adresInfo.ReadLine();

                while ((line=adresInfo.ReadLine()) != null) {

                    string ls = line.Split(',');
                    int 


                }

            }


        }
   





    }
}
