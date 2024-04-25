int ShowNumbers(int M)
{
    int N = 10;
    System.Console.WriteLine($"{M}");
    if (M == N)
    {
        return N;
    }
    ShowNumbers(M + 1);
    return M;
}

ShowNumbers(2);