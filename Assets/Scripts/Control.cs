using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    SpriteRenderer sprite;
    private bool Moving = false;
    private KeyCode last = KeyCode.None;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && !Moving && 
            last != KeyCode.W)
        {
            last = KeyCode.W;
            StartCoroutine(MovePlayer(Vector3.up, KeyCode.UpArrow));
        }
        else if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && !Moving &&
            last != KeyCode.S)
        {
            last= KeyCode.S;
            StartCoroutine(MovePlayer(Vector3.down, KeyCode.DownArrow));
        }
        else if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && !Moving &&
            last != KeyCode.A)
        {
            last = KeyCode.A;
            StartCoroutine(MovePlayer(Vector3.left, KeyCode.LeftArrow));
            sprite.flipX = false;
        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && !Moving && 
            last != KeyCode.D)
        {
            last = KeyCode.D;
            StartCoroutine(MovePlayer(Vector3.right, KeyCode.RightArrow));
            sprite.flipX = true;
        }
        else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && !Moving)
        {
            last = KeyCode.W;
            StartCoroutine(MovePlayer(Vector3.up, KeyCode.UpArrow));
        }
        else if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && !Moving)
        {
            StartCoroutine(MovePlayer(Vector3.down, KeyCode.DownArrow));
        }
        else if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && !Moving)
        {
            StartCoroutine(MovePlayer(Vector3.left, KeyCode.LeftArrow));
            sprite.flipX = false;
        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && !Moving)
        {
            StartCoroutine(MovePlayer(Vector3.right, KeyCode.RightArrow));
            sprite.flipX = true;
        }
    }

    private IEnumerator MovePlayer(Vector3 direction, KeyCode but)
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
            if (Input.GetKey(but))
            {
                time = 0;
                while (time < 0.01f)
                {
                    time += Time.deltaTime;
                    yield return null;
                }
            }
        }
        Moving = false;
    }
}
