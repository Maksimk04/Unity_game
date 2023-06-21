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
    // Start is called before the first frame update

    void Awake()
    {
        string current_level = SceneManager.GetActiveScene().name;

        switch (current_level)
        {
            case "level1":
                Debug.Log(current_level);
                lvl_layout = (int[,])Levels.level1.Clone();
                break;
            case "level2":
                lvl_layout = (int[,])Levels.level2.Clone();
                break;
            case "level3":
                lvl_layout = (int[,])Levels.level3.Clone();
                break;
            case "level4":
                lvl_layout = (int[,])Levels.level4.Clone();
                break;
            case "level5":
                lvl_layout = (int[,])Levels.level5.Clone();
                break;
            default:
                lvl_layout = (int[,])Levels.level1.Clone();
                break;
        }
        
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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
