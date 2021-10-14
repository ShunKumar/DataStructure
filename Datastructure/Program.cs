using System;
using System.Collections;
using System.Collections.Generic;

namespace Datastructure
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Stack

                //#region example 1
                ///*
                //This code produces the following output.
                //myStack
                //Count:    3
                //Values:    !    World    Hello
                //*/
                //// Creates and initializes a new Stack.
                //Stack myStack = new Stack();
                //myStack.Push("Hello");
                //myStack.Push("World");
                //myStack.Push("!");

                //// Displays the properties and values of the Stack.
                //Console.WriteLine("Stack Output - LIFO");
                //Console.WriteLine("\nCount:{0}", myStack.Count);
                //Console.Write("\nValues:");
                //PrintValues(myStack);
                //Console.ReadKey();
                //#endregion

                #region Example 2
                /*  This code example produces the following output:
                    five
                    four
                    three
                    two
                    one
                    Popping 'five'
                    Peek at next item to destack: four
                    Popping 'four'
                    Contents of the first copy:
                    one
                    two
                    three
                    Contents of the second copy, with duplicates and nulls:
                    one
                    two
                    three
                    stack2.Contains("four") = False
                    stack2.Clear()
                    stack2.Count = 0
                */
                Stack<string> numbers = new Stack<string>();
                numbers.Push("one");
                numbers.Push("two");
                numbers.Push("three");
                numbers.Push("four");
                numbers.Push("five");

                // A stack can be enumerated without disturbing its contents.
                foreach (string number in numbers)
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine("\nPopping '{0}'", numbers.Pop());
                Console.WriteLine("Peek at next item to destack: {0}",
                    numbers.Peek());
                Console.WriteLine("Popping '{0}'", numbers.Pop());

                // Create a copy of the stack, using the ToArray method and the
                // constructor that accepts an IEnumerable<T>.
                Stack<string> stack2 = new Stack<string>(numbers.ToArray());

                Console.WriteLine("\nContents of the first copy:");
                foreach (string number in stack2)
                {
                    Console.WriteLine(number);
                }

                // Create an array twice the size of the stack and copy the
                // elements of the stack, starting at the middle of the
                // array.
                string[] array2 = new string[numbers.Count * 2];
                numbers.CopyTo(array2, numbers.Count);

                // Create a second stack, using the constructor that accepts an
                // IEnumerable(Of T).
                Stack<string> stack3 = new Stack<string>(array2);

                Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
                foreach (string number in stack3)
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
                    stack2.Contains("four"));

                Console.WriteLine("\nstack2.Clear()");
                stack2.Clear();
                Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
                Console.ReadKey();
                #endregion
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
