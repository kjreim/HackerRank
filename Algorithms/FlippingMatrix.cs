namespace HackerRank.Algorithms;

public class FlippingMatrix
{
    public static int Solve(List<List<int>> matrix)
    {
        var sumMatrix = matrix[0].Count() / 2;
        var result = 0;
        for(var row = 0; row < sumMatrix; row++) {
            for(var column = 0; column < sumMatrix; column++) {
                var original = matrix[row][column];
                var rowFlip = matrix[2 * sumMatrix - row - 1][column];
                var rowAndColumnFlip = matrix[2 * sumMatrix - row - 1][2 * sumMatrix - 1 - column];
                var columnFlip = matrix[row][2 * sumMatrix - 1 - column];
                
                // result += Math.Max(original, Math.Max(rowFlip, Math.Max(rowAndColumnFlip, columnFlip)));
                result += Max([original, rowFlip, columnFlip, rowAndColumnFlip]);
            }
        
        }
        
        return result;

        static int Max(params int[] numbers) {
            return numbers.Max();
        }
    }
}