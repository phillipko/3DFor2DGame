using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    public string Scene;
    public static bool death = false;
    public static int lifePoints = 2;

    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.name == "Player")
        {
            death = true; 
            StartCoroutine(myDeath(target));
            lifePoints--;
        }
    }

    IEnumerator myDeath(Collider target)
    {
        Destroy(target.gameObject);
        yield return new WaitForSeconds(1f);
        Application.LoadLevel(Scene);
    }
}
