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
        //���콺 ���� Ŭ���� �Ѿ� �߻�
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet= Instantiate(bulletFactory);       //�� ���� ������Ʈ�� �̸� �� ���ƾ���
            bullet.transform.position = firePosition.transform.position;
     
        }
    }
}