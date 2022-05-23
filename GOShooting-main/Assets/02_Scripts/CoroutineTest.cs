using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour // ��� ����
{
    public GameObject playerbullet;

    void Start()
    {
        StartCoroutine("Fire"); //"Fire" ��� Fire()�� ��� ����
        //�޼��� ���� Fire(playerbullet) << �̷������� �ؾߴ� 
        //StartCoroutine("Fire2");

        //StopCoroutine("Fire");
    }

    IEnumerator Fire()
    {
        while (true)
        {
            Instantiate(playerbullet, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }

    /*IEnumerator Fire2()
    {
        print("��");
        yield return new WaitForSeconds(2f);
        print("��");
    }*/
}

/* Fire�� Fire1�� �ִٸ� Fire�� ����ǰ� Fire1�� ���� �Ǿ�� ������ �ڷ�ƾ�� ȣ���� ������ ����ȭ�Ѵ�.
 * �����ϸ� �ڷ�ƾ�� ������ ������ �ٸ� �޼��嵵 �� �� �ֵ��� �Ѱ��ش� �׷��� ���� ������ �ص� �� ������*/