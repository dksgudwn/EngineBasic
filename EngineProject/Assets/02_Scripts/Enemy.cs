using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] stageData stageData;
    [SerializeField] float speed = 5f;
    Vector3 dir = new Vector3(-1,0,0);
    [SerializeField] int maxHp = 4;
    private int currentHp;
    private SpriteRenderer spriteRenderer;
    townHP _townHP;
     int a;
    void Start()
    {
        currentHp = maxHp;
        spriteRenderer = GetComponent<SpriteRenderer>();
        _townHP = GetComponent<townHP>();
    }
  
    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");
        if(currentHp<=0)
        {
            Die();
        }
    }
    private IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.05f);
        spriteRenderer.color = Color.white;
    }
    private void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
        Invoke("AutoDestroy", 5f);
        if(transform.position.x <= stageData.LimitMin.x)
        {
            GameObject.Find("EventSystem").GetComponent<townHP>().ddd--;
            Debug.Log(GameObject.Find("EventSystem").GetComponent<townHP>().ddd);
            Destroy(gameObject);
            //gameObject.SetActive(false);
        }
        if(GameObject.Find("EventSystem").GetComponent<townHP>().ddd<=0)
        {
            SceneManager.LoadScene("GameOver");   
        }
    }
    
    private void AutoDestroy()
    {
        Destroy(gameObject);
    }
    private void Die()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}
