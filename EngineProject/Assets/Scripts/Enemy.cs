using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    Vector3 dir = new Vector3(-1,0,0);
    private void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }
}
