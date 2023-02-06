/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int[] InitArray(int dimension) {
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++) {
        arr[i] = rnd.Next(-10,11);
    }
    return arr;
}

void PrintArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int DifMaxAndMin (int[] array) {
    int dif = 0;
    int max = array[0];
    int min = array[0];

    for (int i = 1; i < array.Length; i++) {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    dif = max - min;
    return dif;
}

int[] array = InitArray(6);
PrintArray(array);
int difMaxMin = DifMaxAndMin(array);

Console.WriteLine($"Разница между макс и мин элементами массива равна {difMaxMin}");