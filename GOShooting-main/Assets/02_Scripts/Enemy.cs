using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float damage = 1;
    [SerializeField] int scorePoint = 100;
    PlayerController playerController;
    [SerializeField] GameObject exPrefab;
    private void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();
        // playerController = GameObject.Find("Player").GetComponent<PlayerController>(); 게임오브젝트 이름으로 찾기
        // playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>(); 테그로 찾기 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            Die();
        }
    }
    public void Die()
    {
        playerController.Score += scorePoint;
        Debug.Log(playerController.Score);
        GameObject clone = Instantiate(exPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(clone,1f);
        
        
    }
}
