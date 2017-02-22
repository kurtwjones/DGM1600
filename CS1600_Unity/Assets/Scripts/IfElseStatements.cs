//This program checks conditions. if the statement is true is will print a messeage. if it is not true
//or "else" it will print another statement.
using UnityEngine;

public class IfElseStatements : MonoBehaviour {
    public float money = 5.00f;
    public bool lazy = true;
    public bool hungry = true;
    public bool job = false;
    public bool buyFood = true;
    bool alive = true;
	// Use this for initialization
	void Start () {
        //This statement checks to see if you have a job
        if (job == true)
        {
            print("You have: " + money);
            print("congratualations you have a job. Here is your paycheck!");
            money += 500.00f;
            print("You now have: " + money);
        }
        //this statement runs if you do not have a job.
        else
        {
            print("You have: " + money);
            print("Im sorry you do not have a job. You have bills... I will take your money.");
            money = 0.00f;
            print("You now have: " + money);
        }

        //this statement checks to see if you have less than 5 dollars. If you do you are poor
        if (money < 5.00)
        {
            print("you are poor...You should get a job.");
        }
        //this statement checks to see if you have exactly 5 dollars
        else if (money == 5.00)
        {
            print("you have a little bit of money");
        }
        //this statement will print if the other two statements fail
        else
            print("wow you are rich!");
        //This statement checks to see if you are lazy
        if (lazy == true)
            print("You are lazy...You should get up and work");
        //if you are not lazy this will run
        else
            print("Because you are not lazy you are successful");
        //this statement checks to see if you are hungry AND if you have greater then or equal to 5 dollars.
        if (hungry == true && money >= 5.00f)
        {
            print("You are hungry. go buy some food.");
        }
        //this statement checks to see if you are hungry AND if you have less then 5 dollars
        else if (hungry == true && money < 5.00f)
        {
            print("No lunch for you...you are dead");
            alive = false;
        }
        //this will run if the other two statements do not. You are not hungry
        else
            print("You are not hungry!");
        //this will check if you buy food and if you have enough money to buy food
        if (buyFood == true && money >= 5.00f)
        {
            print("You purchased food for 5$");
            money = money - 5.00f;
            print("You now have: " + money);
        }
        //if you do not buy food or can't buy food this is what prints.
        else
        { 
            print("You did not buy food you are dead...");
            alive = false;
        }
        //This checks if you are in the state of: alive
        if (alive == true)
        {
            print("You are alive! congratulations!");
        }
        //if you are not alive, this prints.
        else
            print("You are dead!");

	}
	
}
