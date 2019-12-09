using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectButtonCollision : MonoBehaviour
{
    private AudioSource audioSource;
    public string detect;
    public bool on;
    public bool currentScene;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        on = false;
        currentScene= false; // if current scene is true the scen is forest otherwise it is space or whatever
    }

    // Update is called once per frame
    void Update()
    {
        if (currentScene == false)
        {
            audioSource.Stop();
            on = false;
        }
    }
    public void UpdateScore(bool forest)
    {
        currentScene = forest;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (currentScene == true)
        {
            if (collision.gameObject.name == detect)
            {
                Debug.Log("Aw Shiet Sick flips");
                on = !on;
                Debug.Log("Audio should be playing, otherwise fuck");
            }
            if (on == true)
            {
                Debug.Log("on is true");

                audioSource.Play();
                Debug.Log("sound should be on");
            }
            if (on == false)
            {
                Debug.Log("on is false");
                audioSource.Stop();
                Debug.Log("sound should be off");
            }
        }

    }
}
