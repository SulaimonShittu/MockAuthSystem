using MockAuthSystem;

Console.WriteLine("Please enter a valid username : ");
String? username = Console.ReadLine();

Console.WriteLine("Please enter the correspond password : ");
String? password = Console.ReadLine();

List<User> registeredUsers =
[
    new User { UserName = "Babatunde", Password = "baba1977!@" },
    new User { UserName = "Salami", Password = "Sala98__0" },
    new User { UserName = "Chizara", Password = "-_Zara_-9" },
    new User { UserName = "Jessica", Password = "hessy04__" },
    new User { UserName = "Uduak", Password = "-daka*2-" }
];

if (Authorize(username, password))
{
    Console.WriteLine("You are now logged in successfully");
}
else
{
    Console.WriteLine("Either the username & password you entered is not correct, try again.");
}

bool Authorize(String? userName, string? password)
{
    if (registeredUsers.Contains(new User { UserName = userName, Password = password}))
    {
        return true;
    }

    return false;
}