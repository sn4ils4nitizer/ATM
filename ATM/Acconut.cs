using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace ATM
{
    public class Account
    {
        private int accountNumber;
        private string accountName;
        private string accountLName;
        private string accountType;
        private string password;
        private double balance;

        // properties - function like shorthand getters
        public int AccountNumber => accountNumber;
        public string AccountName => accountName;
        public string AccountLName => accountLName;
        public string AccountType => accountType;
        public string Password => password;
        public double Balance => balance;

        public Account(int accountNumber, string accountName, string accountLName, string accountType, string password, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.accountLName = accountLName;
            this.accountType = accountType;
            this.password = password;
            this.balance = balance;
        }

        //TODO
        //account operations
        public void withdrawal(double amount, string filePath)
        {
            balance -= amount;
            LogTransaction(amount.ToString(), "withdrawal", filePath);
        }

        public void deposit(double amount, string filePath)
        {
            balance += amount;
            LogTransaction(amount.ToString(), "deposit", filePath);
        }

        public void setType(string type)
        {
            this.accountType = type;
        }

        // Serialization source
        // https://stackoverflow.com/questions/29841503/json-serialization-deserialization-in-asp-net-core
        // Used System.Text.Json since it's already built into .NET - at first
        // had to switch to Newtonsoft.Json because it is suppported in this version of .NET framework
        public void SaveToJson(string folderPath)
        {
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, $"{accountName}.json");
            try
            {
                string jsonString = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText(filePath, jsonString);
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"Serialization failed: {jsonEx.Message}");
            }
            
            
        }

        public static Account LoadFromJson(string folderPath, string accountName) 
        { 
            string filePath = Path.Combine(folderPath, $"{accountName}.json");
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Account {accountName} does not exist.");
            }
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Account>(jsonString);
        }

        //https://www.tutorialspoint.com/chash-program-to-append-text-to-an-existing-file
        //Appending text to a file is easy. FIle can be created same way JSONs are
        //getting the folder path is still a pain tho and has to me mapped from aspx.cs for Server.MapPath to work
        public void LogTransaction(string amount, string transactionType, string folderPath)
        {
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, $"{accountName}_log.csv");

            string logEntry = accountNumber+","+transactionType+","+amount+","+balance+","+$"{DateTime.Now}";
            File.AppendAllText(filePath, logEntry + Environment.NewLine);
        }
    }
}