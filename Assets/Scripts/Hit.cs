using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Hit : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject hitEffect;
    int counter = 0;
    public static int enemy_number=2;
    public Animator animator;
    public FollowPath FollowPath;
    public MovementPath MovementPath;
    public AIShoot AIShoot;
    public enemyAngle enemyAngle;
    public bool blue;
    public float timeRemaining = 1;
    bool Die = false;
    public AudioClip Explosion;
    public AudioSource audio;
    private void Update()
    {
       
        if (blue)
            animator.SetBool("blue", true);
        if(Die)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                enemy_number--;
                if(enemy_number==0)
                {
                   // enemy_number = 2;
                    SceneManager.LoadScene("EndGame");
                }
                    
                
                Destroy(gameObject);
                
            }
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag.Equals("bullet"))
        {
           
            Destroy(collision.gameObject);
            counter++;
            if(counter==3)
            {
                audio.PlayOneShot(Explosion);
                Die = true;
                animator.SetBool("Die", true);
                MovementPath.enabled = false;
                FollowPath.enabled = false;
                enemyAngle.enabled = false;
                AIShoot.enabled = false;
                
                
            }
              
            
        }


    }
}
