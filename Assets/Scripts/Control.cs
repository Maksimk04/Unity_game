using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    SpriteRenderer sprite;
    private bool Moving = false;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && !Moving)
        {
            StartCoroutine(MovePlayer(Vector3.up));
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) && !Moving)
        {
            StartCoroutine(MovePlayer(Vector3.down));
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) && !Moving)
        {
            StartCoroutine(MovePlayer(Vector3.left));
            sprite.flipX = false;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && !Moving)
        {
            StartCoroutine(MovePlayer(Vector3.right));
            sprite.flipX = true;
        }
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        Moving = true;
        float time = 0;
        Vector3 PosStart = transform.position;
        Vector3 Pos = PosStart + direction;

        if (Movement.Move(direction))
        {
            //transform.position = transform.position + direction;
            while (time  < 0.15f)
            {
                transform.position = Vector3.Lerp(PosStart, Pos, (time / 0.15f));
                time+= Time.deltaTime;
                yield return null;
            }
            transform.position = Pos;
            time = 0;
            while (time < 0.01f)
            {
                //transform.position = Vector3.Lerp(BoxPos, Pos, (time / 0.15f));
                time += Time.deltaTime;
                yield return null;
            }
        }
        Moving = false;
    }
}
