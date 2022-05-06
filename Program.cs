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
    string[] modifiedArray = new string[givenArray.Length];
    for (int i = 0; i < givenArray.Length; i++)
    {
        if (givenArray[i].Length <= 3)
        {
            modifiedArray[i] = givenArray[i];
        }
    }
    modifiedArray = modifiedArray.Where(x => x != null).ToArray();
    return modifiedArray;
}