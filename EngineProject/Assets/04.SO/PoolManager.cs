using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public Pooler pooler;
    public Queue<Pooled> q = new Queue<Pooled>();
    private void Start()
    {
        CreatePool("water",20);
    }
    public Pooled Pop()
    {
        Pooled pooled =q.Dequeue();
        pooled.gameObject.SetActive(true);
        return pooled;
    }

    public void Push(Pooled pool)
    {
        q.Enqueue(pool);
        pool.gameObject.SetActive(false);
    }

    public void CreatePool(string poolName, int count)
    {
        for(int i=0;i<count;i++)
        {
            Pooled mono = pooler.poolabeMonos.Find(name=>name._name==poolName).prefab;
            Push(mono);            
        }

    }

}
