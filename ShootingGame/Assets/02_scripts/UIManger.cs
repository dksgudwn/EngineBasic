using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManger : MonoBehaviour
{
    public Text currentScoreTxt;
    public Text bestScoreTxt;
    int currentScore;
    int bestScore;

    private void Start()
    {
        currentScore = PlayerPrefs.GetInt("Current Score", 0);
        currentScoreTxt.text = "현재점수 : " + currentScore;
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        bestScoreTxt.text = "최고점수 : " + bestScore;
    }
    public void BtnRestart(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
