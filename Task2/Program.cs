/*Напишите программу, которая принимает на вход 
координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double X1 = InputInt("Введите X1 ");
double Y1 = InputInt("Введите Y1 ");
double Z1 = InputInt("Введите Z1 ");
double X2 = InputInt("Введите X2 ");
double Y2 = InputInt("Введите Y2 ");
double Z2 = InputInt("Введите Z2 ");

System.Console.WriteLine(lenghtAB(X1, Y1, Z1, X2, Y2, Z2));

double lenghtAB(double dx1, double dy1, double dz1, double dx2, double dy2, double dz2)
{
    double result = Math.Sqrt(Math.Pow(dx1 - dx2, 2) + Math.Pow(dy1 - dy2, 2) + Math.Pow(dz1 - dz2, 2));
    return result;
}

double InputInt(string message)
{
    System.Console.Write(message + "> ");
    string? inputValue = Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}