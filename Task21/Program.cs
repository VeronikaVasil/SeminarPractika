// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату Ax: "); 
int ax = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите координату точки Ay: "); 
int ay = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите координату точки Az: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки Bx: "); 
int bx = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки By: ");
int by = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки Bz: ");
int bz = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((ax - bx) * (ax - bx)) + ((ay - by) * (ay - by)) + ((az - bz) * (az - bz));

Console.Write(Math.Round(distance, 3));


