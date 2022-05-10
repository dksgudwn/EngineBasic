using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject firePosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //마우스 왼쪽 클릭시 총알 발사
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet= Instantiate(bulletFactory);       //위 게임 오브젝트랑 이름 이 같아야함
            bullet.transform.position = firePosition.transform.position;
     
        }
    }
}
