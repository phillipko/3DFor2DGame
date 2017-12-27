using UnityEngine;
using System.Collections;

public class PlayOneShot : MonoBehaviour
{
    public AudioClip soundFx;
    AudioSource soundController;


	// Use this for initialization
	void Start ()
    {
        soundController = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}


    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.name == "Player")
        {
            soundController.PlayOneShot(soundFx, 1);
        }
    }
}
