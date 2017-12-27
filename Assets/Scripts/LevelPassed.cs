using UnityEngine;
using System.Collections;

public class LevelPassed : MonoBehaviour
{
    public AudioClip soundFx;
    AudioSource soundController;
    public string Scene;

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
            soundController.PlayOneShot(soundFx, 1);
            StartCoroutine(levelPassed(Scene));
        }
    }

    IEnumerator levelPassed(string Scene)
    {
        yield return new WaitForSeconds(1f);
        Application.LoadLevel(Scene);
    }
}
