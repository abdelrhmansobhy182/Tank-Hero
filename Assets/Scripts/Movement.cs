using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float x, y;
    public int speed = 5;
    public float angle=0.5f;
    public Rigidbody2D rb;
    public Rigidbody2D gun;
    public bool right = false, left = false, up = false, down = false;
    public Sounds sounds;
    bool SoundPlay = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.D))
        {
            if (!sounds.audio.isPlaying)
            {
                sounds.play_sounds("move");

            }


            if (right == false)
            {

                transform.eulerAngles = new Vector3(0, 0, -90);

            }

            rb.MovePosition(rb.position + new Vector2(speed, 0) * Time.deltaTime);
            gun.MovePosition(rb.position + new Vector2(speed, 0) * Time.deltaTime);

            right = true;
            left = false;
            up = false;
            down = false;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (!sounds.audio.isPlaying)
            {
                sounds.play_sounds("move");

            }
            if (left == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 90);

            }

            rb.MovePosition(rb.position + new Vector2(-speed, 0) * Time.deltaTime);
            gun.MovePosition(rb.position + new Vector2(-speed, 0) * Time.deltaTime);

            right = false;
            left = true;
            up = false;
            down = false;

        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (!sounds.audio.isPlaying)
            {
                sounds.play_sounds("move");

            }
            if (up == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);

            }

            rb.MovePosition(rb.position + new Vector2(0, speed) * Time.deltaTime);
            gun.MovePosition(rb.position + new Vector2(0, speed) * Time.deltaTime);

            right = false;
            left = false;
            up = true;
            down = false;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (!sounds.audio.isPlaying)
            {
                sounds.play_sounds("move");

            }
            if (down == false)
            {
                transform.eulerAngles = new Vector3(0, 0, 180);

            }

            rb.MovePosition(rb.position + new Vector2(0, -speed) * Time.deltaTime);
            gun.MovePosition(rb.position + new Vector2(0, -speed) * Time.deltaTime);

            right = false;
            left = false;
            up = false;
            down = true;

        }
        else sounds.audio.Stop();
         

    }
}
