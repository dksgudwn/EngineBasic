using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 d = new Vector3(-1,0,0);
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Time.deltaTime * speed * d;
        if(transform.position.x <= -19.8f)
        {
            transform.position = new Vector3(20,0,0);
        }
    }
}
