using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject bulletPrefab;
    private void Awake()
    {

    }
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 position = new Vector3(x,y,0);
        transform.position += position * speed * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab,transform.position,transform.rotation);
        }
    }
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(x,y,0);
        transform.position += dir * Time.deltaTime * speed;
    }
}
