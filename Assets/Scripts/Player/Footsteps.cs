using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {

    // Use this for initialization 
    //CharacterController cc;
    AudioSource a;

    void Start () {
        //cc = GetComponent<CharacterController>();
        a = GetComponent<AudioSource>();
    }

    // Update is called once per frame 
    void Update () {
        if (a.isPlaying == false) {
            a.volume = Random.Range(0.8f, 1f);
            a.pitch = Random.Range(0.8f, 1.1f);
            a.Play();
        }
    }
}
