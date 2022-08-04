using CBLClientPart;
using CBLAdminPart;
int MainChoice = 0;
ClientBase TestBase = new ClientBase();
ClientMenu MainMenu = new ClientMenu(TestBase);
int choice = 0;
do
{
    Console.WriteLine("==========MENU==========");
    Console.WriteLine("1 - Admin");
    Console.WriteLine("2 - Client");
    Console.WriteLine("3 - Exit");
    MainChoice = Convert.ToInt32(Console.ReadLine());
    if (MainChoice == 1)
    {
        Admin admin = new Admin("admin", "admin", new DateTime(2000, 1, 1), "0000000000000", "1111", TestBase);
        Console.WriteLine("Welcome " + admin.Name);
        Console.WriteLine("What do you want to do?");
        do
        {
            Console.WriteLine("==========MENU==========");
            Console.WriteLine("1 - View Clients");
            Console.WriteLine("2 - View Cards");
            Console.WriteLine("3 - Delete Client");
            Console.WriteLine("4 - Exit");
            Console.WriteLine("Your choice?");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    admin.ViewClientBase();
                    break;
                case 2:
                    admin.ViewCardBase();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }
        } while (choice != 4);
    }
    else if (MainChoice == 2)
    {
        Console.WriteLine("Oh! You need to sign up first!");
        MainMenu.SignUp();
        Console.WriteLine("What do you want to do?");
        do
        {
            Console.WriteLine("==========MENU==========");
            Console.WriteLine("1 - See my data");
            Console.WriteLine("2 - See my accounts");
            Console.WriteLine("3 - Open a new account");
            Console.WriteLine("4 - Top up a card");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("Your choice?");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    MainMenu.ViewClientData();
                    break;
                case 2:
                    MainMenu.ViewAccounts();
                    break;
                case 3:
                    MainMenu.OpenAccount();
                    break;
                case 4:
                    MainMenu.TopUpAccount();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }
        } while (choice != 5);
    }
    else if (MainChoice == 3)
    {
        Console.WriteLine("Bye!");
    }
} while (MainChoice != 3);