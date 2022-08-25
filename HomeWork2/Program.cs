// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите значение k для прямой а: y = k * x + b: ");
double ka = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите значение b для прямой а: y = {ka} * x + b: ");
double ba = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k для прямой c: y =  y = k * x + b: ");
double kc = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите значение b для прямой c: y = {kc} * x + b: ");
double bc = Convert.ToInt32(Console.ReadLine());


string[,] matrix = new string[2,4];
void PrintArray(string[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}

string[,] FillArray(string[,] matr,double A1, double B1, double A2, double B2)
{
    string y = "y =";
    string x = "* x +";

  matr[0,0] = y;
  matr[0,1] = A1.ToString();
  matr[0,2] = x;
  matr[0,3] = B1.ToString();

  matr[1,0] = y;
  matr[1,1] = A2.ToString();
  matr[1,2] = x;
  matr[1,3] = B2.ToString();
  return matr;
}

Console.WriteLine();

string[,] bag = FillArray(matrix, ka, ba, kc, bc);
PrintArray(bag);


double[] FindPointIntersection(double A1, double B1,double A2, double B2)
{
    double x = ((B1-B2)*-1)/(A1-A2);
    double y =  A1 * x + B1;

    double[] res = new double[]{x,y};
    return res;
}

double[] array = FindPointIntersection(ka,ba,kc,bc);

void PrintResultArray(double[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

PrintResultArray(array);
