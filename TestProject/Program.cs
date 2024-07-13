// See https://aka.ms/new-console-template for more information
/*The following code the message into characters, reverses them, count the o's,
convert it back and print it out.*/

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Random coin = new Random();
// int flip = coin.Next(0, 2);

// Console.WriteLine((flip == 0) ? "Heads" : "Tails");

// string permission = "Admin|Manager";
// int level = 53;

// if(permission.Contains("Admin"))
// {
//     if(level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else 
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if(permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else 
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// string name = "steve";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");

// int[] numbers = { 4, 8, 15, 16, 23, 42 };

// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42) found = true;
    
// }

// if (found) Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");

// int first = 1;
// if(first > 0)
// {
//     int second = 8;
//     first += second;
// }

// Console.WriteLine(first);

// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";
// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch(product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch(product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

// Console.WriteLine($"Product: {size} {color} {type}");

//FizzBuzz Challenge
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") names[i] = "Sammy";
// foreach (var name in names) Console.WriteLine(name);

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - FizzBuzz");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine($"{i} - Fizz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - Buzz");
//     }
//     else
//     {
//         Console.WriteLine($"{i}");
//     }
// }
// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if(monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// Project I

// string? userInput;
// string valueEntered = "";
// int numericVal = 0;
// bool validNum = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     userInput = Console.ReadLine();

//     if(userInput != null)
//     {
//         valueEntered = userInput;
//     }

//     validNum = int.TryParse(valueEntered, out numericVal);

//     if(validNum == true)
//     {
//         if (numericVal <= 5 || numericVal >= 10)
//         {
//             validNum = false;
//             Console.WriteLine($"You entered {numericVal}. Please enter a number between 5 and 10");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
//     }
// } while(validNum == false);

// Console.WriteLine($"Your input value ({userInput}) has been accepted");

// Prroject II
string? userInput;
string role = "";
// int numericVal = 0;
bool validNum = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    userInput = Console.ReadLine().Trim().ToLower();

    if(userInput != null)
    {
        if (role.Contains("Administrator" || "Manager" || "User"))
        {
            validNum = true;
        }
        else
        {
            Console.WriteLine("The role name that you entered, is not valid. Enter your role name (Administrator, Manager, or User)");
   Administrator");
        }
    }
} while(validNum == false);

// validNum = int.tryParse(userInput, out numericVal);

Console.WriteLine($"Your input value ({userInput}) has been accepted");