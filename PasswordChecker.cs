using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassword__Smir__
{
     public class PasswordChecker
    {
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 30)
                return true;

            if (password.Intersect("~!@#$%^&*!-=+/.<>,(){}[]`|:;'\"").Count() > 0)
                return true;

            password.Any(Char.IsDigit);
            password.Any(Char.IsUpper);
            password.Any(Char.IsLower);
            
            return true;
        }
    }
}
