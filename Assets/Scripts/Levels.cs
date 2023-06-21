using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using UnityEditorInternal;
using UnityEngine;

public class Levels : MonoBehaviour
{
    // 1 - brick
    // 2 - box
    // 3 - player
    // 4 - cross
    // 5 - box on cross

    // 11 - x, 8 - y

    public static int[,] find_crosses(int[,] mat)
    {
        int[,] crosses = new int[mat.GetLength(0), mat.GetLength(1)];
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                crosses[i, j] = ((mat[i, j] == 4 || mat[i,j] == 5) ? 4 : 0);
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

    public static Vector2 posLvl1 = new Vector2(11, 8); 
    // level1 (19, 11) 

    public static int[,] level1 =
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

    public static int[,] level1crosses =
        {{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
          {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}};

    // clove
    public static Vector2 posLvl2 = new Vector2(9, 1);
    // level2 (12, 11)

    public static int[,] level2 =
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

    //soko#3
    public static Vector2 posLvl3 = new Vector2(14, 1);

    public static int[,] level3 =
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

    // 9 - 12
    public static int[,] level4 =
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

    public static int[,] level5 =
         {{0,0,1,1,1,1,1,1,1,0,0},
          {0,0,1,0,0,1,0,0,1,1,1},
          {1,1,1,4,2,4,2,4,0,3,1},
          {1,0,0,4,0,1,2,4,2,0,1},
          {1,0,1,2,0,4,2,4,0,1,1},
          {1,0,0,4,0,2,2,0,1,1,0},
          {1,1,1,0,0,1,0,0,1,0,0},
          {0,0,1,1,1,1,1,1,1,0,0}};
}
