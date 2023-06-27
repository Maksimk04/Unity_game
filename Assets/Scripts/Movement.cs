using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
//using UnityEditor.PackageManager;
//using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour
{
    public static int[,] map;
    public static int posx;
    public static int posy;
    public static Vector3 pl_direction;

    public static UnityEvent Box_moved = new UnityEvent();

    void Start()
    {
        map = (int[,])StageGenScript.lvl_layout.Clone();
        Vector2 posLvl = FindPlayer(map);
        posx = (int)posLvl.x;
        posy = (int)posLvl.y;
    }

    public static bool Move(Vector3 direction)
    {
        pl_direction = direction;
        if (direction == Vector3.up && map[posy - 1, posx] != 1)
        {
            if (map[posy - 1, posx] == 2 && !IsBoxAbleToMove(direction)) return false;
            posy--;
            return true;
        }
        else if (direction == Vector3.down && map[posy + 1, posx] != 1)
        {
            if (map[posy + 1, posx] == 2 && !IsBoxAbleToMove(direction)) return false;
            posy++;
            return true;
        }
        else if (direction == Vector3.left && map[posy, posx - 1] != 1)
        {
            if (map[posy, posx - 1] == 2 && !IsBoxAbleToMove(direction)) return false;
            posx--;
            return true;
        }
        else if (direction == Vector3.right && map[posy, posx + 1] != 1)
        {
            if (map[posy, posx + 1] == 2 && !IsBoxAbleToMove(direction)) return false;
            posx++;
            return true;
        }
        return false;
    }

    static bool IsBoxAbleToMove(Vector3 direction)
    {
        if (direction == Vector3.left && (map[posy, posx - 2] == 0 || map[posy, posx - 2] == 4 || map[posy, posx - 2] == 3))
        {
            map[posy, posx - 2] = 2;
            map[posy, posx - 1] = 0;
            Box_moved.Invoke();
            return true;
        }
        else if (direction == Vector3.right && (map[posy, posx + 2] == 0 || map[posy, posx + 2] == 4 || map[posy, posx + 2] == 3))
        {
            map[posy, posx + 2] = 2;
            map[posy, posx + 1] = 0;
            Box_moved.Invoke();
            return true;
        }
        else if (direction == Vector3.up && (map[posy - 2, posx] == 0 || map[posy - 2, posx] == 4 || map[posy - 2, posx] == 3))
        {
            map[posy - 2, posx] = 2;
            map[posy - 1, posx] = 0;
            Box_moved.Invoke();
            return true;
        }
        else if (direction == Vector3.down && (map[posy + 2, posx] == 0 || map[posy + 2, posx] == 4 || map[posy + 2, posx] == 3))
        {
            map[posy + 2, posx] = 2;
            map[posy + 1, posx] = 0;
            Box_moved.Invoke();
            return true;
        }
        return false;
    }

    public Vector2 FindPlayer(int[,] map)
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == 3)
                {
                    return new Vector2(j, i);
                }
            }
        }
        return new Vector2(0, 0);
    }
}
