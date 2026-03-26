namespace DebuggingApplication
{
    class InitialClass
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter String: ");
            string? userResponse = Console.ReadLine();

            // Here error will occur which we can debug
            if (Convert.ToBoolean(int.Parse(userResponse!)))
            {
                Console.WriteLine("The entered value is a integer");

            }
        }
    }
}