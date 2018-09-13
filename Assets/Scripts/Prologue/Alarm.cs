using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour {

    AudioSource[] sounds;
	AudioSource alarm;
    AudioSource click;

    public Door door;
    bool finished = false;

	// Use this for initialization
	void Start () {
		sounds = GetComponents<AudioSource>();
        alarm = sounds[0];
        click = sounds[1];
		alarm.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKey && finished == false)
        {
            finished = true;
            alarm.Pause();
            click.Play();
            //gameObject.SetActive(false);
            Invoke("Continue", 5f);
        }
	}

    public void Continue()
    {
        door.Begin();
    }
}
