using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class EnterPressed : MonoBehaviour {

    public string Scene;
    public static bool newLocation = false;
    public static bool newLocation2 = false;
    // Use this for initialization
    void Start ()
    {

	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetButtonUp("Submit"))
        {
            Death.death = false;
            Application.LoadLevel(Scene);
            //SceneManager.LoadScene(Scene); 
            if (SavePoint2.saved2)
            {
                newLocation2 = true;
            }        
            else if (SavePoint.saved)
            {
                newLocation = true;
            }
        }

	}
}
