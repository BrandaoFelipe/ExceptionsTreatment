﻿using Exceptions_Treatment.Entitites;
using System.Globalization;
using Exceptions_Treatment.Entitites.Exceptions;
using System.Linq.Expressions;
internal class Program
{
    private static void Main(string[] args)
    {
        try //BLOCO TRY DEVE ESTAR ONDE ELE VAI PRECISAR PROCURAR POR EXCESSÕES
            
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       
            account.Withdraw(amount);

            Console.WriteLine(account);
        }
        catch (DomainException e)
        {
            Console.WriteLine("Error in account: " + e.Message);
        } 
        catch(FormatException e)
        {
            Console.WriteLine("Error in format: " + e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine("Unexpected error!" + e.Message);
        }
        



    }
}