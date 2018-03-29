using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour {
    GridMath grid;
    // Use this for initialization
    public GameObject cube;
    public GameObject capsule;
    public float gridSide;
    public float boxSize;
    public float offset;
    void Start () {
        gridSide = 5f;
        offset = 0.1f;
        boxSize = cube.transform.localScale.x;
        grid = new GridMath(gridSide, offset, boxSize);
        grid.GenerateGrid();
        Instantiate(capsule, new Vector3(0, capsule.transform.localScale.y / 2), Quaternion.identity);
        foreach (Vector3 position in grid.positions)
        {
            if(position != capsule.transform.position)
            {
                Instantiate(cube, position, Quaternion.identity);
            }
            
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
