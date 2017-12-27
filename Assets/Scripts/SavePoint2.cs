using UnityEngine;
using System.Collections;

public class SavePoint2 : MonoBehaviour
{
    public AudioClip soundFx;
    AudioSource soundController;

    public static bool saved2 = false;

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
            saved2 = true;
            soundController.PlayOneShot(soundFx, 1);
        }
    }
    
}
