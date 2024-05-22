// See https://aka.ms/new-console-template for more information
string[] fraudulentIDs = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach (string fraudulentID in fraudulentIDs)
{
    if(fraudulentID.StartsWith("B"))
    {
        Console.WriteLine(fraudulentID);
    }
}