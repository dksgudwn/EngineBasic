using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PoolableMono", menuName = "Pool/PoolableMono")]
public class PoolabeMono : ScriptableObject
{
    public Pooled prefab;
    public string _name;
    public void OnSpawn()
    {

    }
    public void OnDisable()
    {
        
    }
}