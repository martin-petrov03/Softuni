using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace EgnHelper
{    
    public class EgnValidator : IEgnValidator
    {
        private int[] weights = new int[] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };

        public bool IsValid(string egn)
        {
            if (egn == null)
            {
                throw new ArgumentNullException(nameof(egn));
            }

            if (!Regex.IsMatch(egn, "[0-9]{10}"))
            {
                return false;
            }

            int yearPart = int.Parse(egn.Substring(0, 2));
            int monthPart = int.Parse(egn.Substring(2, 2));
            int dayPart = int.Parse(egn.Substring(4, 2));

            int day = dayPart;
            int month = monthPart;
            int year = yearPart;
            if (monthPart >= 21 && monthPart <= 32)
            {
                // 1800 - 1899
                month = monthPart - 20;
                year += 1800;
            }
            else if (monthPart >= 41 && monthPart <= 52)
            {
                // 2000 - 2099
                month = monthPart - 40;
                year += 2000;
            }
            else if (monthPart >= 1 && monthPart <= 12)
            {
                // 1900 - 1999
                year += 1900;
            }
            else
            {
                return false;
            }

            if (!DateTime.TryParseExact(
                $"{year}-{month}-{day}", 
                "yyyy-M-d",
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None, 
                out _))
            {
                return false;
            }

            int checksum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = egn[i] - '0';
                checksum += digit * this.weights[i];
            }

            int lastDigit = checksum % 11;

            if (lastDigit == 10)
            {
                lastDigit = 0;
            }

            if (int.Parse(egn[9].ToString()) != lastDigit)
            {
                return false;
            }

            return true;
        }
    }
}
