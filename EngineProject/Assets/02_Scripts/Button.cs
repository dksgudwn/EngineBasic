using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] string a;
    [SerializeField] string b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Button1()
    {
        Debug.Log("버튼눌림");
        SceneManager.LoadScene(a);//여기요
    }
    public void Button2()
    {
        Debug.Log("버튼눌림");
        SceneManager.LoadScene(b);//여기요
    }
    
}
