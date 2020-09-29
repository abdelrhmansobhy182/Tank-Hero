using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float angle=0.5f;
    float totalangle=0;
   public Movement move;
    public Transform gun;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.L))
        {
            
            transform.Rotate(0, 0, -angle);
          // Movement.lastRotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);

        }
        if (Input.GetKey(KeyCode.K))
        {
                transform.Rotate(0, 0, angle);
          // Movement.lastRotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        }
        

    }
    
}
