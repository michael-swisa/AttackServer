using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //string file = "C:\\_kodcode2\\Omar\\AttackServer\\GetFileAs.txt";
            //Console.WriteLine(await ReadFileAsync(file));
            //string result = await GetDataAsync();
            //Console.WriteLine(result);
            Task<string> TaskA = GetDataFromServiceAAsync();
            Task<string> TaskB = GetDataFromServiceBAsync();
            await Task.WhenAll(TaskA, TaskB);
            Console.WriteLine($"TaskA result: {TaskA.Result}\nTaskB result: {TaskB.Result}");
            Console.ReadLine();
        }

        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Recivde data: ";
        }

        public static async Task<string> ReadFileAsync(string fullPath)
        {
            string result = await Task.Run(() => File.ReadAllText(fullPath));
            return result;
        }

        public static async Task<string> GetDataFromServiceAAsync()
        {
            await Task.Delay(1000);
            return "Data from service A";
        }

        public static async Task<string> GetDataFromServiceBAsync()
        {
            await Task.Delay(2000);
            return "Data from service B";
        }
    }
}
