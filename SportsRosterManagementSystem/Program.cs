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
    System.Console.Write("Select Option: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            
        break;
    }
}

void PrintMenu()
{
    for (int i = 0; i< menu.Length; i++)
    {
        System.Console.WriteLine("{0}. {1}", i +1, menu[i]);
    }
}