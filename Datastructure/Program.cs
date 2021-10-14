using System;
using System.Collections;

namespace Datastructure
{
    class Program
    {
        static void Main(string[] args)
        {
           
            #region Stack
            /*
            This code produces the following output.
            myStack
            Count:    3
            Values:    !    World    Hello
            */
            // Creates and initializes a new Stack.
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            // Displays the properties and values of the Stack.
            Console.WriteLine("Stack Output - LIFO");
            Console.WriteLine("\nCount:{0}", myStack.Count);
            Console.Write("\nValues:");
            PrintValues(myStack);
            Console.ReadKey();
            #endregion

        }

        /// <summary>
        /// Helper method to print the stack values
        /// </summary>
        /// <param name="myCollection"></param>
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write(" {0}", obj);
            Console.WriteLine();
        }
    }
}
