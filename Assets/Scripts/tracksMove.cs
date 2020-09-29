using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracksMove : MonoBehaviour
{
    // Start is called before the first frame update
   public  Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
        {
            animator.SetBool("move", true);
        }
        else
            animator.SetBool("move", false);
    }
}
