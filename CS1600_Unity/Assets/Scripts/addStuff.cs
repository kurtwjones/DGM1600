using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addStuff : MonoBehaviour {
    public int num1 = 0;
    public int num2 = 0;

    // Use this for initialization
    void Start () {
        AddTwoNumbers(num1, num2);
	}
	
	// Update is called once per frame
	void AddTwoNumbers (int x, int y) {
        int addition = x + y;
        print(string.Format("{0} + {1} = {2}", x, y, addition));
	}
}
