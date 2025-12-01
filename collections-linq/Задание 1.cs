public class Program
{
    public static int RandomNumber(int min, int max)
    {
        var number = DateTime.Now.Ticks % 2 == 0 ? DateTime.Now.Ticks % 100 : -DateTime.Now.Ticks % 100;

        while (number < min || number > max)
        {
            number = DateTime.Now.Ticks % 2 == 0 ? DateTime.Now.Ticks % 100 : -DateTime.Now.Ticks % 100;
        }

        return (int)number;
    }

    public static void Main()
    {
        //     Создайте массив из 15 случайных целых чисел в диапазоне от 1 до 100.
        //     Выведите все четные числа из этого массива. 
        //     Подсчитайте количество нечетных чисел и выведите его.

        var arr = new int[15];
        var oddCount = 0;
        
        for (var i = 0; i < arr.Length; i++)
        {
            arr[i] = RandomNumber(1, 100);

            if (arr[i] % 2 == 0)
            {
                Console.WriteLine(arr[i]);
            }
            else
            {
                oddCount++;
            }
        }
        
        Console.WriteLine($"Количество нечётных чисел: {oddCount}");
    }
}
