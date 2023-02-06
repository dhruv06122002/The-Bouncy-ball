using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timevalue = 90;
    [SerializeField] 
    public TextMeshProUGUI timerText;
    public GameObject balls;
    public GameObject losepanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timevalue > 0)
        {
            timevalue -= Time.deltaTime;
        }
        else
        {
            //timevalue += 90;
            balls.SetActive(false);
            losepanel.SetActive(true);
        }

        DisplayTime(timevalue);
        
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        else if(timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    
}
