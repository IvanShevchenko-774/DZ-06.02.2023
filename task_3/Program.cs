//Задача 29: Напишите программу, которая задаёт 
//массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int vvod (string message)
{
    System. Console.Write (message) ; //Выводим приглашение ко вводу
    int result=Convert.ToInt32(Console.ReadLine());
    return result; //возвращаем результат
}


int [] GenerateArray (int size, int leftRange, int rightRange)
{
    int [] array = new int[size];
    var rand=new Random();

    for (int i =0; i < array.Length;i++)
    {
        array[i]=rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("["+ string.Join(", ", array)+"]");
}

int size = vvod ("Длина массива: ");
int leftRange = vvod ("Введите первое число диапозона: ");
int rightRange = vvod ("Введите последнее число диапозона: ") ;
int[] myArray = GenerateArray(size, leftRange, rightRange);

PrintArray(myArray);
