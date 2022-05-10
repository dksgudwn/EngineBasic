using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image hpGage;
    //public UnityEngine.Object Player = null;
    public GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //Player = GameObject.Find("Player");
    }
    private void Update()
    {
        if(hpGage.fillAmount <= 0.01f)
        {
            PlayerDie();
        }
    }

    public void DecreaseHp()
    {
        hpGage.fillAmount -= 0.2f;
       /* if (hpGage.fillAmount<=0.01f)
        {
             Destroy(Player);
        }*/
    }
    void PlayerDie()
    {       
            player.SetActive(false);
        }
        
    }

