using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowscript : MonoBehaviour
{
    public float speed = 11;
    GameManager gameManager;
    Transform tr;
    void Start()
    {
        tr = GetComponent<Transform>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.position += Vector3.down * speed * Time.deltaTime;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameManager.DecreaseHp();
        }
        Destroy(gameObject);
    }
}
