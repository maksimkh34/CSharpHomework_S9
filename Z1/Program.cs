int GetInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int findsum(int a, int b)
{
    if(a!=b) return findsum(a+1, b)+a;
    else return a;
}

int a = GetInt("Enter N: ");
int b = GetInt("Enter M: ");

Console.Write("Answer is: " + findsum(a, b));