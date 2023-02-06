using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public GameObject soundplay;
    public GameObject soundpause;
    public GameObject objectmusic;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        objectmusic = GameObject.FindWithTag("music");
        audioSource = objectmusic.GetComponent<AudioSource>();

        if (audioSource.isPlaying)
        {
            Debug.Log("Audio OK");
            soundplay.SetActive(true);
            soundpause.SetActive(false);
        }
        else
        {
            Debug.Log("Audio NOT OK");
            soundplay.SetActive(false);
            soundpause.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

public void SOUND_PLAY()
{
    Time.timeScale = 1f;
    soundplay.SetActive(false);
    soundpause.SetActive(true);
    audioSource.Pause();
}

public void SOUND_PAUSE()
{
    Time.timeScale = 1f;
    soundplay.SetActive(true);
    soundpause.SetActive(false);
    audioSource.Play();
}


}
