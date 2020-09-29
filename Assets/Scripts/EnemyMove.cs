using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public bool right,left,up,down;
    public bool Move, rotate;
    public int counter=0;
    public int direct = 1;
    public Rigidbody2D rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (rotate)
        {
           
            
            counter++;
            transform.Rotate(0,0,2);
            if(counter==45)
            {
                direct++;
                if (direct == 5)
                    direct = 1;
                rotate = false;
                counter = 0;
                
                SetDirections();
                

            }
           
            
            
           
           
        }
        else
        {
            if (up)
            {


                rb.MovePosition(rb.position + new Vector2(0, 10) * Time.deltaTime);
             
            }
            if (down)
            {
                
                rb.MovePosition(rb.position + new Vector2(0, -10) * Time.deltaTime);
            }
            if (right)
            {
                rb.MovePosition(rb.position + new Vector2(10, 0) * Time.deltaTime);
            }
            if (left)
            {
                rb.MovePosition(rb.position + new Vector2(-10, 0) * Time.deltaTime);
            }
        }
           
        
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
            if (collision.gameObject.tag.Equals("map"))
            {
            
            }

        


    }
    private void SetDirections()
    {
        if(direct==1)
        {
            left = true;
            right = false;
            up = false;
            down = false;
        }
        if (direct == 2)
        {
            left = false;
            right = false;
            up = false;
            down = true;
        }
        if (direct == 3)
        {
            left = false;
            right = true;
            up = false;
            down = false;
        }
        if (direct == 4)
        {
            left = false;
            right = false;
            up = true;
            down = false;
        }
    }
    private void CheckPosition()
    {
        if (left)
        {
            rb.MovePosition(rb.position + new Vector2(40, 40) * Time.deltaTime);
        }
        if (right)
        {
            rb.MovePosition(rb.position + new Vector2(-40, 40) * Time.deltaTime);
        }
        if (up)
        {
            rb.MovePosition(rb.position + new Vector2(-40, -40) * Time.deltaTime);
        }
        if (down)
        {
            rb.MovePosition(rb.position + new Vector2(40, 40) * Time.deltaTime);
        }
    }
}
