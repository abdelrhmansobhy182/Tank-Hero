using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HitPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    int counter = 0;
   public Animator animator;
    public GameObject gun;
    public Movement move;
    public rotation rotation;
    public float timeRemaining = 0.5f;
    bool Die = false;
    public AudioClip exp;
    public AudioSource audio;
    private void Update()
    {
        if (Die)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                SceneManager.LoadScene("EndGame");
                Destroy(gameObject);
                Destroy(gun);
                
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("bullet1"))
        {
            
            Destroy(collision.gameObject);
            counter++;
            if (counter == 3)
            {
                audio.PlayOneShot(exp);
                Die = true;
                animator.SetBool("Die", true);
                counter++;
                move.enabled = false;
                rotation.enabled = false;
            }
            
           
        }
        if (collision.gameObject.tag.Equals("enemy"))
        {
            Die = true;
            animator.SetBool("Die", true);
           
        }


        }
}
