using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    private float health = 100;
    public Image healthBar;
    public GameObject GameOver;
    public AudioSource audioSource;
    public AudioClip gameOver;
    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            audioSource.clip = gameOver;
            audioSource.Play();
            Time.timeScale = 0;
            GameOver.SetActive(true);
        }
    }

    public void Damage()
    {
        health -= 20;
        healthBar.fillAmount = health / 100;
    }
}
