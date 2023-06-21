using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WinCheck : MonoBehaviour
{
    public static int[,] map, map_crosses;
    public static int posx;
    public static int posy;
    public static Vector3 pl_direction;

    [SerializeField] GameObject window;
    // Start is called before the first frame update
    void Start()
    {
        Movement.Box_moved.AddListener(Win_Check);
        map_crosses = StageGenScript.lvl_crosses;
    }

    public void Win_Check()
    {
        int ct = 0, ct_boxes = 0;
        map = (int[,])Movement.map.Clone();
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == 2) ct_boxes++;
                if (map[i, j] == 2 && map_crosses[i, j] == 4) ct++;
            }
        }
        if (ct == ct_boxes) window.SetActive(true);
    } 
}
