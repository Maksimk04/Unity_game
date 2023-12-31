using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using UnityEditorInternal;
//using UnityEditorInternal;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public static int[,] find_crosses(int[,] mat)
    {
        int[,] crosses = new int[mat.GetLength(0), mat.GetLength(1)];
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                crosses[i, j] = ((mat[i, j] == 4 || mat[i, j] == 5) ? 4 : 0);
            }
        }
        return crosses;
    }

    public static void replace_crosses(int[,] mat)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                mat[i, j] = (mat[i, j] == 5 ? 2 : mat[i, j]);
            }
        }
    }

    // 0 - empty
    // 1 - brick
    // 2 - box
    // 3 - player
    // 4 - cross
    // 5 - box on cross

    public static int[,] level1 =
         {{0,0,0,0,1,1,1,0,0,0,0},
          {0,0,0,0,1,4,1,0,0,0,0},
          {0,0,0,0,1,0,1,0,0,0,0},
          {0,1,1,1,1,2,1,1,1,1,0},
          {0,1,4,0,2,3,2,0,4,1,0},
          {0,1,1,1,1,2,1,1,1,1,0},
          {0,0,0,0,1,4,1,0,0,0,0},
          {0,0,0,0,1,1,1,0,0,0,0}};

    public static int[,] level2 =
         {{0,0,0,0,0,0,0,1,1,1},
          {0,0,0,0,0,0,0,1,4,1},
          {0,0,0,0,0,0,0,1,4,1},
          {0,0,1,1,1,1,1,1,4,1},
          {0,0,1,0,0,2,0,0,0,1},
          {1,1,1,0,2,0,2,0,0,1},
          {1,3,0,0,0,0,0,0,0,1},
          {1,1,1,1,1,1,1,1,1,1}};

    public static int[,] level3 =
         {{0,0,0,0,1,1,1,0,0,0,0},
          {0,0,0,1,1,4,1,1,0,0,0},
          {0,0,1,1,1,0,4,1,1,0,0},
          {0,1,1,4,2,2,2,1,1,1,0},
          {0,1,4,0,2,3,2,0,4,1,0},
          {0,1,1,1,2,2,2,4,1,1,0},
          {0,0,1,1,4,0,1,1,1,0,0},
          {0,0,0,1,1,4,1,1,0,0,0},
          {0,0,0,0,1,1,1,0,0,0,0}};

    public static int[,] level4 =
         {{0,1,1,1,1,1,0,0,0,0,0},
          {0,1,0,0,0,1,1,1,1,0,0},
          {0,1,0,0,0,1,0,0,1,0,0},
          {0,1,1,0,0,0,0,4,1,0,0},
          {1,1,1,0,1,1,1,4,1,0,0},
          {1,0,2,0,1,0,1,4,1,0,0},
          {1,0,2,2,1,0,1,1,1,0,0},
          {1,3,0,0,1,0,0,0,0,0,0},
          {1,1,1,1,1,0,0,0,0,0,0}};

    public static int[,] level5 =
         {{1,1,1,1,1,1,1},
          {1,4,0,2,0,4,1},
          {1,4,2,2,2,3,1},
          {1,4,0,2,0,4,1},
          {1,1,1,1,1,1,1}};

    public static int[,] level6 =
         {{1,1,1,1,0,0,0,0},
          {1,0,0,1,1,1,0,0},
          {1,0,0,0,0,1,1,1},
          {1,0,0,2,5,3,0,1},
          {1,1,1,0,4,1,0,1},
          {0,0,1,0,0,0,0,1},
          {0,0,1,1,1,1,1,1}};

    public static int[,] level7 =
         {{1,1,1,1,1,1,1,1},
          {1,0,0,0,0,0,0,1},
          {1,0,4,5,5,2,3,1},
          {1,0,0,0,0,0,0,1},
          {1,1,1,1,1,0,0,1},
          {0,0,0,0,1,1,1,1}};

    public static int[,] level8 =
         {{0,0,0,0,0,0,1,1,1,1,1},
          {0,0,0,0,0,0,1,4,0,0,1},
          {0,0,0,0,0,0,1,4,1,0,1},
          {1,1,1,1,1,1,1,4,1,0,1},
          {1,0,3,0,2,0,2,0,2,0,1},
          {1,0,1,0,1,0,1,0,1,1,1},
          {1,0,0,0,0,0,0,0,1,0,0},
          {1,1,1,1,1,1,1,1,1,0,0}};

    public static int[,] level9 =
         {{1,1,1,1,1,1,1,1},
          {1,0,0,0,3,0,0,1},
          {1,0,0,0,5,0,0,1},
          {1,1,1,4,2,1,1,1},
          {0,0,1,0,5,0,1,0},
          {0,0,1,0,0,0,1,0},
          {0,0,1,1,1,1,1,0}};

    public static int[,] level10 =
         {{0,1,1,1,1,0,0},
          {0,1,0,0,1,1,1},
          {0,1,0,2,2,0,1},
          {1,1,4,4,4,0,1},
          {1,0,0,3,2,0,1},
          {1,0,0,0,1,1,1},
          {1,1,1,1,1,0,0}};

    public static int[,] level11 =
    {{0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,0,1,2,0,0,1,0,0,0,0,0,0,0,0,0,0},
          {0,0,1,1,1,0,0,2,1,1,0,0,0,0,0,0,0,0,0},
          {0,0,1,0,0,2,0,2,0,1,0,0,0,0,0,0,0,0,0},
          {1,1,1,0,1,0,1,1,0,1,0,0,0,1,1,1,1,1,1},
          {1,0,0,0,1,0,1,1,0,1,1,1,1,1,0,0,4,4,1},
          {1,0,2,0,0,2,0,0,0,0,0,0,0,0,0,0,4,4,1},
          {1,1,1,1,1,0,1,1,1,0,1,3,1,1,0,0,4,4,1},
          {0,0,0,0,1,0,0,0,0,0,1,1,1,1,1,1,1,1,1},
          {0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0}};

    public static int[,] level12 =
        {{1,1,1,1,1,1,0,0,1,1,1,0},
          {1,4,4,0,0,1,0,1,1,3,1,1},
          {1,4,4,0,0,1,1,1,0,0,0,1},
          {1,4,4,0,0,0,0,0,2,2,0,1},
          {1,4,4,0,0,1,0,1,0,2,0,1},
          {1,4,4,1,1,1,0,1,0,2,0,1},
          {1,1,1,1,0,2,0,1,2,0,0,1},
          {0,0,0,1,0,0,2,1,0,2,0,1},
          {0,0,0,1,0,2,0,0,2,0,0,1},
          {0,0,0,1,0,0,1,1,0,0,0,1},
          {0,0,0,1,1,1,1,1,1,1,1,1}};

    public static int[,] level13 =
        {{0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,0},
          {0,0,0,0,0,0,0,0,1,0,0,0,0,0,3,1,0},
          {0,0,0,0,0,0,0,0,1,0,2,1,2,0,1,1,0},
          {0,0,0,0,0,0,0,0,1,0,2,0,0,2,1,0,0},
          {0,0,0,0,0,0,0,0,1,1,2,0,2,0,1,0,0},
          {1,1,1,1,1,1,1,1,1,0,2,0,1,0,1,1,1},
          {1,4,4,4,4,0,0,1,1,0,2,0,0,2,0,0,1},
          {1,1,4,4,4,0,0,0,0,2,0,0,2,0,0,0,1},
          {1,4,4,4,4,0,0,1,1,1,1,1,1,1,1,1,1},
          {1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0}};

    public static int[,] level14 =
         {{1,1,1,1,0,0,0,0,0},
          {1,0,3,1,1,1,0,0,0},
          {1,0,5,0,0,1,1,1,1},
          {1,0,5,0,0,0,0,0,1},
          {1,0,5,0,1,1,0,0,1},
          {1,0,5,0,1,0,5,0,1},
          {1,0,5,0,1,0,5,0,1},
          {1,0,5,0,1,0,5,0,1},
          {1,0,4,1,1,0,5,0,1},
          {1,0,0,0,0,0,2,0,1},
          {1,1,1,1,1,1,0,0,1},
          {0,0,0,0,0,1,1,1,1}};

    public static int[,] level15 =
         {{0,0,1,1,1,1,1,1,1,0,0},
          {0,0,1,0,0,1,0,0,1,1,1},
          {1,1,1,4,2,4,2,4,0,3,1},
          {1,0,0,4,0,1,2,4,2,0,1},
          {1,0,1,2,0,4,2,4,0,1,1},
          {1,0,0,4,0,2,2,0,1,1,0},
          {1,1,1,0,0,1,0,0,1,0,0},
          {0,0,1,1,1,1,1,1,1,0,0}};

    public static List<int[,]> levels = new List<int[,]>()
    {
        level1,
        level2,
        level3,
        level4,
        level5,
        level6,
        level7,
        level8,
        level9,
        level10,
        level11,
        level12,
        level13,
        level14,
        level15
    };
}
