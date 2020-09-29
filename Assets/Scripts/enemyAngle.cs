using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAngle : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
   public Transform player;

    void Start()
    {
       rb = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 direction = player.position - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        //Debug.Log("angle " + angle);
    }
    
    
}
