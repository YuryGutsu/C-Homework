namespace PupilsScore
{
    internal class Program
    {
        static void PrintStatistics(int[] array, string name)
        {
            int min = MinMark(array);
            int max = MaxMark(array);
            float avg = AverageMark(array);
            Console.WriteLine($"{name}:\nMin. mark ={min}\nMax. mark ={max}\nAverage mark ={avg}\n");
        }
        static int MinMark(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                { 
                    min = array[i];
                }
            }
            return min;
        }

        static int MaxMark(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) 
                {
                    max = array[i];
                }
            }
            return max;
        }

        static float AverageMark(int[] array)
        {
            float avg = 0F;
            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i];
            }
            return avg / array.Length;
        }

        static void Main(string[] args)
        {
            int[] Masha = { 9, 6, 8, 5, 10, 4, 2, 7, 9, 8 };
            int[] Petya = { 7, 9, 10, 6, 9, 10, 8, 5, 4, 7 };
            int[] Olya = { 9, 8, 10, 4, 9, 6, 5, 10, 9, 10 };
            int[] Dima = { 10, 7, 8, 6, 9, 4, 10, 6, 9, 5 };
            int[] Vanya = { 8, 4, 9, 10, 10, 8, 3, 8, 9, 10 };

            PrintStatistics(Masha, "Masha");
            PrintStatistics(Petya, "Petya");
            PrintStatistics(Olya, "Olya");
            PrintStatistics(Dima, "Dima");
            PrintStatistics(Vanya, "Vanya");
        }
    }
}