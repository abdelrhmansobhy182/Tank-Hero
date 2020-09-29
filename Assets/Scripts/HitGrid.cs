using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGrid : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("bullet")|| collision.gameObject.tag.Equals("bullet1"))
        {

            Destroy(collision.gameObject);
        }


    }
}
