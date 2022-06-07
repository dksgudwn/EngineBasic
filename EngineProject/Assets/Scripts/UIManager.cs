using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Text hpText;
    PlayerController playerController;
    int hp;
    public int Hp
    {
        get{return hp; }
        set
        { 
            hp =value;
            hpText.text = "체력 : "+ value.ToString();
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnHit()
    {
        Hp = 1314;
    }
}
