using System;

namespace TP_MODUL4_103022400145
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BAGIAN C: KODE POS ---");
            Console.WriteLine("Kelurahan Batununggal: " + KodePos.getKodePos("Batununggal"));
            Console.WriteLine();

            Console.WriteLine("--- BAGIAN E: DOOR MACHINE ---");
            DoorMachine pintu = new DoorMachine();
            pintu.PerubahanState("BukaPintu"); 
            pintu.PerubahanState("KunciPintu"); 

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}