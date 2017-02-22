using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour {
    public int myNumber = 3;
    public int minValue = 0;
    public int MaxValue = 100;
    private bool PickedTheNumber = false;
    
    	// Use this for initialization
	void Start () {
      int counter = 0;
      while (PickedTheNumber == false)
        {
           
            if (myNumber > MaxValue || myNumber < minValue)
            {
                print("Pick a number between your min value and max value");
                break;
            }
            int randomNum = Random.Range(minValue, MaxValue);
            print("Is your number: " + randomNum + "?");
            counter++;
            if(randomNum == myNumber)
            {
                print("I got your number! Your number is: " + myNumber);
                print("I got the answer in: " + counter + " Tries");
                PickedTheNumber = true;
            }
        }
	}  

}
