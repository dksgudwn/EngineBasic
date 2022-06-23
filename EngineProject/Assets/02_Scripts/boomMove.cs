using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomMove : MonoBehaviour
{
    public float speed = 0.01f;
    [SerializeField] GameObject boomEffect1;
    [SerializeField] GameObject boomEffect2;
    public GameObject Zone = null;
    private Vector3 dir;
    Vector3 d = new Vector3(-4.24f, 3.5f, 0);
    Vector3 ddd = new Vector3(6,0,0);
    private void Start()
    {
        StartCoroutine(boom());
        Zone.SetActive(true);
    }
    private void Update()
    {

    }
    private void Boom()
    {
        Instantiate(boomEffect1, transform.position,Quaternion.identity);
        dd();
        Invoke("Boom2",1.5f);
    }
    private void Boom2()
    {
        Instantiate(boomEffect2, transform.position,Quaternion.identity);
        
    }
    IEnumerator boom()
    {
        while(true)
        {
            if(transform.position.x>=4.25)
            {
                speed = 0f;
                Boom();
                gameObject.SetActive(false);
            }
            transform.Translate(transform.right * speed * Time.deltaTime);
            yield return null;
        }
    }
    void dd()
    {
        Instantiate(Zone, ddd, Quaternion.identity);
    }
}
