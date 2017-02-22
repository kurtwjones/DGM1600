using UnityEngine;

public class rotate : MonoBehaviour {
    //if the value is public you can access it in unity
    public float speed = 0.5f;
    //these values are private
    int xValue = 15;
    int yValue = 30;
    int zValue = 45;

	// Use this for initialization
	void Start () {
      speed = Random.Range(1, 5);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(xValue, yValue, zValue) * Time.deltaTime * speed);
	}
}
