using Blockchain.Core;
using Newtonsoft.Json;
using System;

namespace Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            var startTime = DateTime.Now;
            Core.Blockchain seesharpifyCoin = new();
            seesharpifyCoin.CreateTransaction(new Transaction("James", "John", 10));
            seesharpifyCoin.CreateTransaction(new Transaction("John", "seesharpify", 10));
            seesharpifyCoin.ProcessPendingTransactions("seesharpify");
            seesharpifyCoin.CreateTransaction(new Transaction("James", "seesharpify", 5));
            seesharpifyCoin.CreateTransaction(new Transaction("seesharpify", "John", 5));
            seesharpifyCoin.ProcessPendingTransactions("seesharpify");
            var endTime = DateTime.Now;
            Console.WriteLine(JsonConvert.SerializeObject(seesharpifyCoin, Formatting.Indented));

            Console.WriteLine($"Stan konta James: {seesharpifyCoin.GetBalance("James")}");
            Console.WriteLine($"Stan konta John: {seesharpifyCoin.GetBalance("John")}");
            Console.WriteLine($"Stan konta seesharpify: {seesharpifyCoin.GetBalance("seesharpify")}");

            Console.WriteLine($"Duration: {endTime - startTime}");
            Console.ReadKey();
        }
    }
}
