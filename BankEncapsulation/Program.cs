namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ba =  new BankAccount();
            
            Console.WriteLine("How much money would you like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            
            ba.Deposit(amountToDeposit);
            var userBalance = ba.GetBalance();
            
            Console.WriteLine($"Your current balance is: {userBalance, 0:c}");
        }
    }
}
