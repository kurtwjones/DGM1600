using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DGM1600Final : MonoBehaviour {

    public string yourName = "Kurt";
    float num1 = 8f;
    float num2 = 5f;
    public List<int> listOfNumbers = new List<int>();
    public bool feet = true;
    public bool inches = false;
    float inchesPerFoot = 12;
    public float myInches = 48;
    public float myFeet = 2;
    public float trainAMPH = 50;
    public float trainBMPH = 60;
    public float hours = 3;
	// Use this for initialization
	void Start () {
        HelloFunction();
        DoMath(num1, num2);
        AverageFromList();
        FeetToInches();
        TrainWordProblem();
	}
	
	
	void HelloFunction () {
        string timeOfDay = DateTime.Now.TimeOfDay.ToString();
        print("Hello, " + yourName + " the current time is: " + timeOfDay);
	}
    void DoMath(float num1, float num2)
    {
        float additionAnswer = num1 + num2;
        float subtractAnswer = num1 - num2;
        float multiplyAnswer = num1 * num2;
        float divideAnswer = num1 / num2;
        string printMath = string.Format("Your two numbers are: {0} and {1}. When they are added you get: {2} Subtracted you get: {3} Multiplied you get: {4} and Divided you get: {5}", num1,num2,additionAnswer,subtractAnswer,multiplyAnswer,divideAnswer);
        print(printMath);
    }
    void AverageFromList()
    {
        int total = 0;
        listOfNumbers.Add(5);
        listOfNumbers.Add(12);
        listOfNumbers.Add(4);
        listOfNumbers.Add(7);
        for(int i=0; i < listOfNumbers.Count; i++)
        {
            total += listOfNumbers[i]; 
        }
        int averageAnswer = total / listOfNumbers.Count;
        print(averageAnswer);

    }
    void FeetToInches ()
    {
        if (feet == true)
        {
            float conversion = myFeet * inchesPerFoot;
            print(conversion + " Inches");
        }
        if (inches == true)
        {
            float conversion = myInches / inchesPerFoot;
            print(conversion + " Feet");
        }
       
    }
    void TrainWordProblem ()
    {
        float distanceA = trainAMPH * hours;
        float distanceB = trainBMPH * hours;
        float trainAnswer = distanceA + distanceB;

        string trainProblem = string.Format("If train A left the city going {0} MPH and train B left the city going {1} how far apart are they at {2} Hours? Answer: {3}", trainAMPH, trainBMPH, hours, trainAnswer);
        print(trainProblem);
    }
}
