using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

    public InputField userInput;
    public InputField answerField;
    public string operation = "";
    public string num1 = "";
    public string num2 = "";
    public float answer = 0f;
    public float exponentialNum1 = 0f;
    public string symbol = "";
    public float convertedNum1 = 0f;
    public float convertedNum2 = 0f;
	// Use this for initialization
	void Start ()
    {  
        
	}
	// create functions for each action
	public void Addition ()
    {
        operation = "Addition";
        num1 = userInput.text;
        Clear();
        convertedNum1 = float.Parse(num1);
        exponentialNum1 += convertedNum1;
       
    }
    public void Subtraction()
    {
        operation = "Subtraction";
        num1 = userInput.text;
        exponentialNum1 -= float.Parse(num1);
        Clear();
    }
    public void Multiplication()
    {
        operation = "Multiplication";
        num1 = userInput.text;
        Clear();
    }
    public void Division()
    {
        operation = "Division";
        num1 = userInput.text;
        Clear();
    }
    public void Equals()
    {
        num2 = userInput.text;
        Clear();
        convertedNum2 = float.Parse(num2);
        if (operation == "Addition")
        {
           answer = exponentialNum1 + convertedNum2;
            exponentialNum1 = answer;
            symbol = "+";
        }
        if (operation == "Subtraction")
        {
            answer = exponentialNum1 - convertedNum2;
            exponentialNum1 = answer;
        }
        string outAnswer = answer.ToString();
        answerField.text = outAnswer + symbol;
        Clear();
    }
    public void Clear()
    {
        userInput.text = "";
        answerField.text = "";
        
    }
    public void AddToInput(string value)
    {
        userInput.text += value;
        
    }
    
}
