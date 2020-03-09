using System;
using System.IO;

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

      private static bool ViewAccounts() {
      
      try {

        String st = File.ReadAllText("../data/account.json");
        Console.WriteLine(st);

      } catch {
        Console.WriteLine("JSON could not be read");
        Console.WriteLine("e.Message");
      }
      return true;
      }

      private static void AccountNumber() {

      }

  
  }
}
