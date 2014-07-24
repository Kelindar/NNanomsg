using System;
using Misakai.Messaging.Nano;
using System.IO;
using Misakai.Messaging.Nano.Protocols;

namespace Example
{
    class Program
    {
        static void PrintUsage()
        {
            Console.WriteLine("Usage: Example.exe <ReqRep|Pair|Listener> [other params]");
        }

        /// <summary>
        ///     
        /// </summary>
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintUsage();
                return;
            }

            switch (args[0])
            {
                case "ReqRep": ReqRep.Execute(args);
                    break;
                case "Pair": Pair.Execute(args);
                    break;
                case "Listener": Listener.Execute(args);
                    break;
                default:
                    PrintUsage();
                    break;
            }

        }
    }
}
