// Написать программу, которая из имеющегося массива строк формируем массив из строк, длина которых меньше, либо равна 3 символа.


// Метод для заполнения массива с клавиатуры
string[] GenerateStringArray(int numberOfElements)    // numberOfElements - количество элементов в массиве
{
    string[] stringArray = new string[numberOfElements];  //создаем новый пустой массив
    for (int i = 0; i < numberOfElements; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент в массиве:");
        stringArray[i] = Console.ReadLine();              // присваиваем значение каждому элементу массива
    }
    return stringArray;
}

// Метод для формирования массива из строк, длина которых меньше, либо равна 3 символа
string[] GetModifiedArray(string[] givenArray)
{
    int counter = 0;           // счетчик для определения количества элементов с длиной <= 3 символа
    string[] modifiedArray = new string[givenArray.Length];  // создаем новый массив, длина которого равна счетчику
    for (int i = 0; i < givenArray.Length; i++)
    {
        if (givenArray[i].Length <= 3)
        {
            modifiedArray[counter] = givenArray[i];  // если длина элемента во входящем массиве меньше, либо равна 3, добавляем этот элемент в новый массив
            counter += 1;
        }
    }
    string[] realSizeArray = new string[counter]; // создаем новый массив с длиной = кол-ву подходящих элементов
    for (int j = 0; j < counter; j++)
    {
        realSizeArray[j] = modifiedArray[j];      
    }
    return realSizeArray;
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

Console.WriteLine("Введите количество элементов в массиве:");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
string[] generatedArray = GenerateStringArray(numberOfElements);
Console.WriteLine("Заданный массив:");
PrintStringArray(generatedArray);
string[] modifiedArray = GetModifiedArray(generatedArray);
Console.WriteLine("Измененный массив:");
PrintStringArray(modifiedArray);