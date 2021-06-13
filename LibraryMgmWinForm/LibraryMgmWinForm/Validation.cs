using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryMgmWinForm
{
    class Validation
    {
        public bool validateNum(string input)
        {
            if (Regex.IsMatch(input.ToString(), @"^\d+$"))
            {
                return true;
            }
            else if (input.ToString() == " ")
                return false;

            else
                return false;
        }

        public bool validateString(string input)
        {
            if (Regex.IsMatch(input.ToString(), @"^\d+$"))
            {
                return false;
            }

            else
                return true;
        }
    }
}