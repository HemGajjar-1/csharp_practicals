namespace Exception_Handling;

class InitialClass
{
    public static void Main(String[] args)
    {
        try
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            // In this for loop we will be accessing the index 5 which generates the IndexOutOfRangeException exception
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Array[{i}] : {arr[i]}");
            }

        }catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("This is the finally block");
        }
    }
}