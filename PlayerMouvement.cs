using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMouvement : MonoBehaviour
{
    public GameObject panel;
    public Text ScoreText;
    public int score = 0;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator anim;
    public BoxCollider2D thbx;
    public SpriteRenderer thsr;
    public BoxCollider2D maybx;
    public SpriteRenderer maysr;
    public BoxCollider2D babx;
    public SpriteRenderer basr;
    public BoxCollider2D kebx;
    public SpriteRenderer kesr;
    public BoxCollider2D lebx;
    public SpriteRenderer lesr;
    public BoxCollider2D fribx;
    public SpriteRenderer frisr;
    public BoxCollider2D tombx;
    public SpriteRenderer tomsr;
    public BoxCollider2D hbx;
    public SpriteRenderer hsr;
    public BoxCollider2D wbx;
    public SpriteRenderer wsr;
    public BoxCollider2D gdbx;
    public SpriteRenderer gdsr;





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.velocity = Vector2.right * 5;
            sr.flipX = false;
            anim.SetBool("isRunning",true);
        }
        if (Input.GetKey("q"))
        {
            rb.velocity = Vector2.left * 5;
            sr.flipX = true;
            anim.SetBool("isRunning",true);

        }
        if (Input.GetKeyUp("d") || Input.GetKeyUp("q") || Input.GetKeyUp("s")  || Input.GetKeyUp("z"))
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("isRunning",false);
        }
        if (Input.GetKey("z"))
        {
            rb.velocity = Vector2.up * 5;
            anim.SetBool("isRunning",true);
        }
        if(Input.GetKey("s"))
        {
            rb.velocity = Vector2.down * 5;
            anim.SetBool("isRunning",true);
        }
        if (score == 9)
        {
            panel.SetActive(true);
            
        }
    }

    public AudioSource pickSoundEffect;
    
    
    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "thon")
        {
            score+=1;
            ScoreText.text = score.ToString();
            Destroy(thbx);
            Destroy(thsr);
            pickSoundEffect.Play();

        }
        if (col.gameObject.name == "mayo")
        {
            score+=1;
            ScoreText.text = score.ToString();
            Destroy(maybx);
            Destroy(maysr);
            pickSoundEffect.Play();
        }
        if (col.gameObject.name == "baguette")
        {
            score+=1;
            ScoreText.text = score.ToString();
            Destroy(babx);
            Destroy(basr);
            pickSoundEffect.Play();
        }
        if (col.gameObject.name == "ketchup")
        {
            score+=1;
            ScoreText.text = score.ToString();
            Destroy(kebx);
            Destroy(kesr);
            pickSoundEffect.Play();
        }
        if (col.gameObject.name == "lettuce")
        {
            score+=1;
            ScoreText.text = score.ToString();
            Destroy(lebx);
            Destroy(lesr);
            pickSoundEffect.Play();
        }
        if (col.gameObject.name == "frit")
        {
            score+=1;
            ScoreText.text = score.ToString();
            Destroy(fribx);
            Destroy(frisr);
            pickSoundEffect.Play();
        }
        if (col.gameObject.name == "tomato")
        {
            score+=1;
            ScoreText.text = score.ToString();
            Destroy(tombx);
            Destroy(tomsr);
            pickSoundEffect.Play();
        }
        if (col.gameObject.name == "hrisa")
        {
            score+=1;
            ScoreText.text = score.ToString();
            Destroy(hbx);
            Destroy(hsr);
            pickSoundEffect.Play();
        }
        if (col.gameObject.name == "water")
        {
            score+=1;
            ScoreText.text = score.ToString();
            Destroy(wbx);
            Destroy(wsr);
            pickSoundEffect.Play();
        }
        if (col.gameObject.name == "gdigla")
        {
            score+=1;
            ScoreText.text = score.ToString();
            Destroy(gdbx);
            Destroy(gdsr);
            pickSoundEffect.Play();
        }
        


    
   }
   
    
    
}