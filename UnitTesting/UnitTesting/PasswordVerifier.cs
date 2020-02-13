using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    class PasswordVerifier
    {
        public bool Verify(string password)
        {
           if (password == null)
            {
                return false;
            }
            if (password.Length < 8)
            {
                return false;
            }
            char[] pw = password.ToCharArray();
            bool upper= false, lower = false, number = false;
            foreach(char c in pw)
            {
                if (char.IsUpper(c))
                {
                    upper = true;
                }
                else if (char.IsLower(c))
                {
                    lower = true;
                }
                else if (char.IsDigit(c))
                {
                    number = true;
                }
            }
            if (upper && lower && number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
