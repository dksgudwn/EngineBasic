using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pooler", menuName = "pooler")]
public class Pooler : ScriptableObject
{
    public List<PoolabeMono> poolabeMonos;
}
