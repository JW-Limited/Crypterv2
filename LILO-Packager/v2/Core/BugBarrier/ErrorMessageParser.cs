using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.BugBarrier
{
    public class ErrorMessageParser
    {
        public ErrorMessageParser(string errorMessage)
        {
            ParseErrorMessage(errorMessage);
        }

        public string ExceptionType { get; private set; }
        public string Library { get; private set; }
        public string Method { get; private set; }

        private void ParseErrorMessage(string errorMessage)
        {
            Regex exceptionRegex = new Regex(@"(?<=\b)\w+\.\w+\.\w+(?=:)");
            Regex libraryRegex = new Regex(@"(?<=at\s)\w+\.\w+\.\w+");
            Regex methodRegex = new Regex(@"(?<=\s+at\s)[\w<>.]+\([^)]+\)");
            Match exceptionMatch = exceptionRegex.Match(errorMessage);
            Match libraryMatch = libraryRegex.Match(errorMessage);
            Match methodMatch = methodRegex.Match(errorMessage);

            if (exceptionMatch.Success)
            {
                ExceptionType = exceptionMatch.Value;
            }
            else
            {
                ExceptionType = "N/A";
            }

            if (libraryMatch.Success)
            {
                Library = libraryMatch.Value;
            }
            else
            {
                Library = "N/A";
            }

            if (methodMatch.Success)
            {
                Method = methodMatch.Value;
            }
            else
            {
                Method = "N/A";
            }
        }
    }

}
