//Name: Erik Menchaca
//Date: November 21, 2022
//Instructor: Michael Berrios
//Homework 3: -> Sports Roster Management System
const string TITLE = "Sports Roster Management System";
Console.Title = TITLE;

string[] menu =
{
    "Create a Team",
    "Remove a Team",
    "Change a Team Roster",
    "List a Team Roster",
    "List All Teams",
    "Exit"
};
Dictionary<string, Team> teams;

while (true)
{
    PrintMenu();
    Console.Write("Select Option: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:

            Console.Write("Enter the name of the team: ");
            Console.WriteLine();
            System.Console.WriteLine("Enter the player's name: ");
            string playersName = Console.ReadLine();

            break;
        case 2:

            break;
        case 3:

            break;

        case 4:

            break;

        case 5:

            break;
        case 6:

            break;
        default:
            Console.WriteLine("This is an invalid choice. Try again.");
            break;
    }
}
// Methods below
void PrintMenu()
{
    for (int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine("{0}. {1}", i + 1, menu[i]);
    }
}

// case 1 for option 1 method
void CreateATeam()
{
    
}