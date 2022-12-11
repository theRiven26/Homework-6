/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Enter the count of numbers");
int count = int.Parse(Console.ReadLine());
int[] userArray = new int[count];
FillUserArray(userArray);
int countNegative = GetNegetiveNumbersOfArray(userArray);
Console.WriteLine($"Count negative numbers = {countNegative}");


void FillUserArray(int[] array)
{
	Console.WriteLine($"Enter {array.Length} numbers");
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = int.Parse(Console.ReadLine());
	}
}

int GetNegetiveNumbersOfArray(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < 0)
		{
			count++;
		}
	}
	return count;
}
