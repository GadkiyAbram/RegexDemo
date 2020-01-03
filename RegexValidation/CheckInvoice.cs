using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexValidation
{
    public class CheckInvoice
    {
        private string inputString { get; set; }
        private string pattern { get; set; }

        public CheckInvoice(string inputPattern, string inputString)
        {
            this.inputString = inputString;
            this.pattern = inputPattern;
        }

        public bool Validate(string what)
        {
            bool output = true;
            string resultSuccess = what + " - Success";
            string resultFucked = what + " - You're fucked";

            Match match = Regex.Match(pattern, inputString);

            if (match.Success)
            {
                Console.WriteLine(resultSuccess);
            }
            else
            {
                Console.WriteLine(resultFucked);
            }

            return output;
        }
    }
}
