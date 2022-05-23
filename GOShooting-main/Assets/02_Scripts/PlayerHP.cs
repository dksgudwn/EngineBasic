using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] float maxHP = 10;
    float currentHP;
    SpriteRenderer spriteRenderer;


    void Start()
    {
        currentHP = maxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    public void TakeDamge(float damage)
    {
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");
    }

    IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(0.1f);

        spriteRenderer.color = Color.white;
    }
}
