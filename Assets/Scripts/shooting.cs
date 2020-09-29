﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject Bulletprefab;
    public float bulletForce = 20f;
    public bool fire = false;
    public AudioClip shooot;
    public AudioSource audio;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            
            audio.PlayOneShot(shooot);
            shoot();
        }
        
        



    }
    void shoot()
    {
        GameObject bullet = Instantiate(Bulletprefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up* bulletForce, ForceMode2D.Impulse);

    }
}
