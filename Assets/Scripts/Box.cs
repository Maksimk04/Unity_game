using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.PlayerSettings;

public class Box : MonoBehaviour
{
    [SerializeField] Transform Transform;
    static Vector3 box_pos;

    private void Start()
    {
        Movement.Box_moved.AddListener(BoxMoved);
    }
    public void BoxMoved()
    {
        box_pos = Transform.position;
        
        Vector3 direction = Movement.pl_direction; 
        Vector2 pos = GameObject.FindGameObjectWithTag("Player").transform.position;

        if (direction == Vector3.right && box_pos.x == pos.x + 1 && box_pos.y == pos.y)
        {
            Move(direction, box_pos);
        }
        else if (direction == Vector3.left && box_pos.x == pos.x - 1 && box_pos.y == pos.y)
        {
            Move(direction, box_pos);
        }
        else if (direction == Vector3.down && box_pos.x == pos.x && box_pos.y == pos.y - 1)
        {
            Move(direction, box_pos);
        }
        else if (direction == Vector3.up && box_pos.x == pos.x && box_pos.y == pos.y + 1)
        {
            Move(direction, box_pos);
        }
    }

    private void Move(Vector3 direction, Vector2 BoxPos)
    {
        if (direction == Vector3.up)
        {
            Transform.position = new Vector2(BoxPos.x, BoxPos.y + 1);
        }
        else if (direction == Vector3.down)
        {
            Transform.position = new Vector2(BoxPos.x, BoxPos.y - 1);
        }
        else if (direction == Vector3.left)
        {
            Transform.position = new Vector2(BoxPos.x - 1, BoxPos.y);
        }
        else if (direction == Vector3.right)
        {
            Transform.position = new Vector2(BoxPos.x + 1, BoxPos.y);
        }
    }
}
