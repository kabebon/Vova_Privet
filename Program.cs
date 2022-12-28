class homework_EX19
{
    public static void Main()
    {
        int input = GetNumberFromUser();
        if (!Is5DigitsNumber(input))
        {
            Console.WriteLine("The number isn't 5 digits!!!"); 
            return; 
        }
        CheckForPalindrome(input); 
           
    }

    private static int GetNumberFromUser() //получаем пятизначное число
    {
        Console.Write("Input 5 digits number to reverse: ");
        return int.Parse(Console.ReadLine()!);       
    } 

    private static bool Is5DigitsNumber(int input) //проверяем 5 значное ли оно
    {   
        int value = input;
        if(input > 9999)
        {
            return true;
        } 
        
        return false;
    }
    
    private static bool IsPalindrome(string input)// метод проверки на палиндром
    {
        char[] array = input.ToCharArray();
        for (int i = 0; i < array.Length/2; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {
                    return false;
                }
            }
        return true;
    }
    private static void CheckForPalindrome(int input) // проверка на палиндром
    {
        if (IsPalindrome(input.ToString()))
        {
            Console.WriteLine("It's palindrom :)");
        }
        else
        {
            Console.WriteLine("It's not a palindrome, dude :(");
        }
    }
}
    