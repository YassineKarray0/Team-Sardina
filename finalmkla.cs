using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalmkla : MonoBehaviour
{
    public BoxCollider2D eater;
    public SpriteRenderer sr;
    public Text ScoreText;
    public int score = 0;
    
    private void OnTriggerEnter2D(Collider2D col) {
    score++;
    ScoreText.text = score.ToString();
    Debug.Log(score);
    Destroy(eater);
   }
}
