using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excersice : MonoBehaviour {
    public float num1 = 5.0f;
    public float num2 = 4.3f;
    public float num3 = 6.2f;
    public string[] names = { "John", "mark", "steve", "gregg","jack" } ;
    public string[] colors = { "Red", "Blue", "Green", "Black", "Yellow" };
    public string number = "7";
	// Use this for initialization
	void Start () { 
        
        MyMultFunction(num1, num2, num3);
        MyColor();
        RandomToList();
        float myReturnedValue = AddTwoNumbers(num1, num2);
        print(myReturnedValue);
        MultiplicationTable();
        ConvertString(number);
	}
	
	// Update is called once per frame
	private void MyMultFunction (float num1, float num2, float num3) {
        float multiply = num1 * num2 * num3;
        print(multiply);
	}
    private void MyColor(){
        for(int i =0; i< names.Length; i++)
        {
            print(names[i] + "'s favorite color is: " + colors[i]);
        }
    }
    List<int> RandomToList()
    {
        List<int> myList = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            int myNum = Random.Range(1, 20);
            myList.Add(myNum);
            print(myList[i]);
        }
        return myList;
    }
     private float AddTwoNumbers (float num1, float num2)
      {
        num3 = num1 + num2;
          return num3;
      }
    private void ConvertString(string number)
    {
        ToString
    }
    private void MultiplicationTable ()
    {
        for (int i = 0 ; i < 13 ; i++)
        {
            float answer = num1 * i;
            print(string.Format("{0} * {1} = {2}",num1,i,answer));
        }
    }
}
