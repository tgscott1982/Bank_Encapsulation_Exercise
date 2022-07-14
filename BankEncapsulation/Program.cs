using BankEncapsulation;

BankAccount account1 = new BankAccount();

Console.WriteLine("Hello! How much would you like to deposit today?\n");

var depoAmmount = double.Parse(Console.ReadLine()); //Convert.ToInt32 won't allow decimals - TryParse unnecessary
                                                       //if not going to loop for a continuous interactive deposit simulation

account1.Deposit(depoAmmount);

Console.WriteLine($"\nDeposit amount: ${depoAmmount}\n\nNew Balance: ${account1.GetBalance()}");