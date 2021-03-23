using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace EasyMatch {
    public class Program {
        //** Made by Rail **\\
        static async Task Main(string[] args) {
            await Task.Delay(-1);
        }
    }
    public class Matcher {
        public string chars;
        public string chars1;
        public Matcher(string chars, string chars1) {
            this.chars = chars;
            this.chars1 = chars1;
        }
        public List<string> match(string text, string pattern) {
            List<string> matches = new List<string>();
            var split = text.Split(' ');
            var split2 = pattern.Split(' ');
            var txt = split.Length > split2.Length ? split : split2;
            var pat = txt == split2 ? split : split2;
            var difference = txt.Except(pat).ToArray();
            var difference1 = pat.Except(txt).ToArray();
            foreach (var vara in difference.Zip(difference1, (d, d1) => new { difference = d, difference1 = d1 })) {
                matches.Add(vara.difference.Replace(vara.difference, vara.difference1));
            }
            return matches;
        }
    }
}
      
