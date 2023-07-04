// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
const int coeff_k = 0;
const int const_b = 1;
const int x = 0;
const int y = 1;
const int line1 = 1;
const int line2 = 2;

double ReadDouble(string message) // приглашение  пользователю ввести строку и перевод строки 
//в число
{
    System.Console.Write(message);
    string text = Console.ReadLine();
    double inputedNum = Convert.ToDouble(text);
    return inputedNum;
}
double[] InputLineData(int lineNum)// Ввод данных прямой линии k и b
{
    double [] lineData = new double[2];
    lineData[coeff_k] = ReadDouble($"Введите коэффициент для {lineNum} прямой: ");
    lineData[const_b] = ReadDouble($"Введите константу для {lineNum} прямой: ");
    return lineData;
}
double[] FindCrossCoords(double[] lineData1, double[] lineData2)//Функция Поиск координат
{
    double[] crossCoords = new double[2];
    crossCoords[x] = (lineData1[const_b] - lineData2[const_b]) / (lineData2[coeff_k] - lineData1[coeff_k]);
    crossCoords[y] = lineData1[const_b] * crossCoords[x] + lineData1[const_b];
    return crossCoords;
}
 //Создаем данные k и b двух прямых
double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);
if (ValidateLines(lineData1, lineData2))
{
    double[] сrossCoords = FindCrossCoords(lineData1, lineData2);
    System.Console.WriteLine("Точка пересечения двух прямых, заданных уравнениями");
    System.Console.WriteLine($"y = {lineData1[coeff_k]} * x + {lineData1[const_b]}  и");
    System.Console.WriteLine($"y = {lineData2[coeff_k]} * x + {lineData2[const_b]}  ");
    System.Console.WriteLine($" имеет координаты ({сrossCoords[x]}, {сrossCoords[y]})");
}
bool ValidateLines(double[]lineData1, double[]lineData2 )
{
    if (lineData1[coeff_k] == lineData2[coeff_k])
    {
        if(lineData1[const_b] == lineData2[const_b])
        {
            System.Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
          System.Console.WriteLine("Прямые паралельны");
            return false;  
        }
    } return true;
 }

 
  
