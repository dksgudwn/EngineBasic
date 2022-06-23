using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    Vector3 dir = new Vector3(-1,0,0);
    private void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
        Invoke("AutoDestroy", 5f);
    }
    
    private void AutoDestroy()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        Debug.Log("적 죽었음");
    }
}
