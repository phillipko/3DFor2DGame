using UnityEngine;
using System.Collections;

public class PlatformMovement : MonoBehaviour
{

    public float speed;
    public float amplitude = 3.00f;
    public Vector3 direction;
    
    Vector3 positionZero;

	// Use this for initialization
	IEnumerator Start ()
    {
        positionZero = transform.position;
        while(true)
        {
            transform.position = positionZero + amplitude * direction * Mathf.Sin(speed * Time.time);
            yield return null;
        }
	}
	
    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.name == "Player")
        {
            target.transform.parent = transform;
        }

    }

    void OnTriggerExit(Collider target)
    {
        if (target.gameObject.name == "Player")
        {
            target.transform.parent = null;
        }
    }
}
