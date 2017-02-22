using UnityEngine;

public class Move : MonoBehaviour {
    //When you assign a value to the variable you use the name to use that value
    float speed = 1.5f;
    float xValue = 0;
    float yValue = 0;
    float zValue = 0;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Time.deltaTime * speed, yValue, zValue);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(-Time.deltaTime * speed, yValue, zValue);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(xValue, Time.deltaTime * speed, zValue);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(xValue, -Time.deltaTime * speed, zValue);
        }
	}
}
