using UnityEngine;
// This script checks different conditions. < is less than, > is greater than
// == is equal as in checking if they are the same. You can also check for greater than or equal by
//placing a = behind the > or <. This symbol ! is Not. You can check != not equal.
// booleans are either true or false.
public class ConditionalStatements : MonoBehaviour {
    private int A = 4983;
    private int B = 3564;
    private float C = 5.4f;
    //because these are public you can access them in UNITY!
    public bool isCool = true ;
    //put in your name and see what happens!
    public string yourName = "Clayton";
	// Use this for initialization
	void Start () {
        
        print(A);
        print(B);
        print(C);
        //==
        if (A == B)
        {
            print("A is equal to B");
        }
        //!=
        if (A != B)
        {
            print("A is not equal to B");
        }
        //<
        if (A < B)
        {
            print("A is less than B");
        }
		//>
        if (A > B)
        {
            print("A is greater than B");
        }
        //<=
        if (A <= B)
        {
            print("A is less than or equal to B");
        }
        //>=
        if (A >= B)
        {
            print("A is greater than or equal to B");
        }
        //This statement will check to see if your name is equal to clayton
        if (yourName == "Clayton")
        {
            print("your name is: " + yourName + " and your name is cool!");
        }
        else print("your name is: " + yourName);
        //This statement will check to see if your name is not john
        if (yourName != "John")
        {
            print("Your name is not John!");
        }
        else print("Your name is John...");
        //This statement will check to see if c is greater than b
        if (C > B)
        {
            print("C is greater then B");
        }
        //This statement will check to see if isCool is not true
        if (isCool != true)
        {
            print("You are not cool!");
        }
        else print("You are cool!");
	}

}
