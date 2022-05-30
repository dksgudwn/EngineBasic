using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement2D movement2D;
    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(x,y,0);
        transform.position = dir * Time.deltaTime * speed;
    }
}
