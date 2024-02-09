string warningToCustomer = " Warning: NOW you are inside of the Cake Maryanne Shop. Please, be careful with the cakes. ";

void showTheWarningToCustomer()
{
    Console.WriteLine(warningToCustomer);
    Console.WriteLine(@"

██████╗░░█████╗░██╗░░██╗███████╗██████╗░  ░██████╗██╗░░██╗░█████╗░██████╗░
██╔══██╗██╔══██╗██║░██╔╝██╔════╝██╔══██╗  ██╔════╝██║░░██║██╔══██╗██╔══██╗
██████╦╝███████║█████═╝░█████╗░░██████╔╝  ╚█████╗░███████║██║░░██║██████╔╝
██╔══██╗██╔══██║██╔═██╗░██╔══╝░░██╔══██╗  ░╚═══██╗██╔══██║██║░░██║██╔═══╝░
██████╦╝██║░░██║██║░╚██╗███████╗██║░░██║  ██████╔╝██║░░██║╚█████╔╝██║░░░░░
╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░░░░
");
}


void showCakesAndPiesOptions()
{
    Console.WriteLine("\nClick 1 - To See The Cakes");
    Console.WriteLine("Click 2 - To See The Pies");
    Console.WriteLine("Click 3 - To See The Cupcakes");
    Console.WriteLine("Click 4 - To Exit");

    Console.WriteLine("Please, select an option: ");
    string menuOptions = Console.ReadLine()!;

    int chosenOption = int.Parse(menuOptions);

    if (chosenOption == 1)
    {
        Console.WriteLine("You have selected the Cakes");
    }
    else if (chosenOption == 2)
    {
        Console.WriteLine("You have selected the Pies");
    }
    else if (chosenOption == 3)
    {
        Console.WriteLine("You have selected the Cupcakes");
    }
    else if (chosenOption == 4)
    {
        Console.WriteLine("You have selected to Exit");
    }
    else
    {
        Console.WriteLine("Invalid Option,please try again!!!");
    }

}


showTheWarningToCustomer();
showCakesAndPiesOptions();