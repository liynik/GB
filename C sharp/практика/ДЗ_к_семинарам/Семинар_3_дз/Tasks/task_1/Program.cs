//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] GenerateArray(int size, int leftRange, int rigthRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
        {
        tempArray[i] = rand.Next(leftRange, rigthRange + 1);
        }
    return tempArray;
}

void PrintArray(int[] array2){
System.Console.WriteLine("[" + string.Join(", ", array2) + "]");
}

int size = 10;
int count = 0;
int[] array = GenerateArray(size, 20, 90);
PrintArray(array);

for( int i = 0; i < array.Length; i++){
    if (array[i] >= 20 && array[i] <= 90)
    count++;
}
System.Console.WriteLine($"Количество элементов массива, значения которых лежат на отрезке [20,90] {count}");
