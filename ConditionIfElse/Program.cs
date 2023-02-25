Console.Write("put the user name:");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
  Console.WriteLine("Hooray,it's Masha!"); 
}
else
{
    Console.Write("Hello,");
    Console.WriteLine(username);
}