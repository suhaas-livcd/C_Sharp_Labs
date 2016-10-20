using System;
using System.Collections.Generic;

namespace Integer_Stack_Exception_Handling_5
{
    //To raise an Exception if the input in non-integer
    class NonInteger_Exception:ApplicationException {

        public NonInteger_Exception(String msg) {
            Console.WriteLine("\n---------------------EXCEPTION------------------------------");
            Console.WriteLine("|-->Main:The \'FORMAT\' of the input should be integer\n|-->Msg: {0}",msg);
            Console.WriteLine("|-->Fix: Please try to insert integer value");
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
    //To raise an Exception if the input if Stack is empty
    class StackEmpty_Exception : ApplicationException {
        public StackEmpty_Exception(String msg)
        {
            Console.WriteLine("\n---------------------EXCEPTION------------------------------");
            Console.WriteLine("|-->Main:For \'POP\' or \'DISPLAY\' the \'SIZE\' of the stack should be > 0\n|-->Msg: {0}", msg);
            Console.WriteLine("|-->Fix: Please try to \'PUSH\' values");
            Console.WriteLine("--------------------------------------------------------------");
        }
    }

    class Program
    {
        //initialize the size of stack(default is 5)
        static int Stack_Size = 5;
        //Main Control Method
        static void Main(string[] args)
        {
            //Design
            Console.WriteLine("**********************WELCOME User to operate INTEGER STACK [Deafult size->5]********************");
            Console.WriteLine();
            //Initialising Starting default capacity to 5
            Stack<int> stackinteger = new Stack<int>(5);
            //Calling Menu Function
            Initialize_Menu(stackinteger);
        }
        //To Display Menu
        public static void Initialize_Menu(Stack<int> stackinteger)
        {
            Console.WriteLine("_______________________________________________________________________________");
            Console.WriteLine("|_________________________________*MENU*_______________________________________|");
            Console.WriteLine("1.Push\n2.Pop\n3.Peek\n4.Display\n5.IncrementStack Size\n6.Clear\n7.Aggregate Functions\n8.Exit");

            try
            {
                string value = Console.ReadLine();
                int choice;
                //to check if the input is integer 
                if (int.TryParse(value, out choice))
                {
                 
                switch (choice)
                {
                    case 1:
                        Push_Integer(stackinteger);
                        break;
                    case 2:
                        Pop_Integer(stackinteger);
                        break;
                    case 3:
                        Peek_Integer(stackinteger);
                        break;
                    case 4:
                        Display_Integer(stackinteger);
                        break;
                    case 5:
                        Increment_Stack_Size(stackinteger);
                        break;
                    case 6:
                        Clear_Integer(stackinteger);
                        break;

                    case 8:
                        Console.WriteLine("The program is terminated");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!\nPlease Try again :(");
                        Initialize_Menu(stackinteger);
                        break;
                   }

                }
                else
                {
                    throw new NonInteger_Exception("Enter a Valid Input");
                }
            }
            catch (NonInteger_Exception formatexception)
            {
                Console.WriteLine(formatexception.Message);
            }
            finally
            {
                Initialize_Menu(stackinteger);
            }
        }
        //To Increment Stack Size
        public static void Increment_Stack_Size(Stack<int> stackinteger)
        {
            Console.WriteLine("Current Size is {0}", Stack_Size);
            Console.WriteLine("New Size should be greater than the Current Size");
            Console.WriteLine("Enter the new Stack Size ?");
            try
            {
                string value = Console.ReadLine();
                int intvalue;
                //to check if the input is integer 
                if (int.TryParse(value, out intvalue))
                {
                    //Exception if the user tries to decrement the stack size 
                    if (intvalue <= Stack_Size) { throw new InvalidOperationException("Lesser Size or equal Size is entered"); }
                    else { Stack_Size = intvalue; }
                }
                else
                {
                    throw new NonInteger_Exception("Not an Integer");
                }
            }
            catch (NonInteger_Exception formatexception)
            {
                Console.WriteLine(formatexception.Message);
            }
            catch (InvalidOperationException invalidsize) {
                Console.WriteLine("\n---------------------EXCEPTION------------------------------");
                Console.WriteLine("|-->Main:The \'SIZE\' of the stack entered should be greater than {0}\n|-->Msg: {1}", Stack_Size, invalidsize.Message);
                Console.WriteLine("|-->Fix: Please Enter greater size to increment");
                Console.WriteLine("--------------------------------------------------------------");
            }
            finally
            {
                Initialize_Menu(stackinteger);
            }
        }
        //To Push an Integer
        public static void Push_Integer(Stack<int> stackinteger) {
            try
            {
                //To check if it reached the max size limit
                if (stackinteger.Count == Stack_Size)
                {
                    throw new StackOverflowException();
                }
                else
                {
                    Console.WriteLine("Enter the integer value ?");
                    //reading the value
                    string value = Console.ReadLine();
                    int intvalue;
                    //to check if the input is integer 
                    if (int.TryParse(value, out intvalue))
                    {
                        stackinteger.Push(intvalue); Display_Integer(stackinteger);
                    }
                    else
                    {
                        throw new NonInteger_Exception("Not an Integer");
                    }
                }
            }
            catch (StackOverflowException sizeexception)
            {
                Console.WriteLine("\n---------------------EXCEPTION------------------------------");
                Console.WriteLine("|-->Main:The \'SIZE\' of the stack cannot be greater than {0}\n|-->Msg: {1}", Stack_Size, sizeexception.Message);
                Console.WriteLine("|-->Fix: Please POP the elements");
                Console.WriteLine("--------------------------------------------------------------");
            }
            catch (NonInteger_Exception formatexception) {
                Console.WriteLine(formatexception.Message);
            }
            finally
            {
                Initialize_Menu(stackinteger);
            }
            
        }
        //To Pop an the top element
        public static void Pop_Integer(Stack<int> stackinteger) {
            try
            {
                //if the stack has no elements
                if (stackinteger.Count == 0)
                {
                    throw new StackEmpty_Exception("Stack is empty");
                }
                else {
                    Console.WriteLine("The Popped Value is : " + stackinteger.Pop());
                }
            }
            catch(StackEmpty_Exception stackempty) {
                Console.WriteLine(stackempty.Message);
            }
            finally
            {
                Initialize_Menu(stackinteger);
            }
        }
        //To Peek the top element 
        public static void Peek_Integer(Stack<int> stackinteger)
        {
            Console.WriteLine("The Peeked Value is : " + stackinteger.Peek());
            Initialize_Menu(stackinteger);
        }
        //To Display the elements in a Stack 
        public static void Display_Integer(Stack<int> stackinteger)
        {
            try
            {
                //if the stack has no elements
                if (stackinteger.Count == 0)
                {
                    throw new StackEmpty_Exception("Stack is empty");
                }
                else
                {
                    Console.WriteLine("The stack elements are : ");
                    Console.Write("[ ");
                    foreach (int val in stackinteger)
                    {
                        Console.Write(val + ", ");
                    }
                    Console.WriteLine("]");
                }
            }
            catch (StackEmpty_Exception stackempty)
            {
                Console.WriteLine(stackempty.Message);
            }
            finally
            {
                Initialize_Menu(stackinteger);
            }
        }
        //To Clear the Stack elements
        public static void Clear_Integer(Stack<int> stackinteger) {
            Console.WriteLine("After clearing the Stack :");
            stackinteger.Clear();
            Display_Integer(stackinteger);
        }
        
    }

}
