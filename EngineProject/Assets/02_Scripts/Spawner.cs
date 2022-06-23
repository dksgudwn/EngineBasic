using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Spawn;
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
            yield return new WaitForSeconds(spawnTime);
            GameObject bullet = Instantiate(Spawn, transform.position,Quaternion.identity);
            Vector3 pos = bullet.transform.position;
            pos.y += Random.Range(-maxSpawnLength,maxSpawnLength);
            bullet.transform.position = pos;
        }
    }
}
