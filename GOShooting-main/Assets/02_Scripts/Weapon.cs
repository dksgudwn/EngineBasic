using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    GameObject projectilePrefabs;
    [SerializeField]
    float attackRate = 0.1f;
    Pooling bulletPooling;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    private void Start()
    {
        bulletPooling = GetComponent<Pooling>();
    }
    public void StartFiring()
    {
        StartCoroutine("TryAttack");
    }

    public void StopFiring()
    {
        StopCoroutine("TryAttack");
    }

    IEnumerator TryAttack()
    {
        while (true)
        {
            //Instantiate(projectilePrefabs, transform.position, Quaternion.identity);
            bulletPooling.SpawnObject(transform.position, Quaternion.identity);
            yield return new WaitForSeconds(attackRate);
        }
    }
}
