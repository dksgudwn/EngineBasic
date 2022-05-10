using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float timeSpan = 0.7f;
    float currentTime = 0f;
    public GameManager gameManager;
    Vector3 pos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime += Time.deltaTime;
        if (currentTime >= timeSpan) 
        {
           
            GameObject obj= Instantiate(arrowPrefab);
            //pos.x = Random.Range(-9.0f, 9.0f);
            //pos.y = 6f;
            pos = new Vector3(Random.Range(-8.0f, 8.0f), 6f, 0);
            //obj.GetComponent<arrowscript>().gameManager = this.gameManager;??????/
            obj.transform.position = pos;
            currentTime = 0;
            
        }
    }
   
}
