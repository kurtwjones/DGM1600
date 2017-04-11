using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

    public InputField userInput;
    string operation = "";
    string num1 = "";
    string num2 = "";
    float answer = 0f;
	// Use this for initialization
	void Start ()
    {  
        
	}
	// create functions for each action
	public void Addition ()
    {
        operation = "Addition";
        num1 = userInput.text;
        float convertedNum1 = float.Parse(num1);

        Clear();
    }
    public void Subtraction(string value)
    {
        operation = "Subtraction";
        num1 = userInput.text;
    }
    public void Multiplication(string value)
    {
        operation = "Multiplication";
        num1 = userInput.text;
        Clear();
    }
    public void Division(string value)
    {
        operation = "Division";
        num1 = userInput.text += value;
        Clear();
    }
    public void Equals()
    {
        num2 = userInput.text;
        Clear();
        float convertedNum1 = float.Parse(num1);
        float convertedNum2 = float.Parse(num2);
        if (operation == "Addition")
        {
           answer = convertedNum1 + convertedNum2; 
        }
        string outAnswer = answer.ToString();
        userInput.text = outAnswer;
    }
    public void Clear()
    {
        userInput.text = "";  
    }
    public void AddToInput(string value)
    {
        userInput.text += value;
        
    }
    
}
