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
}


showTheWarningToCustomer();
showCakesAndPiesOptions();