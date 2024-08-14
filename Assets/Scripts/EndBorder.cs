using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBorder : MonoBehaviour
{
    public HealthBar healthBar;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Boss")
        {
            healthBar.Damage();
            Destroy(collision.gameObject);
        }
    }
}
