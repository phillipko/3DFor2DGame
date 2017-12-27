using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class Enter2Pressed : MonoBehaviour {

    public string Scene; 
    // Use this for initialization
    void Start ()
    {

	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetButtonUp("Submit"))
        {
            Death.lifePoints = 2;
            SavePoint2.saved2 = false;
            EnterPressed.newLocation2 = false;
            
            SavePoint.saved = false;
            EnterPressed.newLocation = false;
            
            Death.death = false;
            Application.LoadLevel(Scene);
            //SceneManager.LoadScene(Scene); 
            
        }

	}
}
