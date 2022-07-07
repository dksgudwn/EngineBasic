using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : Pooled
{
    [SerializeField] float speed;
    int damage = 1;
    void Start()
    {
    }

    void Update()
    {
        Vector3 d = new Vector3(0,-1,0);
        transform.position+=speed * d * Time.deltaTime;
        //Invoke("AutoDestroy",2f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<Enemy>().TakeDamage(damage);
        Destroy(gameObject);
        
    }
    private void AutoDestroy()
    {
        Destroy(gameObject);
    }
}
