using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace menu {

  class consoleapp {

    static void Main(string[] args) {

      bool showMenu = true;
      while (showMenu) {

        showMenu = MainMenu();

      }
    }
      private static bool MainMenu() {
        Console.Clear();
        Console.WriteLine("Choose your option:");
        Console.WriteLine("1) View Accounts");
        Console.WriteLine("2) View Account by Number");
        Console.WriteLine("3) Exit");
        Console.Write("\r\nSelect an option: ");

        switch (Console.ReadLine()) {
          case "1":
            ViewAccounts();
            return true;
          case "2":
            AccountNumber();
            return true;
          case "3":
              return false;
          default:
                return false;
        }
      }

      private static void ViewAccounts() {

        var accounts = ReadAccounts();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("| Number | Balance | Label | Owner |");
            Console.WriteLine("------------------------------------");
        foreach (var account in accounts) 
        {
            if (account.Number == 42) 
            {
            Console.WriteLine("|   " + account.Number + "   |       " + account.Balance + "| " + account.Label + "| " + account.Owner + "    |"); 
            Console.WriteLine("------------------------------------"); 
            } else if (account.Label == "Savings") {
            Console.WriteLine("| " + account.Number + " |       " + account.Balance + "|" + account.Label + "| " + account.Owner + "    |");
            Console.WriteLine("------------------------------------");
            } else {
            Console.WriteLine("| " + account.Number + " |       " + account.Balance + "| " + account.Label + "| " + account.Owner + "    |");
            Console.WriteLine("------------------------------------");
            }


        }
        Console.ReadLine();
      }

      private static void AccountNumber() {

        Console.WriteLine("Enter an Owner ID: ");
        var id = Console.ReadLine();

        var accounts = ReadAccounts();

        foreach (var account in accounts) {
          if (account.Owner == Convert.ToInt32(id)) {
            Console.WriteLine("Account number: " + account.Number);
            Console.WriteLine("Balance: " + account.Balance);
            Console.WriteLine("Label: " + account.Label);
            Console.WriteLine("Owner: " + account.Owner);             
          }
        }
        Console.ReadLine();
        
      }
      public class Account
    {
        public int Number { get; set; }
        public int Balance { get; set; }
        public string Label { get; set; }
        public int Owner { get; set; }
        
        public override string ToString() {
            return JsonSerializer.Serialize<Account>(this);
        }
    }
       static IEnumerable<Account> ReadAccounts()
        {
            String file = "../data/account.json";

            using (StreamReader r = new StreamReader(file))
            {
                string data = r.ReadToEnd();
                //Console.WriteLine(data);

                var json = JsonSerializer.Deserialize<Account[]>(
                    data,
                    new JsonSerializerOptions {
                        PropertyNameCaseInsensitive = true
                    }
                );

                //Console.WriteLine(json[0]);
                return json;
            }
        }


  
  }
}
