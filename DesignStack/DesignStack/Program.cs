using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignStack
{
    class Stack
    {
        // Θα πρέπει να είναι List Object
        List<object> myObject = new List<object>();

        // Pushάρω αντικείμενω στην στοίβα
        void Push(object obj)
        {
            try
            {
                if (obj != null)
                {
                    myObject.Add(obj);
                }
                else
                {
                    throw new Exception("Πρέπει να εισάγεις κάποιο αντικείμενο!\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        // Εξάγω αντικείμενω από την στοίβα
        private object Pop()
        {
            try
            {
                // Ψάχνω το τελευταίο στοιχείο που εισήχθηκε στην στοίβα αφού Last In - First Out
                object last = myObject.Last();
                if (last == null)
                    throw new Exception("Η στοίβα σου είναι άδεια!\n");
                myObject.Remove(last);
                return last;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        
        // Αδειάζω την στοίβα τελείως
        void Clear()
        {
            myObject.Clear();
        }
        
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(null);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            // Παγώνω την κονσόλα
            Console.ReadLine();

            // Άδειασμα στοίβας
            stack.Clear();
        }
    }
}
