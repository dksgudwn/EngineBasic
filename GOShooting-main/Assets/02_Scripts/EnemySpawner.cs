using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] StageData stageData;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnTime = 0.7f;
    Pooling enemyPooler;
    void Start()
    {
        enemyPooler = GetComponent<Pooling>();
        StartCoroutine("SpawnEnemy");
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            float positionX = Random.Range(stageData.LimitMin.x, stageData.LimitMax.x);
            Vector3 pos = new Vector3(positionX, stageData.LimitMax.y + 1f, 0);
            Instantiate(enemyPrefab, pos, Quaternion.identity);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
