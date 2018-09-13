using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sink : MonoBehaviour {

	AudioSource[] sounds;
    AudioSource drip;
    AudioSource wash;
	AudioSource dry;

	bool passed = false;

    // Use this for initialization
    void Start()
    {
        sounds = GetComponents<AudioSource>();
        drip = sounds[0];
        wash = sounds[1];
		dry = sounds[2];
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Begin()
    {
        drip.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			if(!passed) {
				passed = true;
            	drip.Pause();
				Invoke("Washing", 0.25f);
			}
            
            //gameObject.SetActive(false);
        }
    }

	private void Washing() {
		wash.Play();
		Invoke("Drying", 11f);
	}

	private void Drying() {
		dry.Play();
	}
}
