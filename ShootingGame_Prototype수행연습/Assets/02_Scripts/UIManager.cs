using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text currentScoreTXT;
    public Text bestScoreTXT;
    int currentScore;
    int bestScore;
    private void Start()
    {
        currentScore = PlayerPrefs.GetInt("current Score",0);
        currentScoreTXT.text =  "현재점수 : " + currentScore;
        bestScore =  PlayerPrefs.GetInt("best Score",0);
        bestScoreTXT.text = "최고점수 : " + currentScore;
    }
    public void btn()
    {
        SceneManager.LoadScene("play");
    }
}
