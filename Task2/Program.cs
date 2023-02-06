/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

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

int GetSumOddNumbers (int[] array) {
    int sum = 0;
    for (int i = 1; i < array.Length; i++) {  //i=1, т.к. 0 - четное число
        if (i%2 != 0) {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] array = InitArray(6);
PrintArray(array);
int sumOddNumbers = GetSumOddNumbers(array);

Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равна {sumOddNumbers}");