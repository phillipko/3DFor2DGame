using UnityEngine;
using System.Collections;

public class PlayerAnimate : MonoBehaviour {

    AnimatedTexture animate;


	// Use this for initialization
	void Start ()
    {
        animate = GetComponent<AnimatedTexture>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("left"))
        {
            animate.rowNumber = 1;
        }
        else if (Input.GetKey("right"))
        {
            animate.rowNumber = 1;
        }
        else if (Input.GetKey("space"))
        {
            animate.rowNumber = 2;
        }
        else
        {
            animate.rowNumber = 0;
        }
    }
}
