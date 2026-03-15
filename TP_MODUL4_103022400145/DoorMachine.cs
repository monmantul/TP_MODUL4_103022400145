using System;

namespace TP_MODUL4_103022400145
{
    public class DoorMachine
    {
        public enum State { Terkunci, Terbuka };
        public State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void PerubahanState(string perintah)
        {
            if (currentState == State.Terkunci && perintah == "BukaPintu")
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else if (currentState == State.Terbuka && perintah == "KunciPintu")
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }
}
