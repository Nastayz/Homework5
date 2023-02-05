/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] InitArray(int dimension) {
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++) {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

void PrintArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int GetEvenNumbersNum (int[] array) {
    int num = array.Length;
    for (int i = 0; i < array.Length; i++) {
        if(array[i]%2 != 0) {
            num--;
        }
    }
    return num;
}

int[] array = InitArray(10);
PrintArray(array);
int evenNumbersNum = GetEvenNumbersNum(array);

Console.WriteLine($"В массиве {evenNumbersNum} четных чисел");