using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {
    //create Variables
    public static Action<string> scoreToPass;
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
    string scoreForTen = "Nice! +10";
    string scoreForOneHundred = "Great! +100";
    string scoreForFiveHundred = "Awesome! +500";
    //initialize game
    void Start ()
    {
        randomNumber  = UnityEngine.Random.Range(0, 101);
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
                    break;
                case "Multiplication":
                    answer = exponentialNum1 * convertedNum2;
                    exponentialNum1 = answer;
                    break;
                case "Division":
                    answer = exponentialNum1 / convertedNum2;
                    exponentialNum1 = answer;
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
            StartCoroutine(ScoreHandler(scoreForFiveHundred));
            score += 500;
            string stringScore = score.ToString();
            scoreText.text = "SCORE: " + stringScore;
        } 
    }
    public void NumberMatch(float answer)
    { 
        if (randomNumber == answer)
        {
            ScoreBox();
            ChangeButtons();
            textBox.text = "";
            ClearAll();
            randomNumber = UnityEngine.Random.Range(0, 101);
            textBox.text = randomNumber.ToString();
            myRidgidBody.Sleep();
            triggerCube.transform.position = new Vector3(startPosition, yPos, zPos);   
        }
    }
    private void ScoreBox()
    {
        if (convertedNum2 == 1 || convertedNum2 == 0)
        {
            score += 10;
            StartCoroutine(ScoreHandler(scoreForTen));
        }
        else
        {
            score += 100;
            StartCoroutine(ScoreHandler(scoreForOneHundred));
        }
        string stringScore =score.ToString();
        scoreText.text = "SCORE: " + stringScore;
        if (score >= 500)
        {
            Physics.gravity = new Vector3(0, -15, 0);
            
        }
        else if (score >= 1000)
        {
            Physics.gravity = new Vector3(0, -30, 0);
        }     
        else if (score >= 1500)
        {
            Physics.gravity = new Vector3(0, -45, 0);
        }      
        else if (score >= 2000)
        {
            Physics.gravity = new Vector3(0, -60, 0);
        }
        else if (score >= 2500)
        {
            Physics.gravity = new Vector3(0, -75, 0);
        }
        else if (score >= 3000)
        {
            Physics.gravity = new Vector3(0, -90, 0);
        }
        else if (score > 5000)
        {
            Physics.gravity = new Vector3(0, -150, 0);
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
    IEnumerator ScoreHandler (string scoreText)
    {
        textGameOver.text = scoreText ;
        yield return new WaitForSeconds(2);
        textGameOver.text = "";
    }
    void OnTriggerEnter()
    {
        myCanvas.enabled = false;
        textCanvas.enabled = true;
        textGameOver.text = "GAME OVER!";
    }
}
