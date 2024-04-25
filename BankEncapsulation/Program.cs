namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank_Account ba = new Bank_Account();
            Console.WriteLine("How much $$$ you want to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);
            double userBalance = ba.GetBalance();

            Console.WriteLine($"your current balance is: {userBalance, 0:c}");   
        }
    }
}
