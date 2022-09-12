// Задача 41. Подсчет количества положительных чисел, вводимых с клавиатуры. Общее количество чисел задает пользователь.
Console.WriteLine("Вы введёте общее количество чисел и каждое из них, а я определю, сколько положительных чисел Вы ввели");
Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arriveNumbers = new int[m];

void FillAndCalculate(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1}-е число: ");
    arriveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}
int Calculate(int[] arriveNumbers)
{
  int count = 0;
  for (int i = 0; i < arriveNumbers.Length; i++)
  {
    if(arriveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}
FillAndCalculate(m);
Console.WriteLine($"Количество введенных положительных чисел: {Calculate(arriveNumbers)} ");

