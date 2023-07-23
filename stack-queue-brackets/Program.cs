namespace stack_queue_brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidateBrackets("{}{Code}[Fellows](())"));
            Console.WriteLine(ValidateBrackets("(]("));
        }


        
            public static bool ValidateBrackets(string input)
            {
                if (input == "")
                {
                    return false;
                }

                string right = ")}]";
                string left = "({[";

                Stack<char> charStack = new Stack<char>();

                foreach (var item in input)
                {
                    if (left.Contains(item))
                    {
                        charStack.Push(item);
                    }
                    else if (right.Contains(item))
                    {
                        if (charStack.Count < 1)
                        {
                            return false;
                        }
                        

                        if (right.IndexOf(item) != left.IndexOf(charStack.Pop()))
                        {
                            return false;
                        }
                    }
                }
                
                return charStack.Count == 0;
            
        }
    }
}