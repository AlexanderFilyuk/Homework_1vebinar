/* Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/



double inputUserData(string userMessage)
{
    Console.WriteLine(userMessage);
    double userDate = Convert.ToDouble(Console.ReadLine());
    return userDate;
}

bool isTriangleExists(double side1, double side2, double side3)
{
    bool isSide1Smaller = side1 < side2 + side3;
    bool isSide2Smaller = side2 < side1 + side3;
    bool isSide3Smaller = side3 < side1 + side2;
    bool isExists = (isSide1Smaller && isSide2Smaller && isSide3Smaller);
    return isExists;
    
}
void showInfoAboutTriangle(double side1, double side2, double side3, bool triangleExists)
{
    string existString = "не существует";
    if (triangleExists)
    {
        existString = "существует";
    }
    Console.WriteLine($"Треугольник со сторонами {side1}, {side2}, {side3} {existString}");
}

double side1 = inputUserData("Введите длину первой стороны");
double side2 = inputUserData("Введите длину второй стороны");
double side3 = inputUserData("Введите длину третьей стороны");
bool triangleExists = isTriangleExists(side1, side2, side3);
showInfoAboutTriangle(side1, side2, side3, triangleExists);






