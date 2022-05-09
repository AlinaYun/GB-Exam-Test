// Написать программу, которая из имеющегося массива строк формируем массив из строк, длина которых меньше, либо равна 3 символа.


// Метод для создания и заполнения массива с клавиатуры
string[] GenerateStringArray(int numberOfElements)    // numberOfElements - количество элементов в массиве
{
    string[] stringArray = new string[numberOfElements];  //создаем новый пустой массив
    for (int i = 0; i < numberOfElements; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент в массиве:");
        stringArray[i] = Console.ReadLine();              // ввод с клавиатуры каждого элемента
    }
    return stringArray;
}

// Метод для вывода массива
void PrintStringArray(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (i != stringArray.Length - 1)
        {
            Console.Write($"{stringArray[i]}, ");
        }
        else
        {
            Console.Write($"{stringArray[i]}");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

// Метод для формирования массива из строк, длина которых меньше, либо равна 3 символа
string[] GetModifiedArray(string[] givenArray)
{
    int len = givenArray.Length;
    int counter = 0;           // счетчик для определения количества элементов с длиной <= 3 символа
    for (int i = 0; i < len; i++)
    {
        if (givenArray[i].Length <= 3)
        {
            counter += 1;
        }
    }
    string[] modifiedArray = new string[counter];  // создаем новый массив, длина которого равна счетчику
    int j = 0;
    for (int i = 0; i < len; i++)
    {
        if (givenArray[i].Length <= 3)
        {
            modifiedArray[j] = givenArray[i];  // если длина элемента во входящем массиве меньше, либо равна 3, добавляем этот элемент в новый массив
            j += 1;
        }
    }
    return modifiedArray;
}


Console.WriteLine("Введите количество элементов в массиве:");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
string[] generatedArray = GenerateStringArray(numberOfElements);
Console.WriteLine("Заданный массив:");
PrintStringArray(generatedArray);
string[] modifiedArray = GetModifiedArray(generatedArray);
Console.WriteLine("Измененный массив:");
PrintStringArray(modifiedArray);