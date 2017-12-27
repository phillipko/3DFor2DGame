using UnityEngine;
using System.Collections;

public class AnimatedTexture : MonoBehaviour {

    public int colCount = 2;
    public int rowCount = 3;
    public int colNumber = 0;
    public int rowNumber = 0;
    public int totalCells = 6;
    public int fps = 5;
    Vector2 offset;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        SetSpriteAnimation(colCount, rowCount, colNumber, rowNumber, totalCells,fps);
    }

    void SetSpriteAnimation(int colCount, int rowCount, int colNumber, int rowNumber, int totalCells, int fps)
    {
        int index = (int)(Time.time * fps);
        index = index % totalCells;
        float sizeX = 1.0f / colCount;
        float sizeY = 1.0f / rowCount;
        Vector2 size = new Vector2(sizeX, sizeY);

        var uIndex = index % colCount;
        var vIndex = index / colCount;
        float offsetX = (uIndex + colNumber) * size.x;
        float offsetY = (1.0f - size.y) - (vIndex + rowNumber) * size.y;
        Vector2 offset = new Vector2(offsetX, offsetY);
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", offset);
        GetComponent<Renderer>().material.SetTextureScale("_MainTex", size);



    } 

}
