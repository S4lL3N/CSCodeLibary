

namespace CodingExam
{
    public class Fibonacci
    {
        //I chose to use the iterative approach because recursion uses more system resources.
        //As the size of N increases so does the overhead due to the repetitive calling of
        //the same function which takes up more of the stack. 

        public static void FibonacciSequence(int n)
        {
            //set starting point
            int val1 = 0;
            int val2 = 1;
            int val3;
            
            Console.WriteLine("Fibonacci series:");
            Console.Write(val1 + " " + val2 + " ");

            //for the range of n add two preceding numbers
            for (int i = 2; i < n; ++i)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }
        }
    }
}
