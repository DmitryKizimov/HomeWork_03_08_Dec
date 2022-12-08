//Принимаем от пользователя координаты двух точек в 3D пространстве
Console.Write("Введите координаты ПЕРВОЙ точки, последовательно: X, Y, Z: ");
Console.Write("Введите для первой точки координату X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для первой точки координату Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для первой точки координату Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты ВТОРОЙ точки, последовательно: X, Y, Z: ");
Console.Write("Введите для второй точки координату X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для второй точки координату Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите для второй точки координату Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

//с помощью простых действий находим формулу нахождения расстояния
int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;

//находим квадрат разности чисел:
int tempx = x * x;
int tempy = y * y;
int tempz = z * z;

//находим сумму квадратов
int tempsum = tempx + tempy + tempz;

//находим квадратный корень из суммы квадратов
double tempdistance = Math.Sqrt(tempsum);

//простейшим способом округляем результат до сотых числа
double distance = tempdistance - ((tempdistance) % 0.01);
Console.WriteLine(distance);