//одномерные массивы средний уровень стр 63 вариант 23
try
{
    //int[] x = new int[10]; Console.WriteLine("введите 10 чисел");
    //for (int i = 0; i < 10; i++)
    //{
    //    x[i] = int.Parse(Console.ReadLine());
    //}
    //double[] y = new double[10];
    //double chisl = 1, znam = 1;
    //for (int i = 0; i < 10; i++)
    //{
    //    y[i] = x[i] * x[i] + 0.3;
    //    if (i % 2 == 1)
    //        chisl *= x[i] * y[i];
    //    else
    //        znam *= x[i] * y[i];
    //}
    //double P = chisl / znam;
    //int ost = (int)P % 10;
    //Console.WriteLine($"P = {P}");
    //Console.WriteLine($"Остаток = {ost}");



    //двумерные массивы средний уровень стр69 вариант 22
    //int[,] matrix = {
    //        {1, 2, 3},
    //        {4, 9, 6},
    //        {7, 8, 5}
    //    };

    //for (int i = 0; i < 3; i++)
    //{
    //    int max = matrix[i, 0];
    //    int jmax = 0;
    //    for (int j = 1; j < 3; j++)
    //    {
    //        if (matrix[i, j] > max)
    //        {
    //            max = matrix[i, j];
    //            jmax = j;
    //        }
    //    }
    //    int temp = matrix[i, i];
    //    matrix[i, i] = matrix[i, jmax];
    //    matrix[i, jmax] = temp;
    //}
    //for (int i = 0; i < 3; i++)
    //{
    //    for (int j = 0; j < 3; j++)
    //        Console.Write(matrix[i, j] + " ");
    //    Console.WriteLine();
    //}
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}