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

    switch (chosenOption)
    {

        case 1:
            Console.WriteLine("You choose Cakes");
            break;
        case 2:
            Console.WriteLine("You choose Pies");
            break;
        case 3:
            Console.WriteLine("You choose Cupcakes");
            break;
        case 4:
            Console.WriteLine("You choose to Exit");
            break;
        default:
               Console.WriteLine("Invalid Option");
            break;
    }

}


showTheWarningToCustomer();
showCakesAndPiesOptions();