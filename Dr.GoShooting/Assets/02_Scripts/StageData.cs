using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StageData : ScriptableObject
{
    [SerializeField]
    Vector2 limitmin;
    [SerializeField]
    Vector2 limitmax;

    public Vector2 LimitMin => limitmin;
    public Vector2 LimitMax => limitmax;
}
