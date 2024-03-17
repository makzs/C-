//int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");

Console.WriteLine("-------------------------------");

int saleAmount = 1001;
 int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Console.WriteLine("-------------------------------");

Random coin = new Random();
int valor = coin.Next(101);
String resultado = valor > 50 ? "heads" : "tails";

Console.WriteLine($"O resultado é {resultado}");

Console.WriteLine("-------------------------------");

string permission = "Admin";
int level = 55;

if (permission.Contains("Admin") && level > 55){
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55){
    Console.WriteLine("Welcome, Admin user");
}
else if (permission.Contains("Manager") && level >= 20){
    Console.WriteLine("Contact an Admin for access");
}
else if (permission.Contains("Manager") && level < 20){
    Console.WriteLine("You do not have sufficient privileges");
}
else{
    Console.WriteLine("You do not have sufficient privileges");
}