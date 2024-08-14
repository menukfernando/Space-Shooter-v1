using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Home : MonoBehaviour
{

	public TextMeshProUGUI highScore;
    public AudioSource audioSource;
    public AudioClip click;

    void Start()
	{
		highScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();	

	}

	public void Play(){
		SceneManager.LoadScene("Game");
        audioSource.clip = click;
        audioSource.Play();
    }

	public void Exit(){
		Application.Quit();
        audioSource.clip = click;
        audioSource.Play();
    }

}
