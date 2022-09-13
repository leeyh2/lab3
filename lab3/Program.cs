using System.Collections;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
         string userInput;
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
                    //Creating a person/people
                    Console.Write("How many people do you wanna create: ");
                    int numberOfPeopleInput = Convert.ToInt16(Console.ReadLine());
                    ArrayList peoples = new ArrayList();
                    Person[] people = new Person[numberOfPeopleInput];

                    for (int i = 0; i < numberOfPeopleInput; i++)
                    {
                        people[i] = new Person();
                        peoples.Add(i);
                    }
                    break;
                case "2":
                    //View person/people
                    
                        foreach(Person people in peoples)
                    {
                        people.FirstName;
                        people.LastName;
                        people.BirthDate;
                        people.SSN;
                        people.Phone;
                    }

                    break;

                case "3":
                    //Remove a peson
                    Console.Write("Type an Index on who you want to remove: ");
                    userInput = Console.ReadLine();
                    people.RemoveAt(userInput); 
                    break;

                case "4":
                    //Display random last name
                    peoples.
                    break;

                case "5":
                    //Display random SSN

                    break;

                case "6":
                    //Display random Phone number
                    break;
                case "0":
                    //Exit
                    break;

                default:
                    break;
            }
        }

    }

  
}

