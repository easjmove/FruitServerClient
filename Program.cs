using System;
using System.Net.Http;
using FruitsServer;

namespace FruitServerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestFruit();
            Console.ReadLine();
        }

        private static async void TestFruit()
        {
            using (HttpClient client = new HttpClient())
            {
                FruitServerConsumer _consumer = new FruitServerConsumer("http://localhost:58540/", client);
                var fruits = await _consumer.FruitsAllAsync(null).ConfigureAwait(false);

                foreach (Fruit myFruit in fruits)
                {
                    Console.WriteLine(myFruit.TypeOfFruit);
                }
            }
        }
    }
}
