using System.IO;
using System.Collections.Generic;
internal class Program
{
    struct adatok
    {
        public string hegycsucsNeve, hegyseg;
        public int magassag;
    }
    static adatok[] hegyek = new adatok[1000];
    struct legelsoSor
    {
        public string elsoSorHegycsucs, elsoSorHegyseg, elsoSorMagassag;
       
    }
    static legelsoSor[]  elsoSors = new legelsoSor[1];
    private static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("hegyekMo.txt");
        string[] egySor;
        egySor = sr.ReadLine().Split(';');
        elsoSors[0].elsoSorHegycsucs = egySor[0];
        elsoSors[0].elsoSorHegyseg= egySor[1];
        elsoSors[0].elsoSorMagassag = egySor[2];

        string[] sor;
        int darab = 0;
        while (sr.Peek()>-1) 
        { 
        sor = sr.ReadLine().Split(';');
        hegyek[darab].hegycsucsNeve = sor[0];
        hegyek[darab].hegyseg = sor[1];
        hegyek[darab].magassag = Convert.ToInt32(sor[2]);
        darab++;
        }
        Console.WriteLine("3. feladat: Hegycsúcsok száma: {0}db",darab);


    }
}