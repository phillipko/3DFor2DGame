using UnityEngine;
using System.Collections;

public class PlayerFlip : MonoBehaviour {

    Vector3 playerScale;
    float X;
    Transform player;


	// Use this for initialization
	void Start ()
    {
        player = GetComponent<Transform>();
        X = player.localScale.x;
        playerScale = new Vector3(X, player.localScale.y, player.localScale.z);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKey("left"))
        {
            playerScale.x = -X;
            player.localScale = playerScale;
        }
        else if (Input.GetKey("right"))
        {
            playerScale.x = X;
            player.localScale = playerScale;
        }
	}
}
