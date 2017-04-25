using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

    float startPosition = -788f;
    float yPos = 139f;
    float zPos = 91.6f;

    public void MoveCubeFunction () {

        transform.position = new Vector3(startPosition, yPos, zPos);
    }
	
	
	
}
