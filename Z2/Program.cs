int GetInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int countdigits(int num)
{
    if (num > 9)
    {
        return 1+countdigits(num / 10);
    }
    else return 1;
}

int num = GetInt("Enter number: ");
Console.WriteLine("Answer is: " + countdigits(num));