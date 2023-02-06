using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;
    public int noofballs = 5;
    public GameObject balls;
    public GameObject winpanel;


    public void Scoreup()
    {
        score++;
        if (score >= noofballs)
        {
            balls.SetActive(false);
            winpanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
