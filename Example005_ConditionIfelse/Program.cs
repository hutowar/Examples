Console.Write("Enter your username: ");
String username = Console.ReadLine();
String Password = "david";
if (username.ToLower() == "david"){
    Console.Write("Access allowed. Welcome " + username + "!");
}
else {
    Console.Write("Access denied.");
}