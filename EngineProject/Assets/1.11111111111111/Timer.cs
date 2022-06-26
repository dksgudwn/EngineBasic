using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public float MainTimer;
    TextMeshProUGUI TimerText;
    [SerializeField] float finishTime;
    void Start()
    {
        TimerText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        MainTimer+=Time.deltaTime;
        TimerText.text = MainTimer.ToString();
        if(MainTimer>=finishTime)
        {
            SceneManager.LoadScene("Clear");
        }
    }
}
