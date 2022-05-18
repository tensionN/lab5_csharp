using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class ValidFunctions
    {
        public static bool IsValidNameMed(string name, out string errorMessage)
        {
            if (name.Trim().Length == 0)
            {
                errorMessage = "Name of med is required.";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool IsValidInt(string expDate, out string errorMessage)
        {
            if (expDate.Trim().Length == 0)
            {
                errorMessage = "Enter valid int number. (Ex. 2)";
                return false;
            }
            foreach (var sym in expDate.Trim())
            {
                if (!char.IsDigit(sym))
                {
                    errorMessage = "Enter valid int number. (Ex. 2)";
                    return false;
                }
            }
            errorMessage = "";
            return true;
        }

        public static bool IsValidProdDate(string prodDate, out string errorMessage)
        {
            if (!DateTime.TryParseExact(prodDate, "d/M/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out _))
            {
                errorMessage = "Enter valid date. (Ex. 26/3/2020)";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool IsValidPrice(string price, out string errorMessage)
        {
            if (!Double.TryParse(price, out _))
            {
                errorMessage = "Enter valid price. (Ex. 2.2)";
                return false;
            }
            errorMessage = "";
            return true;
        }
    }
}
