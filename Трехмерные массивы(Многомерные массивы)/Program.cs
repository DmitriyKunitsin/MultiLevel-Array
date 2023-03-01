namespace Трехмерные_массивы_Многомерные_массивы_
{
    internal class Program
    {
        // Если я ковыряюсь в массиве [,,,,,], то октуален метод GetLength(..), т.к. им я перемещаюсь
        // по измерениям массива, а если массив не однородный(ступенчатый, зубчатый), то
        // надо перебирать каждый массив методом Length, т.к. я смотрю его длину
        static void Main(string[] args)
        {
            int[,,,] NewArray = new int[2,2,5,5];
            Random RandomNumberArray= new Random();
            for (int p = 0; p < NewArray.GetLength(0); p++)
            {
                for (int u = 0; u < NewArray.GetLength(1); u++)
                {
                    for (int i = 0; i < NewArray.GetLength(2); i++)
                    {
                        for (int o = 0; o < NewArray.GetLength(3); o++)
                        {
                            NewArray[p, u, i, o] = RandomNumberArray.Next(1,50);
                        }
                    }
                }
            }
            for (int p = 0; p < NewArray.GetLength(0); p++)
            {
                Console.WriteLine("Book # :"+ (p + 1));
                for (int u = 0; u < NewArray.GetLength(1); u++)
                {
                    Console.WriteLine("Page # :" + (u + 1));
                    for (int i = 0; i < NewArray.GetLength(2); i++)
                    {
                        for (int o = 0; o < NewArray.GetLength(3); o++)
                        {
                            Console.Write(NewArray[p,u, i, o] + " "); ;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            } 
        }
    }
}