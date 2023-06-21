using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MovePlayer(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MovePlayer(Vector3.down);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            MovePlayer(Vector3.left);
            sprite.flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            MovePlayer(Vector3.right);
            sprite.flipX = true;
        }
    }

    private void MovePlayer(Vector3 direction)
    {
        if (Movement.Move(direction))
        {
            transform.position = transform.position + direction;
        }
    }
}
