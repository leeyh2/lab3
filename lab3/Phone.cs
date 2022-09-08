using System;
namespace lab3
{
    public class Phone:Person
    {
        private string phoneNum;
        
        public string Numbers
        { get; init; }

        public Phone()
        {
            //constructor

            //generates phonenumber
            Random random = new Random();
              string phoneNum = "";
            phoneNum += random.Next(2, 9).ToString();
            for (int i = 0; i < 10; i++)
            {
                phoneNum += random.Next(0, 9).ToString();
            }
        }


        public string Format(char seperator = '-')
        {
            //formatting method
             string formatNum = String.Format("{0:###-###-####", phoneNum);
            return formatNum;
        }
    }
}

