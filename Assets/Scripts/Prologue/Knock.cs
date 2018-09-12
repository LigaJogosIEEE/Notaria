using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knock : MonoBehaviour {

    AudioSource[] sounds;
    AudioSource knock;
    AudioSource opening;

    // Use this for initialization
    void Start()
    {
        sounds = GetComponents<AudioSource>();
        knock = sounds[0];
        opening = sounds[1];
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Begin()
    {
        knock.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            knock.Pause();
            opening.Play();
            //gameObject.SetActive(false);
        }
    }
}
