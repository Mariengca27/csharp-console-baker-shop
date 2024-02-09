string warningToCustomer = " Warning: NOW you are inside of the Cake Maryanne Shop. Please, be careful with the cakes. ";

// New List to put the new registers
List<string> newFlavors = new List<string>();

void ShowTheWarningToCustomer()
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


void ShowCakesAndPiesOptions()
{
    Console.WriteLine("\nClick 1 - To See The Cakes");
    Console.WriteLine("Click 2 - To See The Pies");
    Console.WriteLine("Click 3 - To See The Cupcakes");
    Console.WriteLine("Click 4 - To Exit");
    Console.WriteLine("Click 5 - New Register of Flavor");

    Console.WriteLine("Please, select an option: ");
    string menuOptions = Console.ReadLine()!;

    int chosenOption = int.Parse(menuOptions);

    switch (chosenOption)
    {

        case 1:
            Console.WriteLine("You choose Cakes");
            ListOfCakes();
            break;
        case 2:
            Console.WriteLine("You choose Pies");
            ListOfPies();
            break;
        case 3:
            Console.WriteLine("You choose Cupcakes");
            ListOfCupcakes();
            break;
        case 4:
            Console.WriteLine("You choose to Exit");
            break;
        case 5:
            Console.WriteLine("New Register: Fill the Fields below");
            RegisterNewFlavor();
            break;
        default:
            Console.WriteLine("Invalid Option");
            break;
    }

}


void ListOfCakes()
{
    Console.Clear();

    // All the cakes that will be add on the system 
    Console.WriteLine("ALL FLAVORS BELOW");
    Console.WriteLine("1 - Chocolate Cake");
    Console.WriteLine("2 - Vanilla Cake");
    Console.WriteLine("3 - Strawberry Cake");
    Console.WriteLine("4 - Lemon Cake");
    Console.WriteLine("5 - Red Velvet Cake");
    Console.WriteLine("6 - Carrot Cake");
    Console.WriteLine("7 - Coconut Cake");
    Console.WriteLine("8 - Pineapple Cake");
    Console.WriteLine("9 - Banana Cake");
    Console.WriteLine("10 - Apple Cake");
    Console.WriteLine("11 - Orange Cake");
    Thread.Sleep(1000);
    ShowCakesAndPiesOptions();

}



void ListOfPies()
{

    Console.Clear();
    Console.WriteLine("ALL FLAVORS BELOW");
    // All the pies that will be add on the system 
    Console.WriteLine("1 - Apple Pie");
    Console.WriteLine("2 - Cherry Pie");
    Console.WriteLine("3 - Blueberry Pie");
    Console.WriteLine("4 - Pumpkin Pie");
    Console.WriteLine("5 - Pecan Pie");
    Thread.Sleep(1000);
    ShowCakesAndPiesOptions();


}

void ListOfCupcakes()
{

    Console.Clear();
    Console.WriteLine("Here is the list of the pies: ");
    // All the Cupcakes that will be add on the system 
    Console.WriteLine("1 - Chocolate Cupcake");
    Console.WriteLine("2 - Vanilla Cupcake");
    Console.WriteLine("3 - Strawberry Cupcake");
    Console.WriteLine("4 - Lemon Cupcake");
    Thread.Sleep(1000);
    ShowCakesAndPiesOptions();

}

void RegisterNewFlavor()
{

    Console.Clear();
    Console.WriteLine("NEW REGISTER OF FLAVOR ");
    Console.Write("Please, fill the new register name: ");
    string nameFlavor = Console.ReadLine();
    newFlavors.Add(nameFlavor);

    Console.WriteLine("The new register was added with success");
    //Next implemetation are the if/else to choose the type of the flavros 







}



ShowTheWarningToCustomer();
ShowCakesAndPiesOptions();