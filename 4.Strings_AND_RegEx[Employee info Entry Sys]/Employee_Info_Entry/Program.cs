using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employee_Info_Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************Welcome to Employee Information Entry System*********************");
            //  Readfromfile();
            Initialize_menu();
        }

        public static void Initialize_menu()
        {
            const string namepattern = @"^[A-Z][a-z]+$", numberpattern = @"\+\S+";
            const string mailpattern = @"(\S+)\@(\S+)\.(\S+)$", urlpattern = @"\b(\S+)://([^:]+)(?:/(\S+))?(?::(\S+))?\b";
            const string userpattern = @"\$\S*\$", pwdpattern = @"\@\S*\@";
            while (true) {
                Console.WriteLine("_______________________________________________________________________________");
                Console.WriteLine("|_________________________________*MENU*_______________________________________|");
                Console.WriteLine("1.Get all Phone Numbers");
                Console.WriteLine("2.Get all Mail ID's");
                Console.WriteLine("3.Get all URL's");
                Console.WriteLine("4.Get all Usernames & Passwords");
                Console.WriteLine("5.Get all Names");
                Console.WriteLine("6.View Database");
                Console.WriteLine("7.Terminate the Program");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("NUMBERS");
                        ReturnData(numberpattern);
                        break;

                    case 2:
                        Console.WriteLine("MAIL ID's");
                        ReturnData(mailpattern);
                        break;

                    case 3:
                        Console.WriteLine("URL'S");
                        ReturnData(urlpattern);
                        break;

                    case 4:
                        Console.WriteLine("Usernames\tPassword");
                        ReturnData(userpattern, pwdpattern);
                        break;

                    case 5:
                        Console.WriteLine("FNAME\tLASTNAME");
                        ReturnData(namepattern);
                        break;

                    case 6:
                        Console.WriteLine("FNAME\tLNAME\tMNO\t\tMail Id's\t\tURL\t\t\tUsername    Pwd");
                        ReturnData(namepattern, numberpattern, mailpattern, urlpattern, userpattern, pwdpattern);
                        break;

                    case 7:
                        Console.WriteLine("The program is terminated");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You have entered an Invalid Choice :( ");
                        Console.WriteLine("Please try again");
                        break;
                }
            }
        }

        public static void ReturnData(params string[] pattern) {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("C:/Users/chinnu/Documents/Visual Studio 2015/Projects/CSharpLab/4.Strings_AND_RegEx[Employee info Entry Sys]/Employee_Info_Entry/Employee.txt"))
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        char tabdelem = '\t';
                        String[] splitfileds = line.Split(tabdelem);
                        foreach (string fieldval in splitfileds)
                        {
                            foreach (string currentpattern in pattern) {
                                if ((Regex.Match(fieldval, currentpattern)).Success)
                                {
                                    Console.Write(fieldval);
                                    if (pattern.Count() < 5)
                                    {
                                        Console.Write("\t");
                                    }
                                    else {
                                        Console.Write("  ");
                                    }
                                }
                                
                            }   
                        }
                        Console.Write("\n");
                     }
                }
            }
            catch (Exception e)
            {

                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
        
    }
}
