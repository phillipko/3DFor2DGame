using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TextEditor : MonoBehaviour {


    Text lifePointsText;

    // Use this for initialization
    void Start () {
        lifePointsText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        lifePointsText.text = "x " + Death.lifePoints;
	}
}
