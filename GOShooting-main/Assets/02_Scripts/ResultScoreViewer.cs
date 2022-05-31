using UnityEngine;
using TMPro;

public class ResultScoreViewer : MonoBehaviour
{
    TextMeshProUGUI textScore;

    private void Start()
    {
        textScore = GetComponent<TextMeshProUGUI>();
        int score = PlayerPrefs.GetInt("Score");
        textScore.text = "Result Score: " +score;
    }
}
