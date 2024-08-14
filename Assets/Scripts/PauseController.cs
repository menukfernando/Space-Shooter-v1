using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public GameObject PauseCon;
    public AudioSource audioSource;
    public AudioClip click;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pause()
    {
        audioSource.clip = click;
        audioSource.Play();
        PauseCon.SetActive(true);
        Time.timeScale = 0;
        

    }

    public void resume()
    {
        audioSource.clip = click;
        audioSource.Play();
        Time.timeScale = 1;
        PauseCon.SetActive(false);
    }

    public void exit()
    {
        audioSource.clip = click;
        audioSource.Play();
        SceneManager.LoadScene("Home");
        Time.timeScale = 1;
    }
}
