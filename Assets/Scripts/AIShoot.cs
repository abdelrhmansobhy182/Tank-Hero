using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShoot : MonoBehaviour
{
    //public Transform player;
    public Transform FirePoint;
    public GameObject Bulletprefab;
    public float bulletForce = 20f;
    public float timeRemaining = 1;
    public AudioClip shooot;
    public AudioSource audio;


    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            audio.PlayOneShot(shooot);
            timeRemaining = 1f;
            shoot();
        }
        


    }
    void shoot()
    {
        GameObject bullet = Instantiate(Bulletprefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}
