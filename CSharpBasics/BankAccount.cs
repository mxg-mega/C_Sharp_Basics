public class BankAccount
{
    public string AccountHolder { set; get; }
    private decimal balance = 0;
    public decimal Balance { get { return balance; } }
    public string AccountNumber { set; get; }


    public BankAccount(string accountName, string accountNumber)
    {
        this.AccountNumber = accountNumber;
        this.AccountHolder = accountName;
    }
    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposit successful. New balance: {balance}");
    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawal successful. New balance: {balance}");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient Funds");
        }
        else
        {
            Console.WriteLine("Invalid amount");
        }
    }
    public decimal GetBalance()
    {
        Console.WriteLine($"the current balance is {balance}");
        return Balance;
    }
}