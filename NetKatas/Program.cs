using System;

namespace NetKatas
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine(TCP.TraverseStates(new[] { "APP_ACTIVE_OPEN", "RCV_SYN_ACK", "RCV_FIN" }));
        }
    }
}
