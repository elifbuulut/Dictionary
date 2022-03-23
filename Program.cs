using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> engTurk = new Dictionary<string, string>();
            engTurk.Add("Work", "Çalış");
            engTurk.Add("Patience", "Sabır");
            foreach (var words in engTurk)
            {
                Console.WriteLine(words);

            }

            foreach (var words in engTurk)
            {
                Console.WriteLine(words);
                Console.WriteLine(words.Value);//only value
                Console.WriteLine(words.Key); // only key


            }
            Console.WriteLine(engTurk.ContainsKey("book")); 
            Console.ReadLine();

        }
    }
}
