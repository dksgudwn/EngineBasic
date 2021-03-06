using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text currentTimeScoreUI;
    private int currentScore;
    public Text bestScoreUI;
    private int bestScore;
    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        bestScoreUI.text = "최고 점수 : " + bestScore;
    }
    public void SetScore(int value) {
    currentScore += 100;
        currentTimeScoreUI.text = "현재점수 : " + currentScore;
        PlayerPrefs.SetInt("Current Score", currentScore);
        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreUI.text = "최고 점수 : " + bestScore;
            PlayerPrefs.SetInt("Best Score", bestScore);
        }}
    public int GetScore() { return currentScore; }
}
