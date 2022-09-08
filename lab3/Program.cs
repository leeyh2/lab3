class Program
{
    static void Main(string[] args)
    {
        String userInput;
        bool flag = true;

        Console.WriteLine("===========Menu===========");
        Console.WriteLine("1. Create Person/People");
        Console.WriteLine("2. View Person/People");
        Console.WriteLine("3. Remove a Person");
        Console.WriteLine("4. Display random last name");
        Console.WriteLine("5. Display random SSN");
        Console.WriteLine("6. Display random phone number");
        Console.WriteLine("0. Exit");

        while(flag)
        {
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Write("How many people do you wanna create: ");
                    int numberOfPeopleInput = Convert.ToInt16(Console.ReadLine());
                    Person[] people = new Person[numberOfPeopleInput];

                    for (int i = 0; i < numberOfPeopleInput; i++)
                    {

                    }
                    break;
                default:
                    break;
            }
        }

    }
}

