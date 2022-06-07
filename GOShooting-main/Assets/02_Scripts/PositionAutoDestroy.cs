using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAutoDestroy : MonoBehaviour
{
    [SerializeField] StageData stageData;
    float destroyWeight = 2f;
    Pooling bulletPooling;
    Pooling enemyPooler;
    private void Awake()
    {
        enemyPooler = GameObject.FindGameObjectWithTag("EnemySpawner").GetComponent<Pooling>();
        bulletPooling = GameObject.Find("Player").GetComponent<Pooling>();
    }
    private void LateUpdate()
    {
        if(transform.position.x > stageData.LimitMax.x + destroyWeight
            || transform.position.x < stageData.LimitMin.x - destroyWeight
            || transform.position.y > stageData.LimitMax.y + destroyWeight
            || transform.position.y < stageData.LimitMin.y - destroyWeight )
        {
            if(gameObject.tag == "PlayerBullet")
            {
                bulletPooling.ReturnObject(gameObject);
            }
            else if(gameObject.tag =="Enemy")
            {
                enemyPooler.ReturnObject(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
