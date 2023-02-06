using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject losepanel;
    public GameObject balls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        Destroy(gameObject);
        balls.SetActive(false);
        losepanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
