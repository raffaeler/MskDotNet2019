using System;
using System.IO;
using System.Reflection;

namespace Master
{
    class Program
    {
        private static readonly string photo = "Moscow.jpg";

        static void Main(string[] args)
        {
            var fullpath = Path.GetFullPath(
                    Path.Combine(
                        Path.GetDirectoryName(
                            Assembly.GetExecutingAssembly().Location),
                        "..", "..", photo));

            using (var fs = File.OpenRead(fullpath))
            {
                using (var stdout = Console.OpenStandardOutput())
                {
                    fs.CopyTo(stdout);
                }
            }
        }
    }
}
