System.Console.WriteLine("Введите длинну массива ");
int size = Convert.ToInt32(Console.ReadLine());            // Определяю длинну изначального массива.
string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    System.Console.WriteLine($"Введите {i + 1} элемент массива ");
    array[i] = Convert.ToString(Console.ReadLine());
}
System.Console.WriteLine();
System.Console.WriteLine($"[{String.Join(", ", array)}]"); // Вывожу заданный с клавиатуры изначальный массив строк.
System.Console.WriteLine();


string[] newArray = new string[size]; 
int k = 0;
for (int j = 0; j < size; j++)
{
    if (array[j].Length<=3)
    {
        newArray[k] = array[j];
        k++;                              // Высчитываю, сколько всего элементов изначального массива подпадает под условие задачи. 
    }                                    // Если выводить сразу этот массив, он будет включать пустые элементы и выводить их через ",".
}


string[] finalArray = new string[k];    // Зная количество подходящих под условие задачи элементов сразу опередляю длинну финального массива.
int x = 0;
for (int l = 0; l < k; l++)
{
    finalArray[l]=newArray[x];
    x++;
}


System.Console.WriteLine($"[{String.Join(", ", finalArray)}]"); // Вывожу результат.
