Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("----- Welcome, soldier! -----\n");
Console.ForegroundColor = ConsoleColor.White;


bool result1 = true;
bool result2 = false;
bool result3;

do
{
    Console.WriteLine("P. Pick up AK-47\n" +
    "Any other key. Quit");

    string menu1 = Console.ReadLine();

    if (menu1.ToLower() == "p")
    {
        Console.Clear();

        do
        {
            int ammo = 10;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The number of ammo in weapon is: {ammo}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Choose a shooting mode:\n" +
                "S. Single bursts\n" +
                "A. Auto\n" +
                "Any other key. Put down AK-47");

            string menu2 = Console.ReadLine();

            if (menu2.ToLower() == "s")
            {
                do
                {
                    for (int i = 10; i > 0; i--)
                    {
                        Console.WriteLine("Press any key to shoot");
                        Console.ReadLine();
                        ammo--;
                        Console.WriteLine($"\nRemaining ammo: {ammo}");
                    }

                    Empty();

                    Console.WriteLine("R. Reload\n" +
                        "Any other key. Reload and change shooting mode");

                    string menu3 = Console.ReadLine();
                    Console.Clear();

                    if (menu3.ToLower() == "r")
                    {
                        ammo = 10;
                        result3 = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Successful reload");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        ammo = 10;
                        result3 = false;
                    }

                } while (result3);

                result2 = true;
            }

            if (menu2.ToLower() == "a")
            {
                do
                {
                    Console.WriteLine("Press any key to shoot");
                    Console.ReadLine();

                    for (int i = 10; i > 0; i--)
                    {
                        ammo--;
                        Console.WriteLine($"\nRemaining ammo: {ammo}");
                    }

                    Empty();

                    Console.WriteLine("R. Reload\n" +
                        "Any other key. Reload and change shooting mode");

                    string menu3 = Console.ReadLine();
                    Console.Clear();

                    if (menu3.ToLower() == "r")
                    {
                        ammo = 10;
                        result3 = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Successful reload");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        ammo = 10;
                        result3 = false;
                    }

                } while (result3);

                result2 = true;
            }

            if(menu2.ToLower() != "a" && menu2.ToLower() != "s")
            {
                result2 = false;
            }
        } while (result2);
    }

    else
    {
        result1 = false;
    }
} while (result1);






static void Empty()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Your weapon is empty");
    Console.ForegroundColor = ConsoleColor.White;
}