using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject explosionFactory;
    public float speed = 5;
    Vector3 dir;
    private void Start()
    {
        int randValue = Random.Range(0, 10);//0~9
        if (randValue < 6)//30프로 확률로 플레이어 방향으로 가시오
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;//Player 위치빼기 에너미 위치 하면 플레이어 방향으로 간다
            dir.Normalize();
        }
        else//아래로 가시오.
        {
            dir = Vector3.down;
        }
    }
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject smObject = GameObject.Find("ScoreManager");
        ScoreManager sm = smObject.GetComponent<ScoreManager>();
        sm.SetScore(sm.GetScore() + 1);

        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;
        
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(1);
        } 

        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
