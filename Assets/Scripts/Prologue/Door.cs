using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    AudioSource[] sounds;
    AudioSource knock;
    AudioSource opening;
	AudioSource handle;

	public Sink sink;
	bool passed = false;

    // Use this for initialization
    void Start()
    {
        sounds = GetComponents<AudioSource>();
        knock = sounds[0];
        opening = sounds[1];
		handle = sounds[2];
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
			if(!passed) {
				passed = true;
            	knock.Pause();
				Invoke("OpenDoor", 0.5f);
			} else
			{
				OpenDoor();
			}
            
            //gameObject.SetActive(false);
        }
    }

	private void OpenDoor() {
		handle.Play();
		opening.Play();
		sink.Begin();
	}
}
