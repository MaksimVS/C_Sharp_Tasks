// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

enterValue();

void enterValue()
{
    int Ax = 3;       int Bx = 2;
    int Ay = 6;       int By = 1;
    int Az = 8;       int Bz = -7;    
    distance(Ax, Ay, Az, Bx, By, Bz);
}

void distance(int Ax, int Ay, int Az, int Bx,int By,int Bz)
{
    double d = Math.Pow((Math.Pow(Bx - Ax, 2) +            //Теорема Пифагора
                         Math.Pow(By - Ay, 2) +
                         Math.Pow(Bz - Az, 2) * 1.0), 0.5);
    Console.WriteLine("Дистанция равна " + d);
    return;
}
 

