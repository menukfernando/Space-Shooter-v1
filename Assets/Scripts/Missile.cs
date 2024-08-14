using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class Missile : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private float speed = 10f;
    public GameObject missile;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (0, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EndBorder")
        {
            Destroy(this.missile);
        }

    }
}
