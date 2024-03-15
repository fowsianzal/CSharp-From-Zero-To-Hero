using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            Console.WriteLine(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances));
            // - FindPersonWithBiggestLoss
            Console.WriteLine(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances));
            // - FindRichestPerson
            Console.WriteLine(BalanceStats.FindRichestPerson(PeoplesBalances.Balances));
            // - FindMostPoorPerson
            Console.WriteLine(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances));
            





        }

        //public static string Build(string message, int padding)
        //{
        //    var lines = message.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

        //    int tableWidth = lines.Max(line => line.Length + 2 * padding);

        //    var topBorder = "+" + new string('-', tableWidth) + "+";

        //    var tableContent = new StringBuilder();
        //    tableContent.AppendLine(topBorder);

        //    for (int i = 0; i < padding; i++)
        //    {
        //        tableContent.AppendLine($"|{new string(' ', tableWidth)}|");
        //    }

        //    foreach (var line in lines)
        //    {
        //        var paddedLine = line.PadLeft(line.Length + padding).PadRight(tableWidth);
        //        tableContent.AppendLine($"|{paddedLine}|");
        //    }

        //    for (int i = 0; i < padding; i++)
        //    {
        //        tableContent.AppendLine($"|{new string(' ', tableWidth)}|");
        //    }

        //    tableContent.AppendLine(topBorder);
        //    return tableContent.ToString();
        //}

        //public static string FindHighestBalanceEver(string[] peopleAndBalances)
        //{
        //    if (peopleAndBalances == null || peopleAndBalances.Length == 0)
        //    {
        //        return "N/A.";
        //    }
        //    else
        //    {
        //        decimal highestBalance = 0;
        //        //string highestBalancePerson = null;
        //        List<string> highestBalancePerson = new List<string>();

        //        foreach (var entry in peopleAndBalances)
        //        {
        //            var parts = entry.Split(", ");
        //            if (parts.Length >= 2)
        //            {
        //                string person = parts[0];
        //                decimal balance = 0;

        //                for (int i = 1; i < parts.Length; i++)
        //                {
        //                    if (decimal.TryParse(parts[i], out decimal amount))
        //                    {
        //                        if (amount > balance)
        //                        {
        //                            balance = amount;
        //                        }
        //                    }
        //                }

        //                if (balance > highestBalance)
        //                {
        //                    highestBalance = balance;
        //                    highestBalancePerson.Clear();
        //                    highestBalancePerson.Add(person);
        //                }
        //                else if (balance == highestBalance)
        //                {
        //                    balance = highestBalance;
        //                    highestBalancePerson.Add(person);
        //                }
        //            }
        //        }
        //        string highestBalancePersonString = string.Join(", ", highestBalancePerson);
        //        if (highestBalancePerson.Count > 1)
        //        {
        //            int lastCommaIndex = highestBalancePersonString.LastIndexOf(",");
        //            highestBalancePersonString = highestBalancePersonString.Remove(lastCommaIndex, 1).Insert(lastCommaIndex, " and");
        //        }
        //        return $"{highestBalancePersonString} had the most money ever. ¤{highestBalance}.";
        //    }

        //}

        //public static string FindMostPoorPerson(string[] peopleAndBalances)
        //{
        //    if (peopleAndBalances == null || peopleAndBalances.Length == 0)
        //    {
        //        return "N/A.";
        //    }
        //    else
        //    {
        //        decimal lowestBalance = decimal.MaxValue;
        //        List<string> mostPoorPersons = new List<string>();

        //        foreach (var entry in peopleAndBalances)
        //        {
        //            var parts = entry.Split(", ");
        //            if (parts.Length >= 2)
        //            {
        //                string person = parts[0];
        //                decimal balance = 0;

        //                for (int i = 1; i < parts.Length; i++)
        //                {
        //                    if (decimal.TryParse(parts[i], out decimal amount))
        //                    {
        //                        if (amount < lowestBalance)
        //                        {
        //                            lowestBalance = amount;
        //                            mostPoorPersons.Clear();
        //                            mostPoorPersons.Add(person);
        //                        }
        //                        else if (amount == lowestBalance)
        //                        {
        //                            lowestBalance = amount;
        //                            mostPoorPersons.Add(person);
        //                        }
        //                    }
        //                }


        //            }
        //        }
        //        string mostPoorPersonString = string.Join(", ", mostPoorPersons);
        //        if (mostPoorPersons.Count > 1)
        //        {
        //            int lastCommaIndex = mostPoorPersonString.LastIndexOf(",");
        //            mostPoorPersonString = mostPoorPersonString.Remove(lastCommaIndex, 1).Insert(lastCommaIndex, " and");
        //            return $"{mostPoorPersonString} have the least money. ¤{lowestBalance}.";
        //        }
        //        return $"{mostPoorPersonString} has the least money. ¤{lowestBalance}.";
        //    }
        //}

        //public static string FindRichestPerson(string[] peopleAndBalances)
        //{
        //    if (peopleAndBalances == null || peopleAndBalances.Length == 0)
        //    {
        //        return "N/A.";
        //    }
        //    else
        //    {
        //        decimal highestBalance = 0;
        //        //string highestBalancePerson = null;
        //        List<string> highestBalancePerson = new List<string>();

        //        foreach (var entry in peopleAndBalances)
        //        {
        //            var parts = entry.Split(", ");
        //            if (parts.Length >= 2)
        //            {
        //                string person = parts[0];
        //                decimal balance = 0;

        //                for (int i = 1; i < parts.Length; i++)
        //                {
        //                    if (decimal.TryParse(parts[i], out decimal amount))
        //                    {
        //                        if (amount > balance)
        //                        {
        //                            balance = amount;
        //                        }
        //                    }
        //                }

        //                if (balance > highestBalance)
        //                {
        //                    highestBalance = balance;
        //                    highestBalancePerson.Clear();
        //                    highestBalancePerson.Add(person);
        //                }
        //                else if (balance == highestBalance)
        //                {
        //                    balance = highestBalance;
        //                    highestBalancePerson.Add(person);
        //                }
        //            }
        //        }
        //        string highestBalancePersonString = string.Join(", ", highestBalancePerson);
        //        if (highestBalancePerson.Count > 1)
        //        {
        //            int lastCommaIndex = highestBalancePersonString.LastIndexOf(",");
        //            highestBalancePersonString = highestBalancePersonString.Remove(lastCommaIndex, 1).Insert(lastCommaIndex, " and");
        //            return $"{highestBalancePersonString} are the richest people. ¤{highestBalance}.";
        //        }
        //        return $"{highestBalancePersonString} is the richest person. ¤{highestBalance}.";

        //    }
        //}

        

        //public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        //{

        //    // Check for invalid input
        //    if (peopleAndBalances == null || peopleAndBalances.Length == 0)
        //    {
        //        return "N/A.";
        //    }

        //    decimal highestLossEver = decimal.MaxValue;
        //    string personWithHighestLoss = null;
        //    bool isTie = false;

        //    foreach (var personData in peopleAndBalances)
        //    {
        //        var parts = personData.Split(',');
        //        if (parts.Length >= 2)
        //        {
        //            string person = parts[0];

        //            decimal lossForCurrentPerson = decimal.MaxValue;
        //            for (int i = 1; i < parts.Length-1; i++)
        //            {
        //                if (decimal.TryParse(parts[i+1], out decimal secondAmount) && decimal.TryParse(parts[i], out decimal firstAmount))
        //                {
        //                    decimal lossValue = secondAmount - firstAmount;
        //                    if (lossValue < lossForCurrentPerson)
        //                    {
        //                        lossForCurrentPerson = lossValue;

        //                    }
        //                }
        //            }

        //            if (lossForCurrentPerson < highestLossEver)
        //            {
        //                highestLossEver = lossForCurrentPerson;
        //                personWithHighestLoss = parts[0];
        //                isTie = false;
        //            }
        //            else if (lossForCurrentPerson == highestLossEver)
        //            {
        //                isTie = true;
        //            }
        //        }
        //    }
        //    if (isTie)
        //    {
        //        return "N/A.";
        //    }
        //    else if (personWithHighestLoss != null)
        //    {
        //        return $"{personWithHighestLoss} lost the most money. -¤{Math.Abs(highestLossEver)}.";
        //    }
        //    return "N/A.";
        //}
    }
}



            
