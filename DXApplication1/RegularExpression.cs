using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace DXApplication1
{
    public class RegularExpression
    {
        public static bool checkForEmail(String email)
        {
           
            bool IsValid = false;
            Regex r = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");
            if (email != null)
            {
                    if (r.IsMatch(email))
                        IsValid = true;
            }
            return IsValid;
        }



    }
}
