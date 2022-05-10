using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    Transform tr;
    public float speed = 100f;
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tr.position += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tr.position += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tr.position += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tr.position += Vector3.down * Time.deltaTime * speed;
        }
    }

    public void LButtonDown()
    {
        transform.Translate(Vector3.right * 3);
    }
    public void RButtonDown()
    {
        transform.Translate(Vector3.left * 3);
    }
}