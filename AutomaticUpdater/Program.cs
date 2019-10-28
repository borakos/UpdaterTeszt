using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticUpdater {
    class Program {
        static void Main(string[] args) {
            Settings settings = new Settings();
            settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("sources\\settings.json"));
            Console.WriteLine(settings.version);
            Console.WriteLine(settings.user);
            Console.ReadLine();
        }
    }
}
