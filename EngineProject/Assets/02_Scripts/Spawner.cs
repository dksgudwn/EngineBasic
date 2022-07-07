using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Spawn;
    [SerializeField] private GameObject Spawn2;

    private int spawnRandomCount;

    private GameObject SpawnObject = null;
    [SerializeField] private float spawnTime;
    [SerializeField] float maxSpawnLength;

    private void Start()
    {
        StartCoroutine(create());
        //new WaitForSeconds(5);
    }
    IEnumerator create()
    {
        while(true){
            spawnRandomCount = Random.Range(1,3);
            if(spawnRandomCount == 1)
            {
                SpawnObject= Spawn;
            }
            else
            {
                SpawnObject= Spawn2;
            }
            yield return new WaitForSeconds(spawnTime);
            GameObject bullet = Instantiate(SpawnObject, transform.position,Quaternion.identity);
            Vector3 pos = bullet.transform.position;
            pos.y += Random.Range(-maxSpawnLength,maxSpawnLength);
            bullet.transform.position = pos;
        }
    }
}
