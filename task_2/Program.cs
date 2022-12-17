// Программа, вычисляющая точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
System.Console.WriteLine("Введите параметры первой прямой: ");
double k1 = InputNumber("Введите уголовой коэффициент (параметр k1): ");
double b1 = InputNumber("Введите точку пересечения прямой с осью OY (параметр b1): ");
System.Console.WriteLine("Введите параметры второй прямой: ");
double k2 = InputNumber("Введите уголовой коэффициент (параметр k2): ");
double b2 = InputNumber("Введите точку пересечения прямой с осью OY (параметр b2): ");
System.Console.WriteLine(CalculateThePointOfIntersectionOfTwoLines(k1, b1, k2, b2));

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

double CalculateThePointOfIntersectionOfTwoLines(double k1, double b1, double k2, double b2)
{
	double intersectionPoint = k1 * ((b2 - b1) / (k1 - k2)) + b1;
	return intersectionPoint;
}