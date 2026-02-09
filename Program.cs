// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class PaymentTimeoutException : Exception
{
    public PaymentTimeoutException(string message) : base(message)
    {
    }
}

class PaymentSystem
{
    public void Pay(double balance, double amount)
    {
    if (amount > balance)
        {
            throw new InsufficientBalanceException("Insufficient balance for this payment.");
        }

        if (amount == 500)
        {
            throw new PaymentTimeoutException("Payment process timed out.");
        }

        Console.WriteLine("Payment completed successfully.");
    }
}

class Program
{
    static void Main()
    {
     PaymentSystem payment = new PaymentSystem();

    try
    {
      payment.Pay(300, 500);
        }
    catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Balance Error: " + ex.Message);
        }
    catch (PaymentTimeoutException ex)
        {
            Console.WriteLine("Timeout Error: " + ex.Message);
        }
       
    catch (Exception ex)
        {
            Console.WriteLine("General Error: " + ex.Message);
        }
    finally
        {
            Console.WriteLine("Payment attempt finished.");
        }
    }
}

