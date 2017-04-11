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
        
        
	}
	public void GetInput()
    {
        string input = userInput.text;
        float converted = float.Parse(input);
        numbers[0] = converted;
        
    }
	// create functions for each action
	public void Addition ()
    {
        //get numbers from input box
        //add numbers together
        

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
    public void Clear()
    {
        userInput.Select();
        userInput.text = "";  
    }
    public void AddToInput(string value)
    {
        userInput.text += value;
    }
    
}
