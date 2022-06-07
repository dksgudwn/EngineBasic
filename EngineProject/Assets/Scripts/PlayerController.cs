using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private stageData stageData;
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject bulletPrefab;
    private Vector3 startValue;
    private Vector3 endValue;
    private void Awake()
    {
        startValue = transform.position;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(bulletPrefab,transform.position,transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("ddd");
        }
    }
    private void FixedUpdate()
    {
        //float x = Input.GetAxisRaw("Horizontal");
        //float y = Input.GetAxisRaw("Vertical");
        //Vector3 dir = new Vector3(x,y,0);
        //transform.position += dir * Time.deltaTime * speed;
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x),
        Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y));
    }
    IEnumerator Run(float duration)//duration 지속시간
    {
        var runTime = 0.0f;
        while (runTime < duration)
        {
            runTime += Time.deltaTime;
            transform.position = Vector3.Lerp(startValue, endValue, runTime / duration);
            yield return null;
        }
    }
}
