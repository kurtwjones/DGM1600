using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

    public InputField userInput;
    public InputField answerField;
    public Button additionButton;
    public Button subtractionButton;
    public Button MultiplicationButton;
    public Button divisionButton;
    public Text textBox;
    public Text textGameOver;
    public Text scoreText;
    public Canvas myCanvas;
    public Canvas textCanvas;
    public GameObject triggerCube;
    public Rigidbody myRidgidBody;
    string operation = "";
    string num1 = "";
    string num2 = "";
    float answer = 0f;
    float exponentialNum1 = 0f;
    float convertedNum1 = 0f;
    float convertedNum2 = 0f;
    float randomNumber = 0;
    float startPosition = -104f;
    float yPos = 196f;
    float zPos = 254f;
    int score = 0;
    // Use this for initialization
    void Start ()
    {
        randomNumber  = Random.Range(0, 101);
        textBox.text = randomNumber.ToString();
        
	}
	// create functions for each action
	public void Addition ()
    {  
        operation = "Addition";
        if (!(userInput.text == ""))
        {
            num1 = userInput.text;
            convertedNum1 = float.Parse(num1);
            exponentialNum1 += convertedNum1;
            string currentAnswer = exponentialNum1.ToString();
            answerField.text = currentAnswer;
            Clear();
        }
       
    }
    public void Subtraction()
    {

        operation = "Subtraction";
        if (!(userInput.text == ""))
        {
            num1 = userInput.text;
            exponentialNum1 += float.Parse(num1);
            string currentAnswer = exponentialNum1.ToString();
            answerField.text = currentAnswer;
            Clear();
        }
    }
    public void Multiplication()
    {
        operation = "Multiplication";
        if (!(userInput.text == ""))
        {
            num1 = userInput.text;
            exponentialNum1 += float.Parse(num1);
            Clear();
            string currentAnswer = exponentialNum1.ToString();
            answerField.text = currentAnswer;
        }
    }
    public void Division()
    {
        operation = "Division";
        if (!(userInput.text == ""))
        {
            num1 = userInput.text;
            exponentialNum1 += float.Parse(num1);
            Clear();
            string currentAnswer = exponentialNum1.ToString();
            answerField.text = currentAnswer;
        }
    }
    public void Equals()
    {
        if (!(userInput.text == ""))
        {
            num2 = userInput.text;
            Clear();
            convertedNum2 = float.Parse(num2);
            switch (operation)
            {
                case "Addition":
                    answer = exponentialNum1 + convertedNum2;
                    exponentialNum1 = answer;
                    
                    break;
                case "Subtraction":
                    answer = exponentialNum1 - convertedNum2;
                    exponentialNum1 = answer;
                    subtractionButton.interactable = false;
                    break;
                case "Multiplication":
                    answer = exponentialNum1 * convertedNum2;
                    exponentialNum1 = answer;
                    MultiplicationButton.interactable = false;
                    break;
                case "Division":
                    answer = exponentialNum1 / convertedNum2;
                    exponentialNum1 = answer;
                    divisionButton.interactable = false;
                    break;
             }
            string outAnswer = answer.ToString();
            answerField.text = outAnswer;
            Clear();
            NumberMatch(answer);
        }
       
    }
    public void ChangeButtons()
    {
        switch (operation)
        {
            case "Addition":
                additionButton.interactable = false;
                break;
            case "Subtraction":
                subtractionButton.interactable = false;
                break;
            case "Multiplication":
                MultiplicationButton.interactable = false;
                break;
            case "Division":
                divisionButton.interactable = false;
                break;
        }
       if (additionButton.interactable == false && subtractionButton.interactable == false && MultiplicationButton.interactable == false && divisionButton.interactable == false)
        {
            additionButton.interactable = true;
            subtractionButton.interactable = true;
            MultiplicationButton.interactable = true;
            divisionButton.interactable = true;
        } 
    }
    public void NumberMatch(float answer)
    {
        
        if (randomNumber == answer)
        {
            ChangeButtons();
            textBox.text = "";
            ClearAll();
            randomNumber = Random.Range(0, 101);
            textBox.text = randomNumber.ToString();
            myRidgidBody.Sleep();
            triggerCube.transform.position = new Vector3(startPosition, yPos, zPos);
            ScoreBox();
            if (score >= 500) 
            {
               
            }
            if (score >= 1000)
            {
              
            }
            if (score >= 1500)
            {
               
            }
        }
    }
    private void ScoreBox()
    {
        score += 100;
        string stringScore =score.ToString();
        scoreText.text = "SCORE: " + stringScore;
        switch (score)
        {
            case 500:
                myRidgidBody.velocity = new Vector3(0, -20, 0);
                break;
            case 1000:
                myRidgidBody.velocity = new Vector3(0, -40, 0);
                break;
            case 1500:
                myRidgidBody.velocity = new Vector3(0, -80, 0);
                break;
            case 2000:
                myRidgidBody.velocity = new Vector3(0, -120, 0);
                break;
            case 2500:
                myRidgidBody.velocity = new Vector3(0, -160, 0);
                break;

        }
    }
    public void Clear()
    {
        userInput.text = "";     
    }
    public void ClearAll()
    {
        userInput.text = "";
        answerField.text = "";
        exponentialNum1 = 0;
        convertedNum1 = 0;
        convertedNum2 = 0;
        answer = 0;
    }
    
   
    public void AddToInput(string value)
    {
        userInput.text += value;
        
    }
    void OnTriggerEnter()
    {
        myCanvas.enabled = false;
        textCanvas.enabled = true;
        textGameOver.text = "GAME OVER!";
    }
    public void Restart()
    {
        Start();
    }
}
