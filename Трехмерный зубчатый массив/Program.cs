namespace Трехмерный_зубчатый_массив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RandomNumberArray = new Random();
            int[][][] NewArray = new int[RandomNumberArray.Next(2, 5)][][];
            for (int u = 0; u < NewArray.Length; u++)
            {
                NewArray[u] = new int [RandomNumberArray.Next(2, 5)][];
                for (int i = 0; i < NewArray[u].Length; i++)
                {
                    NewArray[u][i] = new int[RandomNumberArray.Next(4, 8)]; 
                    for (int o = 0; o < NewArray[u][i].Length; o++)
                    {
                        NewArray[u][i][o] = RandomNumberArray.Next(8, 150);
                    }
                }
            }
            for (int u = 0; u < NewArray.Length; u++)
            {
                Console.WriteLine("Book # :" + (u+1));
                for (int i = 0; i < NewArray[u].Length; i++)
                {
                    Console.WriteLine("Page # :" + (i + 1));
                    for (int o = 0; o < NewArray[u][i].Length; o++)
                    {
                        Console.Write(NewArray[u][i][o]+ " "); ;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


        }
    }
}