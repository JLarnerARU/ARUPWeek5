String[,] addressBook = new String[10, 2];
int option, bookItem;
String name, email;

do
{
    Console.WriteLine("Please choose an option");
    Console.WriteLine("1. Add a record");
    Console.WriteLine("2. Delete a record");
    Console.WriteLine("3. Print all records");
    Console.WriteLine("4. Exit");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            do
            {
                Console.WriteLine("Where would you like to add a record?");
                bookItem = Convert.ToInt32(Console.ReadLine());
            } while (bookItem > addressBook.Length / 2);

            Console.WriteLine("Please type a name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter an email address");
            email = Console.ReadLine();

            addressBook[bookItem, 0] = name;
            addressBook[bookItem, 1] = email;

            break;

        case 2:
            break;

        case 3:
            break;

        default:
            break;

    }
} while (option != 4);

