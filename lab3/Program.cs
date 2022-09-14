using System;
using System.Collections;
using System.Xml.Linq;

class Program
{
    static List<Person> people = new List<Person>();

    public static void Main(string[] args)
    {
        var option = 0;
        do
        {
            DisplayMenu();
            option = Int32.Parse(Console.ReadLine());
            MenuChoice(option);

            Console.WriteLine("\nHit Enter to return to menu...");
            Console.ReadLine();
            Console.Clear();
        } while (option != 0);
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("------ Menu ------");
        Console.WriteLine("1. Create a new Person");
        Console.WriteLine("2. View all people");
        Console.WriteLine("3. Remove people");
        Console.WriteLine("4. Create and View Last Name");
        Console.WriteLine("5. Create and View Random SSN");
        Console.WriteLine("0. Exit");
        Console.WriteLine("------------------");
    }
    public static void RemovePerson(int option2)
    {
        people.RemoveAt(option2);
    }

    public static void MenuChoice(int option)
    {
        Random random = new Random();
        switch (option)
        {
            case 1:
                people.Add(new Person());
                break;
            case 2:
                foreach (Person p in people)
                {
                    Console.WriteLine(p);
                }
                break;
            case 3:
                var option2 = 0;
                Console.WriteLine("Choose the person to remove from person 0 - " + people.Count);
                option2 = Int32.Parse(Console.ReadLine());
                break;
            case 4:
                Person rando = people[random.Next(people.Count())];
                Console.WriteLine(rando.LastName);

                break;
            case 5:
                Person rando = people[random.Next(people.Count())];
                Console.WriteLine(rando.SSN);
                break;
            case 6:
                Person rando = people[random.Next(people.Count())];
                Console.WriteLine(rando.Phone);
                break;
            case 0:
                Console.WriteLine("See ya!");
                break;
            default:
                Console.WriteLine("Invalid option. Can you read?");
                break;
        }
    }
    /*
     * My try at it
     * static void Main(string[] args)
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
                    // Console.WriteLine(new Person()); 

                    break;

                case "3":
                    //Remove a peson
                    Console.Write("Type an Index on who you want to remove: ");
                    userInput = Console.ReadLine();
                    people.RemoveAt(userInput); 
                    break;

                case "4":
                    //Display random last name
                    
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
    */


}

