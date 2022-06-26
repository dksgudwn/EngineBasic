using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopterMove : MonoBehaviour
{
    [SerializeField] stageData stageData;
    [SerializeField] float speed;
    [SerializeField] GameObject water;
    [SerializeField] GameObject fire;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 d = new Vector3(x,y,0);
        transform.position += d * speed * Time.deltaTime;
        if(Input.GetKey(KeyCode.Space))
        {
            StartCoroutine("Water");
        }
        else //(Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine("Water");
        }
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
        Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }
    IEnumerator Water()
    {
        Instantiate(water, transform.position, Quaternion.identity);
        yield return null;
    }
    private IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.05f);
        spriteRenderer.color = Color.white;
    }
}
