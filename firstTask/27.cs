// See https://aka.ms/new-console-template for more information

namespace taskFirst {
    public class Programm {
        public static void Main() {
            int w, h, n;
            string inputLine;
            string[] inputArray;

            inputLine = Console.ReadLine();
            inputArray = inputLine.Split(" ");
            w = Convert.ToInt32(inputArray[0]);
            h = Convert.ToInt32(inputArray[1]);
            n = Convert.ToInt32(Console.ReadLine());

            bool[,] canvasArray = new bool[w, h];
            for (int i = 0; i < w; i++) {
                for (int j = 0; j < h; j++) {
                    canvasArray[i, j] = false;
                }
            }

            for (int s = 0; s < n; s++) {
                inputLine = Console.ReadLine();
                inputArray = inputLine.Split(' ');

                int x1 = Convert.ToInt32(inputArray[0]);
                int y1 = Convert.ToInt32(inputArray[1]);
                int x2 = Convert.ToInt32(inputArray[2]);
                int y2 = Convert.ToInt32(inputArray[3]);

                for (int xn = x1; xn < x2; xn++) {
                    for (int yn = y1; yn < y2; yn++) {
                        canvasArray[xn, yn] = true;
                        Console.WriteLine("(" + xn + ":" + yn + ")");
                    }
                }
            }

            int result = 0;

            for (int i = 0; i < w; i++) {
                for (int j = 0; j < h; j++) {
                    if (!canvasArray[i, j]) {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
