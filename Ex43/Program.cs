// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями.

Console.WriteLine("Две прямые заданы уравнениями y = k1 * x + b1 и y = k2 * x + b2");
Console.WriteLine("Вы вводите с клавиатуры значения коэффициентов k и b для двух уравнений");
Console.WriteLine("Я нахожу координаты точки пересечения этих двух прямых");

double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoeff()
{
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.WriteLine($"Введите коэффициенты {i+1}-го уравнения (y = k{i+1} * x + b{i+1}): ");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.WriteLine($"Введите коэффициент k{i+1}: ");
      else Console.WriteLine($"Введите коэффициент b{i+1}: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] CrossPoint(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void CrossPointCoordinate(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1] || coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1])
  Console.WriteLine("Прямые с заданными Вами коэффициентами не пересекаются"); 
  else 
{
    CrossPoint(coeff);
    Console.WriteLine($"Координаты точки пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
}
}
InputCoeff();
CrossPointCoordinate(coeff);
