using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 3f;
    public FixedJoystick joystick;
    private float hInput;
    public HealthBar healthBar;
    public AudioSource audioSource;
    public AudioClip playerExplosion;


    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        hInput = joystick.Horizontal;
        rb.velocity = new Vector2 (hInput * moveSpeed, 0);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boss")
        {
            audioSource.clip = playerExplosion;
            audioSource.Play();
            healthBar.Damage();
            Destroy(collision.gameObject);
        }
    }
}
