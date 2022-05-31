using System.Collections;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] float maxHP = 10;
    float currentHP;
    SpriteRenderer spriteRenderer;
    PlayerController playerController;

    public float MaxHP {
        get
        {
             return maxHP;
        }
    }
    public float CurrentHp{
        get{
            return currentHP;
        }
    }

    void Start()
    {
        currentHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
    }


    public void TakeDamage(float damage)
    {
        currentHP -= damage;

        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");
        
        if(currentHP <= 0)
        {
            playerController.Die();
        }
    }

    IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        spriteRenderer.color = Color.white;
    }
}
