using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8.Banking_Operations
{
    public class BankAccount {
        public string name;
        public string accno;
        public decimal accbal;
    }

    public class TransactionLog {
        public string logname;
        public string acc_no;
    }

    public class Bankbalance {
        public decimal balanceamount=100000;
    }

    class Program
    {

        static List<TransactionLog> log = new List<TransactionLog>();
        static List<BankAccount> account = new List<BankAccount>();
       
        
        private static decimal val = 1000;
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("|_____________________________|Banking Operations|_____________________________|");
            
            
            Console.WriteLine(bal);
            InitializeAccounts(account);
            CheckPwd(account);
        }

        public static string ReadPassword()
        {
            string password = ""; ConsoleKeyInfo info = Console.ReadKey(true); while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace) { Console.Write("*"); password += info.KeyChar; }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters 
                        password = password.Substring(0, password.Length - 1); // get the location of the cursor 
                        int pos = Console.CursorLeft; // move the cursor to the left by one character 
                        Console.SetCursorPosition(pos - 1, Console.CursorTop); // replace it with space
                        Console.Write(" "); // move the cursor to the left by one character again 
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            } // add a new line because user pressed enter at the end of their password 
            Console.WriteLine();
            return password;
        }

        public static void CheckPwd(List<BankAccount> account)
        {
            lOGIN:
            Console.WriteLine("NAME:");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine("Acc No:");
            string accno = ReadPassword();
            int index = -1;
            index = account.FindIndex(a => a.name.Equals(name) && a.accno.Equals(accno));
            if (index != -1)
            {
                //InitializeMenu(account, index, log);
                var t = new Thread(()=>InitializeMenu(account, index, log));
                t.Start();
            }
            else { Console.WriteLine("Bad Login"); goto lOGIN; }
        }
        
        public static void InitializeMenu(List<BankAccount> account,int index, List<TransactionLog> log) {
            Console.WriteLine("Thread Id is"+Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Welcome " + account[index].name +"\t["+account[index].accno+"]");
            Console.WriteLine("Your Current Acc_Balanace is " + account[index].accbal);
            Console.WriteLine("1.Transfer Money");
            Console.WriteLine("2.Deposit Money");
            Console.WriteLine("3.Check Balance");
            Console.WriteLine("4.Transaction History");
            Console.WriteLine("5.Log Out");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    Transfer_Money(account, index, log);
                    break;
                case 2:Deposit_Money(account, index, log);
                    break;
                case 3:CheckBalance(account, index, log);
                    break;
                case 4:Transaction_history(account, index, log);
                    break;
                case 5:
                    CheckPwd(account);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    InitializeMenu(account, index,log);
                    break;

            }
        }

        public static void CheckBalance(List<BankAccount> account, int index, List<TransactionLog> log) {
            Console.WriteLine("|---------------------------Account Details---------------------|");
            Console.WriteLine("|\tAccount Holder Name\t{0}\t\t\t\t|",account[index].name);
            Console.WriteLine("|\tAccount Number\t\t{0}\t\t\t\t|" , account[index].accno);
            Console.WriteLine("|\tAccount Balance\t\t{0}\t\t\t\t|" , account[index].accbal);
            Console.WriteLine("|---------------------------------------------------------------|");
            InitializeMenu(account, index, log);
        }

        public static void Transaction_history(List<BankAccount> account, int index, List<TransactionLog> log) {
            string currnt_accno = account[index].accno;
            List<TransactionLog> Transactions = log.FindAll(a => a.acc_no.Equals(currnt_accno));
            for (int i=0; i < Transactions.Count;i++)
            {
                Console.WriteLine(Transactions[i].logname);
            }
            InitializeMenu(account, index, log);
        }

        //  private static object lockMethod = new object();

        private static Bankbalance lockMethod = new Bankbalance();
        
        public static void Transfer_Money(List<BankAccount> account, int index,List<TransactionLog> log) {

            lock (lockMethod)
            {
                Console.WriteLine("Enter the amount to be Transferred");
                decimal t_amt = Convert.ToDecimal(Console.ReadLine());
                decimal curr_amt = lockMethod.balanceamount;
                string currnt_accno = account[index].accno;
                if (t_amt < curr_amt)
                {
                    Console.WriteLine("Enter the Account No to be transferred : ");
                    string t_acc_no = Console.ReadLine();
                    int trans_account = account.FindIndex(a => a.accno.Equals(t_acc_no));
                    account[trans_account].accbal += t_amt;//Amount Transferred
                    account[index].accbal -= t_amt;//Amount Deducted
                    Why("Transferring");
                    Console.WriteLine("Transferred Successfully");
                    log.Add(new TransactionLog { logname = "" + System.DateTime.Now + "\t" + "Transferred FROM " + currnt_accno + " TO " + t_acc_no, acc_no = currnt_accno });
                    InitializeMenu(account, index, log);
                }
                else {
                    Console.WriteLine("Insuffient Funds");
                    InitializeMenu(account, index, log);
                }
            }
        }

        public static void Deposit_Money(List<BankAccount> account, int index, List<TransactionLog> log)
        {
            lock (lockMethod) {
                Console.WriteLine("Enter the amount to be Deposit");
                decimal t_amt = Convert.ToDecimal(Console.ReadLine());
                string currnt_accno = account[index].accno;
                if (t_amt > 0)
                {
                    account[index].accbal += t_amt;//Amount Debitted
                    Why("Debitting");
                    Console.WriteLine("Debitted Successfully");
                    log.Add(new TransactionLog { logname = "" + System.DateTime.Now + "\t" + "Debitted to " + currnt_accno + " an amount of  " + account[index].accbal, acc_no = currnt_accno });
                    InitializeMenu(account, index, log);
                }
                else
                {
                    Console.WriteLine("Incorrect Funds");
                    InitializeMenu(account, index, log);
                }
            }
        }

        public static void InitializeAccounts(List<BankAccount> account) {
            account.Add(new BankAccount { name="SUHAAS",accno="1001",accbal=5000});
            account.Add(new BankAccount { name = "SNEHAL", accno = "1002", accbal = 10000 });
            account.Add(new BankAccount { name = "ARUNA", accno = "1003", accbal = 15000 });
            account.Add(new BankAccount { name = "SRINIVAS", accno = "1004", accbal = 20000 });
        }

        static public void Why(string msg)
        {
            Console.Write(msg);
            using (var progress = new ProgressBar())
            {
                for (int i = 0; i <= 100; i++)
                {
                    progress.Report((double)i / 100);
                    Thread.Sleep(20);
                }
            }
            Console.WriteLine("Done.");
        }
    }
}
