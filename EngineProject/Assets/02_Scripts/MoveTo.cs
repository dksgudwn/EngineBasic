using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private GameObject boomPrefab;
    public Transform UpTarget;
    public Transform DownTarget;
    public float Speed = 5f;
    public float Timer = 0f;
    Vector3 d = new Vector3(-6.5f, -3.5f, 0);
    private void Start()
    {
    }
    private void Update()
    {   
        StartCoroutine(countTimer());
        if(Timer>=3f)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                GameObject bullet = Instantiate(boomPrefab, d, Quaternion.identity);
                Timer -= 3f;
            }
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            StartCoroutine(UpMove(5f));
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            StartCoroutine(DownMove(5f));
        }
    }
    IEnumerator UpMove(float Speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, UpTarget.position, Speed * Time.deltaTime);
        yield return null;
    }
    IEnumerator DownMove(float Speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, DownTarget.position, Speed * Time.deltaTime);
        yield return null;
    }
    IEnumerator countTimer()
    {
        Timer +=Time.deltaTime;
        yield return null;
    }
}
