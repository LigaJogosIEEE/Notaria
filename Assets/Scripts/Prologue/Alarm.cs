using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour {

	AudioSource a;
    public Knock knock;
    bool finished = false;

	// Use this for initialization
	void Start () {
		a = GetComponent<AudioSource>();
		a.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKey && finished == false)
        {
            finished = true;
            a.Pause();
            gameObject.SetActive(false);
            Invoke("Continue", 5f);
        }
	}

    public void Continue()
    {
        knock.Begin();
    }
}
