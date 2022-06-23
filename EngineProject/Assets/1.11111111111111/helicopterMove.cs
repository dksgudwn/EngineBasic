using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopterMove : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject water;
    [SerializeField] float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 d = new Vector3(x,y,0);
        transform.position += d * speed * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartFiring();
        }
        else //(Input.GetKeyUp(KeyCode.Space))
        {
            StopFiring();
        }
    }
    IEnumerator Water()
    {
        Instantiate(water, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(spawnTime);
    }
    void StartFiring()
    {
        StartCoroutine("Water");
    }

    void StopFiring()
    {
        StopCoroutine("Water");
    }
}
