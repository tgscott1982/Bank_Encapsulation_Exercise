using BankEncapsulation;

BankAccount account1 = new BankAccount();

Console.WriteLine("Hello! How much would you like to deposit today?\n");

var ammount = double.Parse(Console.ReadLine()); //Convert.ToInt32 won't allow decimals - TryParse unnecessary
                                                       //if not going to loop for a continuous interactive deposit simulation
account1.Deposit(ammount);

Console.WriteLine($"\nYour updated balance is {account1.GetBalance()}.");

Console.WriteLine("\nHow much would you like to withdraw?");

var amount = double.Parse(Console.ReadLine());

account1.Withdraw(amount);

Console.WriteLine("\nThank you.\n");

Console.WriteLine($"Your remaining account balance is {account1.GetBalance()}");