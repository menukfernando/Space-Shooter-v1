using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreVal;
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreVal.text = "Score: " + PlayerPrefs.GetInt("Score").ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene("Game");
        if(PlayerPrefs.GetInt("HighScore", 0) < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Highscore", PlayerPrefs.GetInt("Score"));
        }
    }

    public void exit()
    {
        SceneManager.LoadScene("Home");
        if (PlayerPrefs.GetInt("HighScore", 0) < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Highscore", PlayerPrefs.GetInt("Score"));
        } 
    }
}
