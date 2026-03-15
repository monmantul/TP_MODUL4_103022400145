using System;

namespace TP_MODUL4_103022400145
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- OUTPUT BAGIAN C: KODE POS ---");
            string kelurahan = "Batununggal";
            Console.WriteLine("Kelurahan: " + kelurahan + " | Kode Pos: " + KodePos.getKodePos(kelurahan));
            Console.WriteLine();

            Console.WriteLine("--- OUTPUT BAGIAN E: DOOR MACHINE ---");
            DoorMachine pintu = new DoorMachine();
            pintu.PerubahanState("BukaPintu"); 
            pintu.PerubahanState("KunciPintu"); 

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}