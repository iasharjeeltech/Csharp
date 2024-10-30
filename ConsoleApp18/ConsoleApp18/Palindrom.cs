namespace ConsoleApp18
{
    internal class Palindrom
    {
        public void pdrom()
        {
            string str = "";
            string reversedString = string.Empty;

            for (int lastIndex = str.Length-1;lastIndex>=0; lastIndex--)
            {
                reversedString = reversedString + str[lastIndex];
            }
            Console.WriteLine(str);
            Console.WriteLine(reversedString);

            if (!string.IsNullOrWhiteSpace(str)){
                if (string.Equals(str, reversedString))
                {
                    Console.WriteLine("GIven string is Palindrome");
                }
            
            }
            else
            {
                Console.WriteLine("invalid Value");
            }
        }
    }
}
