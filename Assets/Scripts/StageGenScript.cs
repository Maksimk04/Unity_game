using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Threading;
using System.Timers;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class StageGenScript : MonoBehaviour
{
    public GameObject wall;
    public GameObject box;
    public GameObject cross;
    public GameObject player;


    public static int[,] lvl_layout;
    public static int[,] lvl_crosses;
    public static int level_id = 1;
    // Start is called before the first frame update

    void Awake()
    {
        lvl_layout = (int[,])Levels.levels[level_id].Clone();

        for (int i = 0; i < lvl_layout.GetLength(0); i++)
        {
            for (int j = 0; j < lvl_layout.GetLength(1); j++)
            {
                switch (lvl_layout[i, j])
                {
                    case 1:
                        Instantiate(wall, new UnityEngine.Vector3(j, -i, 0), UnityEngine.Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(box, new UnityEngine.Vector3(j, -i, 0), UnityEngine.Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(player, new UnityEngine.Vector3(j, -i, 0), UnityEngine.Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(cross, new UnityEngine.Vector3(j, -i, 0), UnityEngine.Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(cross, new UnityEngine.Vector3(j, -i, 0), UnityEngine.Quaternion.identity);
                        Instantiate(box, new UnityEngine.Vector3(j, -i, 0), UnityEngine.Quaternion.identity);
                        break;
                    default:
                        break;
                }
            }
        }
        lvl_crosses = Levels.find_crosses(lvl_layout);
        Levels.replace_crosses(lvl_layout);
    }
}
