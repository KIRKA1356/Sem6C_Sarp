/*
Console.WriteLine("Введите число для преобразования");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите систему счисления");
int y = Convert.ToInt32(Console.ReadLine());

string preobraz( int x, int y)
{
    string result = string.Empty;
    while (x >= 1)
        {
             result = x % y + result; 
             x = x / y;
        }
    return result;
}

Console.WriteLine("Ваше число: " + preobraz(x, y)); 
*/

/* Задача 1. Напишите программу, котораяперевернёт одномерный массив(последний элемент будетна первом месте, а первый - на последнем и т.д.)
Задача 2. Напишите программу, котораяпринимает на вход три числа и проверяет,может ли существоватьтреугольник с сторонами такой длины.
Задача 3. Не используя рекурсию,выведите первые N чисел Фибоначчи.Первые два числа Фибоначчи: 0 и 1.
*/


/*
Console.WriteLine("Введите размер массива");
int size =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max =Convert.ToInt32(Console.ReadLine());

int[] RandomArray(int size, int min, int max)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            {   
                array[i] = new Random().Next(min, max+1);
            }
        return array;
    }

void ShowArray(int[] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] MyArray = RandomArray(size, min, max);
ShowArray(MyArray);

int[] Perevotot(int[] array)
{
        int y = 1;
        for (int i = 0; i < array.Length/2; i++)
            {   
                int temp = 0;
                temp = array[i];
                array[i] = array[array.Length - y];
                array[array.Length - y] = temp;
                y++;
            }
        return array;
}


ShowArray(Perevotot(MyArray));
*/
//Задача 2. Напишите программу, котораяпринимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.

/*
Console.WriteLine("1 сторона");
int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вторая сторона");
int y =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("третья сторона");
int z =Convert.ToInt32(Console.ReadLine());


int treugolnik(int x, int y, int z)
{
    if (x+y > z) 
        {
            if (x+z > y) 
                {
                    if (z+y > x) 
                    { 
                        return 1;
                    }
                    else return 0;
                }   
                else return 0;    
        } 
        else return 0;
}

if (treugolnik(x, y, z) == 1) Console.WriteLine("Треугольник может существовать");
  else Console.WriteLine("Треугольник  НЕ может существовать");
*/

//Задача 3. Не используя рекурсию,выведите первые N чисел Фибоначчи.Первые два числа Фибоначчи: 0 и 1.

/*
Console.WriteLine("Напишите сколько числе вы хотите выводить");
int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите первое число ряда");
int y =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе число ряда");
int z =Convert.ToInt32(Console.ReadLine());

int[] fibonachi(int x, int y, int z)
{
    int[] array = new int[x];
        array[0] = y;
        array[1] = z;
        for (int i = 2; i < x; i++)
            {   
                array[i] = array[i-2] + array[i-1];
            }
        return array;
}
 
void ShowArray(int[] array)
{
    Console.WriteLine("Ваш ряд фибоначи: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] fibon = fibonachi(x, y, z);
ShowArray(fibon);
*/
