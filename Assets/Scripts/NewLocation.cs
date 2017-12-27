using UnityEngine;
using System.Collections;

public class NewLocation : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        if (EnterPressed.newLocation2)
        {
            Vector3 temp = new Vector3(127.00f, transform.position.y, transform.position.z);
            transform.position = temp;
        }
        else if (EnterPressed.newLocation)
        {
            Vector3 temp = new Vector3(82.00f, transform.position.y, transform.position.z);
            transform.position = temp;
        }
        else
        {
            Vector3 temp = new Vector3(0.00f, transform.position.y, transform.position.z);
            transform.position = temp;
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
