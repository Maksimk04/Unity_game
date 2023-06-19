using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // добавить логику определения лвла.  
    static int[,] map;
    static int posx;
    static int posy;
    
    void Start()
    {
        map = Levels.level1;
        posx = (int)Levels.posLvl1.x;
        posy = (int)Levels.posLvl1.y;
    }

    public static bool Move(Vector3 direction)
    {
        // добавить движение ящиков
        if (direction == Vector3.up && map[posx - 1, posy] != 1)
        {
            posx--;
            return true;
        }
        else if (direction == Vector3.down && map[posx + 1, posy] != 1)
        {
            posx++;
            return true;
        }
        else if (direction == Vector3.left && map[posx, posy - 1] != 1)
        {
            posy--;
            return true;
        }
        else if (direction == Vector3.right && map[posx, posy + 1] != 1)
        {
            posy++;
            return true;
        }
        return false;
    }
}
