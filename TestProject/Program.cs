// See https://aka.ms/new-console-template for more information
/*The following code the message into characters, reverses them, count the o's,
convert it back and print it out.*/
string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage) 
{ 
    if (i == 'o') { x++; } 
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");