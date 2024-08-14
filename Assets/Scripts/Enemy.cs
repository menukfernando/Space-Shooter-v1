using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public GameObject enemy;
    private Score scoreScript;
    private AudioSource audioSource;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreScript = GameObject.Find("Score").GetComponent<Score>();
        audioSource = GameObject.Find("EnemyExplosion").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, -5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Missile")
        {
            audioSource.Play();
            Destroy(gameObject);
            Destroy(collision.gameObject);

            scoreScript.ScoreIncrement();
   
        }
    }
}
