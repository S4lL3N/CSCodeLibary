

namespace CodingExam
{
    public class BalancedParentheses
    {
        public static void BalanceCheck(string input)
        {
            //to change solution to include  {} and  [] just add pairs to the dictionary.
            Dictionary<char, char> pairs = new Dictionary<char, char>() {{ '(', ')' },
                                                                         { '{', '}' },
                                                                         { '[', ']' }};

            Stack<char> parenthesess = new Stack<char>();

            try
            {
                //loop through string
                foreach (char c in input)
                {
                    //check for opening pair and add to stack
                    if (pairs.Keys.Contains(c))
                    {
                        parenthesess.Push(c);
                    }
                    else
                    //check for closing pair
                        if (pairs.Values.Contains(c))
                    {
                        //check for match
                        if (c == pairs[parenthesess.First()])
                        {
                            parenthesess.Pop();
                        }
                        else
                            
                            Console.WriteLine(input + " is not balanced");
                    }
                    else
                        
                        continue;
                }
            }
            catch
            {
                //closing side first
                Console.WriteLine(input + " is not balanced");
            }


            Console.WriteLine(input + " is balanced");
        }
    }
}
