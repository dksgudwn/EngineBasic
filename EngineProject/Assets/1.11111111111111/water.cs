using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    [SerializeField] float speed;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 d = new Vector3(0,-1,0);
        transform.position+=speed * d * Time.deltaTime;
    }
}
