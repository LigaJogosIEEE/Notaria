/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0, vertical) * 5 * Time.deltaTime);
	}
}*/

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float oldZ = 0;
    float oldX = 0;

    AudioSource a;

    void Start()
    {
        //cc = GetComponent<CharacterController>();
        a = GetComponent<AudioSource>();
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 10.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if ((x != oldX || z != oldZ) && a.isPlaying == false)
        {
            a.volume = Random.Range(0.8f, 1f);
            a.pitch = Random.Range(0.8f, 1.1f);
            a.Play();
        }

        oldZ = z;
        oldX = x;

    }
}