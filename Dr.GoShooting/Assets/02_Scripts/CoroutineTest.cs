using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    public GameObject playerBullet;
    public Transform transform2;
    void Start()
    {
        StartCoroutine("Fire");
        
    }
    IEnumerator Fire()
    {
        while(true)
        {
            if(Input.GetKey(KeyCode.Space))
            {
                Instantiate(playerBullet, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }
            else{
                yield return new WaitForSeconds(0);
            }
        }
    }
}
