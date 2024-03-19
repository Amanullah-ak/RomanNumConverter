using RomanToIntegar;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        while (true)
        {
            Console.WriteLine("+++++++++++++++++++++++++++");
            Console.WriteLine("Enter a Roman Numerals");
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit")
                break;


            int result = solution.RomanToInt(input);
            if (result != -1)
            {
                Console.WriteLine($"The integar value of {input} is : {result}");
            }
            else
            {
                
                Console.WriteLine("Please enter a valid Roman Numeral!!");
            }
        }
        
    }
}