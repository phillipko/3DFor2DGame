using UnityEngine;
using System.Collections;

public class SavePoint : MonoBehaviour
{
    public AudioClip soundFx;
    AudioSource soundController;

    public static bool saved = false;

    // Use this for initialization
    void Start()
    {
        soundController = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.name == "Player")
        {
            saved = true;
            soundController.PlayOneShot(soundFx, 1);
        }
    }
    
}
