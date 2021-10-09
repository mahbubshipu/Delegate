using System;
using System.IO;
using System.Threading.Tasks;

namespace AsyncExamples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var text = await GetString();
        }
        static async Task<string> GetString()
        {

            return await Task.Run(() => ReadFiles());
        }
        static string ReadFiles()
        {
            return File.ReadAllText("path");
        }
    }
}
