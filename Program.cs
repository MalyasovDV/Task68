int AckFunction(int m, int n)
{
    if (m > 0 & n == 0)
        return AckFunction(m - 1, 1);
    if (m > 0 & n > 0)
        return AckFunction(m-1, AckFunction(m, n - 1));
    return n + 1;
}

int m = 2;
int n = 3;

Console.WriteLine("Функция Аккермана ({0},{1}) : {2}", m, n, AckFunction(m, n));