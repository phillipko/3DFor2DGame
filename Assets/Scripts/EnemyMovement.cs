using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    public float speed;
    public float amplitude = 3.00f;
    public Vector3 direction;
    Vector3 positionZero;
    bool first = false;
    float temp;
    float temp2;

    // Use this for initialization
    IEnumerator Start ()
    {
        positionZero = transform.position;
        while(true)
        {
            temp = Random.Range(1, 3);
            if (!first)
            {
                
                if (Mathf.RoundToInt(Time.time) % 5.00 < 1)
                    transform.position = positionZero + amplitude * direction * Mathf.Sin(temp * Time.time);
                temp2 = temp;
            }
            else
            {
                transform.position = positionZero + amplitude * direction * Mathf.Sin(speed * Time.time);
                temp2 = speed;
                first = false;
            }
            transform.position = positionZero + amplitude * direction * Mathf.Sin(temp2 * Time.time);
            //Debug.Log(Random.Range(1, 3));
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
