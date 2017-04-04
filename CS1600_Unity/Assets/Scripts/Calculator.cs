using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

    List<float> numbers = new List<float> ();
    public InputField userInput;
	// Use this for initialization
	void Start ()
    {
        //take number from input box and add to list
      var myValue = userInput.GetComponent<InputField>();
       
	}
	public void GetInput()
    {
        string myValue = userInput.text;
        float Converted = float.Parse(myValue);
        
    }
	// create functions for each action
	public void Addition (float myValue)
    {
        //get numbers from input box
        //add numbers together
        print(myValue);
        
	}
    public void Subtraction()
    {

    }
    public void Multiplication()
    {

    }
    public void Division()
    {

    }
    public void Equals()
    {

    }
}
