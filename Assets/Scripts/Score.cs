using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI dispalyScore;
    private int score = 0;
    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
    }

    // Update is called once per frame
    public void ScoreIncrement()
    {
        score++;
        dispalyScore.text = "Score: " + score.ToString();
        PlayerPrefs.SetInt("Score", score);
    }
}
