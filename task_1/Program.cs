// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int quantityM = 10;
System.Console.WriteLine($"Программа показывает сколько положителных чисел ввел пользователь.\nНеобходимо ввести {quantityM} чисел:");
double[] enteredNumbers = EnterAnArrayOfNumbers(quantityM);
System.Console.WriteLine();
System.Console.WriteLine("Введенные числа:");
PrintArray(enteredNumbers);
System.Console.WriteLine($"Количество введенных положительных чисел: {CounterPositiveNumbers(enteredNumbers)}");

double InputNumber(string invitationText)
{
	double inputNum;
	while (true)
	{
		System.Console.WriteLine(invitationText);
		string inputStr = Console.ReadLine();
		if (double.TryParse(inputStr, out inputNum))
		{
			break;
		}
		System.Console.WriteLine("Введено неверное значение. Необходимо ввести число!");
	}
	return inputNum;
}

double[] EnterAnArrayOfNumbers(int size)
{
	double[] arrayNumbers = new double[size];
	for (int i = 0; i < arrayNumbers.Length; i++)
	{
		arrayNumbers[i] = InputNumber($"Введите {i + 1}-е число: ");
	}
	return arrayNumbers;
}

void PrintArray(double[] outputArray)
{
	System.Console.WriteLine(string.Join("; ", outputArray));
}

int CounterPositiveNumbers(double[] sourceArray)
{
	int count = 0;
	for (int i = 0; i < sourceArray.Length; i++)
	{
		if (sourceArray[i] > 0)
		{
			count++;
		}
	}
	return count;
}