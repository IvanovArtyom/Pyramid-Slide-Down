using System;

public class PyramidSlideDown
{
    public static void Main()
    {
        var mediumPyramid = new[]
        {
            new []                             {75},
            new []                           {95, 64},
            new []                         {17, 47, 82},
            new []                       {18, 35, 87, 10},
            new []                     {20,  4, 82, 47, 65},
            new []                   {19,  1, 23, 75,  3, 34},
            new []                 {88,  2, 77, 73,  7, 63, 67},
            new []               {99, 65,  4, 28,  6, 16, 70, 92},
            new []             {41, 41, 26, 56, 83, 40, 80, 70, 33},
            new []           {41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
            new []         {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
            new []       {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
            new []     {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
            new []   {63, 66,  4, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
            new [] { 4, 62, 98, 27, 23,  9, 70, 98, 73, 93, 38, 53, 60,  4, 23}
        };

        // Test
        var t = LongestSlideDown(mediumPyramid);
        // ...should return 1074 (75+64+82+87+82+75+73+28+83+32+91+78+58+73+93 = 1074)
    }

    public static int LongestSlideDown(int[][] pyramid)
    {
        for (int i = pyramid.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < pyramid[i].Length - 1; j++)
                pyramid[i - 1][j] += Math.Max(pyramid[i][j], pyramid[i][j + 1]);
        }

        return pyramid[0][0];
    }
}