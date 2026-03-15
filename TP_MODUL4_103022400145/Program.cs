using System;

namespace TP_MODUL4_103022400145
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BAGIAN C: KODE POS ---");
            Console.WriteLine("Kode Pos Batununggal: " + KodePos.getKodePos("Batununggal"));

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}