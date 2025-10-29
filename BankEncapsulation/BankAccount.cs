namespace BankEncapsulation;

public class BankAccount
{
    private double _balance;

    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public double GetBalance()
    {
        return _balance;
    }
    
}