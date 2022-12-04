double[] coordinatA = new double[3];
double[] coordinatB = new double[3];
coordinatA = FillArrayA(coordinatA);
coordinatB = FillArrayB(coordinatB);
double result = Math.Round(DistanceBetweenPoints(coordinatA,coordinatB), 2);

Console.Write("Distance: ");
Console.WriteLine(result);
    
double DistanceBetweenPoints(double[] coorA,double[] coorB)
{
    double index = 0;
    double sum = 0;
    while(index < coorA.Length)
    {
        sum = sum + (double)Math.Pow(coorB[(int)index] - coorA[(int)index], 2);
        index++;
    }
    return (double)Math.Sqrt(sum);
}

double[] FillArrayB(double[] colB)
{
    int pos = 0;
    int rank = 1;
    while(pos < colB.Length)
    {
    Console.Write($"Enter {rank} number from coordinatB: ");
        colB[pos] = int.Parse(Console.ReadLine());
        pos++;
        rank++;
    }
    return colB;
}

double[] FillArrayA(double[] colA)
{
    int pos = 0;
    int rank = 1;
    while(pos < colA.Length)
    {
        Console.Write($"Enter {rank} number from coordinatA: ");
        colA[pos] = int.Parse(Console.ReadLine());
        pos++;
        rank++;
    }
    return colA;
}
