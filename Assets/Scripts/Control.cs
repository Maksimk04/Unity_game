using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.2f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            StartCoroutine(MovePlayer(Vector3.up));

        if (Input.GetKeyDown(KeyCode.S))
            StartCoroutine(MovePlayer(Vector3.down));

        if (Input.GetKeyDown(KeyCode.A))
            StartCoroutine(MovePlayer(Vector3.left));

        if (Input.GetKeyDown(KeyCode.D))
            StartCoroutine(MovePlayer(Vector3.right));
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        transform.position = transform.position + direction;
        return null;
    }
}
