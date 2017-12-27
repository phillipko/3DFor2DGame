using UnityEngine;
using System.Collections;

public class CameraLocation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!Death.death)
        {
            Vector3 v = new Vector3(GameObject.FindGameObjectWithTag("Player1").transform.position.x, transform.position.y, transform.position.z);
            transform.position = v; 
        }

        
	
	}
}
