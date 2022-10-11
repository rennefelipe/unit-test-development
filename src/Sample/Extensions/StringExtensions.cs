using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Sample.Extensions
{
    public static class StringExtensions
    {
        public static bool IsValidMail(this string email)
        {
            Regex Regex = new Regex(@"^([\w\.\-]+)((\.(\w){2,3})+)$");
            Match match = Regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;


            //return validateEmailRegex.IsMatch(email);
        }
    }
}
