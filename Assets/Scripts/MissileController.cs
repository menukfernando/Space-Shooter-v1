using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MissileController : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject missile;
    public Transform missileSpawnPoint;
    public AudioSource missileSound;
    public AudioClip missileAudioClip;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        
    }

    public void Fire()
    {
        Instantiate(missile, missileSpawnPoint.position, Quaternion.identity);
        missileSound.clip = missileAudioClip;
        missileSound.Play();
    }

}
