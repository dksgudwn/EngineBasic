using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dd : MonoBehaviour
{
    [SerializeField] Transform ddd;
    int damage = 1;
    //nt dDamage = 1;
    private float currentHp;
    
    [SerializeField] int maxHp = 2;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
    }
    void TakeDamage(int damage)
    {
        currentHp -= damage;
        if(currentHp<=0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = ddd.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(currentHp);
        TakeDamage(damage);
        Destroy(other.gameObject);
    }
}
