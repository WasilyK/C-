namespace arrays;

public class ArrayHelper {

    public int[,] GetRandomArray(int rows, int cols, int minValue, int maxValue) {
        if(rows <= 0 || cols <= 0) {
            return null;
        }
        int[,] arr = new int[rows, cols];
        Random rand = new Random();
        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < cols; j++) {
                arr[i,j] = rand.Next(minValue, maxValue + 1);
            }
        }

        return arr;
    }

    public void PrintArray(int[,] arr) {
        if(arr == null) {
            Console.WriteLine("array is null");
            return;
        }
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        for(int i = 0; i < rows; i++) {
            for(int j = 0; j < cols; j++) {
                Console.Write(arr[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}
