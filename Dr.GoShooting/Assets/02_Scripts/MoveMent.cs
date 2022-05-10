using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    Vector3 moveDirection = Vector3.zero;

    private void Update()
    {
        transform.position += moveDirection * Time.deltaTime * moveSpeed;
    }

    public void MoveTo(Vector3 direction)
    {
        moveDirection = direction;
    }
}
