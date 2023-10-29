const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2; 
double[] lineDatal = InputLineData (LINE1);
double[] lineData2 = InputLineData (LINE2);

if (ValidateLines (lineDatal, lineData2))
{}
double[] coord = FindCoords(lineDatal, lineData2);
Console.Write($"Точка пересечения уравнений y ={lineDatal[COEFFICIENT]}*x+{lineDatal[CONSTANT]} и y={lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]}");
Console.WriteLine($" имеeт коoрдинаты ({coord[X_COORD]}, {coord[Y_COORD]})");
// Ввод числа
double Prompt (string message)
{
System.Console.Write (message); //aunecти сообшение
string value = Console.ReadLine(); //считывает с консоли строку
double result = Convert.ToDouble (value); // peoбpasyer cтpoxy в uелcе

return result; //soзapamaer pesyльтar
}
// Ввод данных по прямой
double[] InputLineData (int numberOfLine)
{
double[] lineData= new double[2];
lineData[COEFFICIENT] = Prompt ($"Bведитe кофициент для {numberOfLine}прямой >");
lineData[CONSTANT] = Prompt ($"Введите константу для {numberofLine} прямой >");
return lineData;
}

// Поиск координат
double[] FindCoords (double[] lineDatal, double[] lineData2)
{
double[] coord = new double[2];
coord[X_COORD] =(lineData1[CONSTANT]- lineData2[CONSTANT]) / (lineData2[COEFFICIENT] lineData1[COEFFICIENT]);
coord[Y_COORD] =lineDatal [CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];
return coord;
}

bool ValidateLines (double[] lineDatal, double[] lineData2)
{
if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
{
if (lineData1[CONSTANT] == lineData2[CONSTANT])
{
Console.WriteLine("Прямые совпадают"); return false;
}
else
{
Console.WriteLine("Прямые параллельны");
return false;
}
}
return true;
}