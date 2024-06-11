
using LPBank;

Console.WriteLine("Hello from LPBank!");
Console.WriteLine("------------------------------------------");

Console.WriteLine("How may we help you? Key in 1 for Deposit, 2 for Withdraw and 3 for Transfer");
var choice = int.Parse(Console.ReadLine());

if(choice == 3)
{
    Console.WriteLine("From Account No? : ");
    var fromAccNo = Console.ReadLine();

    Console.WriteLine("To Account No?: ");
    var toAccNo = Console.ReadLine();

    Console.WriteLine("Amount? : ");
    var amount = int.Parse(Console.ReadLine());

    var fromAcc = new Account(fromAccNo, 100000);
    var toAcc = new Account(toAccNo, 100000);
    AccountTransferService.Transfer(fromAcc, toAcc, amount);

    Console.WriteLine($"After Transfer => Account No : {fromAcc.AccNo} , Balance : {fromAcc.Balance}");
    Console.WriteLine($"After Transfer => Account No : {toAcc.AccNo} , Balance : {toAcc.Balance}");
}