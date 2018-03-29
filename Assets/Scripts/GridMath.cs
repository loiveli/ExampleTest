using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMath  {

    float gridArea;
    float gridOffset;
    float gridSide;
    float blockSize;
    public List<Vector3> positions = new List<Vector3>();
    public GridMath(float tempSide, float tempOffset, float tempSize)
    {
        
        gridOffset = tempOffset;
        blockSize = tempSize;
        gridSide = tempSide+tempSide*tempOffset;
    }
	public void GenerateGrid()
    {
        for (float i = -gridSide; i <= gridSide; i+= blockSize+gridOffset){
            for (float j = -gridSide; j <= gridSide; j+= blockSize + gridOffset)
            {
                if(Random.Range(0,10)< 1)
                {
                    positions.Add(new Vector3(i, blockSize / 2, j));
                }
               
            }
        }
    }
}
