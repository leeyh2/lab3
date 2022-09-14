using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace lab3
{
    public class SSN
    {
        private string ssnNum;
        public string Number
        { get
            {
                return Number;
            } init
            {
                Number = GenerateSSN();
            } }

        //https://primepay.com/blog/how-determine-valid-social-security-number#:~:text=An%20invalid%20SSN%20is%20one,four%20digits%20as%20%E2%80%9C0000.%E2%80%9D
        //The first three digits as “000,” “666,” or in the 900 series.
            //The second group that consists of two digits as “00.”
                //The third group consisting of four digits as “0000.”
        public SSN()
        {
            // https://uibakery.io/regex-library/ssn-regex-csharp
            // took the regex and fixed it up to take invalid ssn, i think
            // Regex validateSSNRegex = new Regex("^(666|000|9\\d{2}|\\d{3})(00|\\d{2})(0{4}|\\d{4})$");
            //generates ssnnumber
            bool flag = true;
            do
            {
                Random random = new Random();
                ssnNum = "";
                for (int i = 0; i < 10; i++)
                {
                    ssnNum += random.Next(0, 9).ToString();
                }
                Regex validateSSNRegex1 = new Regex("^(666)(\\d{2})(\\d{4})$");
                Regex validateSSNRegex2 = new Regex("^(000)(\\d{2})(\\d{4})$");
                Regex validateSSNRegex3 = new Regex("^(9\\d{2})(\\d{2})(\\d{4})$");
                Regex validateSSNRegex4 = new Regex("^(\\d{3})(00)(\\d{4})$");
                Regex validateSSNRegex5 = new Regex("^(\\d{3})(\\d{2})(0{4}|)$");
                Match match1 = validateSSNRegex1.Match(ssnNum);
                Match match2 = validateSSNRegex2.Match(ssnNum);
                Match match3 = validateSSNRegex3.Match(ssnNum);
                Match match4 = validateSSNRegex4.Match(ssnNum);
                Match match5 = validateSSNRegex5.Match(ssnNum);
                if (match1.Success)
                {
                    flag = false;
                }
                else if (match2.Success)
                {
                    flag = false;
                }
                else if (match3.Success)
                {
                    flag = false;
                }
                else if (match3.Success)
                {
                    flag = false;
                }
                else if (match4.Success)
                {
                    flag = false;
                }
                else if (match5.Success)
                {
                    flag = false;
                }
            } while (flag);
        }

        public override string ToString()
        {
            string formatNum = String.Format("{0:###-##-####", ssnNum);
            ssnNum = formatNum;
            return ssnNum;
        }
        public override string ToString()
        {
            string socialSecurityNumber = Number;
            socialSecurityNumber = socialSecurityNumber.Insert(3, "-");
        }
        public string GenerateSSN()
        {
            // https://uibakery.io/regex-library/ssn-regex-csharp
            // took the regex and fixed it up to take invalid ssn, i think
            // Regex validateSSNRegex = new Regex("^(666|000|9\\d{2}|\\d{3})(00|\\d{2})(0{4}|\\d{4})$");
            //generates ssnnumber
            bool flag = true;
            do
            {
                Random random = new Random();
                ssnNum = string.Empty;
                for (int i = 0; i < 10; i++)
                {
                    ssnNum += random.Next(0, 9).ToString();
                }
                Regex validateSSNRegex1 = new Regex("^(666)(\\d{2})(\\d{4})$");
                Regex validateSSNRegex2 = new Regex("^(000)(\\d{2})(\\d{4})$");
                Regex validateSSNRegex3 = new Regex("^(9\\d{2})(\\d{2})(\\d{4})$");
                Regex validateSSNRegex4 = new Regex("^(\\d{3})(00)(\\d{4})$");
                Regex validateSSNRegex5 = new Regex("^(\\d{3})(\\d{2})(0{4}|)$");
                Match match1 = validateSSNRegex1.Match(ssnNum);
                Match match2 = validateSSNRegex2.Match(ssnNum);
                Match match3 = validateSSNRegex3.Match(ssnNum);
                Match match4 = validateSSNRegex4.Match(ssnNum);
                Match match5 = validateSSNRegex5.Match(ssnNum);
                if (match1.Success)
                {
                    flag = false;
                }
                else if (match2.Success)
                {
                    flag = false;
                }
                else if (match3.Success)
                {
                    flag = false;
                }
                else if (match3.Success)
                {
                    flag = false;
                }
                else if (match4.Success)
                {
                    flag = false;
                }
                else if (match5.Success)
                {
                    flag = false;
                }
            } while (flag);
            return ssnNum;
        }
        /*public string GenereateSSN()
         * 
         * Class walkthrough method
        {
            string invalidSSN = String.Empty;
            Random random = new Random();
            var nineHundredSeries = random.Next(900, 1000).ToString();
            var firstThreeArray = new string[] { "000", "666", nineHundredSeries };
            var firstThree = firstThreeArray[random.Next(3)];
            var secondTwo = "00";
            var lastFour = "0000";
            invalidSSN = string.Concat(firstThree, secondTwo, lastFour);
            return invalidSSN;
        }
        */

    }
}

