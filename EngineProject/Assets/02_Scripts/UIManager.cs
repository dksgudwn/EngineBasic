using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int score;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        score = 0;
    }
    private void Update()
    {
        scoreText.text = "Score : " + score;
    }
}

