using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed = 5f;
    private void Update()
    {
        Vector3 dir = new Vector3(0,1,0);
        transform.position += dir * speed * Time.deltaTime;
    }
}
