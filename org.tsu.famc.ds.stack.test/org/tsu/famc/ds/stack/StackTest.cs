using System;
using stack;

namespace org.tsu.famc.ds.stack
{
    class StackTest
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    s.Push(i);
                }
                Stack s1 = new Stack(s);
                while (true)
                {
                    int tmp = (int)s1.Top();
                    if (tmp % 100 == 0)
                        Console.WriteLine(tmp);
                    if (tmp != (int)s1.Pop())
                        throw new Exception("Test failed");
                }
            }
            catch (EStackEmpty e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
