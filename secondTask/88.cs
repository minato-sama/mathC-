namespace taskSecond
{
    public class Programm
    {
        public static void Main()
        {
            int n, doubleN;
            string inputLine;
            string[] inputArray;

            try
            {
                inputLine = Console.ReadLine();
                n = Convert.ToInt32(inputLine);
                doubleN = n * n;
                int[,] arraySudoku = new int[doubleN, doubleN];

                for (int i = 0; i < doubleN; i++)
                {
                    inputLine = Console.ReadLine();
                    inputArray = inputLine.Split(" ");

                    if (inputArray.Length != doubleN)
                    {
                        Console.WriteLine("incorrect");
                        return;
                    }
                    else
                    {
                        for (int j = 0; j < doubleN; j++)
                        {
                            arraySudoku[i, j] = Convert.ToInt32(inputArray[j]);
                        }
                    }
                }

                
                int[] correctArray = Enumerable.Range(1, doubleN).ToArray();
                for (int i = 0; i < doubleN; i++)
                {
                    int[] tempArray = (int[])correctArray.Clone();
                    for (int j = 0; j < doubleN; j++)
                    {
                        if (arraySudoku[i, j] < 0 || arraySudoku[i, j] > doubleN)
                        {
                            Console.WriteLine("incorrect");
                            return;
                        }
                        else
                        {
                            tempArray[arraySudoku[i, j] - 1] = 0;
                        }
                    }

                    if (tempArray.Sum() != 0)
                    {
                        Console.WriteLine("incorrect");
                        return;
                    }
                }

                for (int j = 0; j < doubleN; j++)
                {
                    int[] tempArray = (int[])correctArray.Clone();
                    for (int i = 0; i < doubleN; i++)
                    {
                        if (arraySudoku[i, j] < 0 || arraySudoku[i, j] > doubleN)
                        {
                            Console.WriteLine("incorrect");
                            return;
                        }
                        else
                        {
                            tempArray[arraySudoku[i, j] - 1] = 0;
                        }
                    }

                    if (tempArray.Sum() != 0)
                    {
                        Console.WriteLine("incorrect");
                        return;
                    }
                }

                for (int iArr = 0; iArr < n; iArr++)
                {
                    for (int jArr = 0; jArr < n; jArr++)
                    {
                        int[] tempArray = (int[])correctArray.Clone();
                        int[] tempQuad = new int[doubleN];
                        int index = 0;
                        for (int i = n * iArr; i < n + n * iArr; i++)
                        {
                            for (int j = n * jArr; j < n + n * jArr; j++)
                            {
                                tempQuad[index++] = arraySudoku[i, j];
                            }
                        }

                        for (int i = 0; i < doubleN; i++)
                        {
                            tempArray[tempQuad[i] - 1] = 0;
                        }

                        if (tempArray.Sum() != 0)
                        {
                            Console.WriteLine("incorrect");
                            return;
                        }
                    }
                }
                Console.WriteLine("correct");
            }
            catch
            {
                Console.WriteLine("incorrect");
            }
        }
    }
}
