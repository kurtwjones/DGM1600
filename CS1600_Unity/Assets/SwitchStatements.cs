//using switches is another way to make decisions without
//using a bunch of 'else if' statements. when your input
//matches that of a case it will pick that option.
//if none of the options match it will pick the default.
using UnityEngine;

public class SwitchStatements : MonoBehaviour {
    //variables
    public string weapon = "sword";
    private string weaponStatement = "You got a: ";
    public int food = 1;
    private string floorStatement = "taking you to floor: ";
    public int floor = 4;
    public string grade = "a";
    private string gradeStatement = "Your grade is: ";
    public int coin = 1;
	// Use this for initialization
	void Start () {
        //what weapon do I need?
        switch (weapon)
        {
            //if the string equals sword you get the sword
            case "sword":
                print(weaponStatement + weapon);
                   break;
                //if the string equals bow you get the bow
            case "bow":
                print(weaponStatement + weapon);
                break;
                //if the string equals dagger you get the dagger
            case "dagger":
                print(weaponStatement + weapon);
                break;
                // if the string equals wand you get the wand
            case "wand":
                print(weaponStatement + weapon);
                break;
                //if the string equals gun you get the gun
            case "gun":
            print(weaponStatement + weapon);
                break;
                //if none of the weapons match you get this one
            default:
                print("You don't have a weapon");
                break;
        }
        //what kind of food should I eat?
        switch (food)
        {
            //if food equals 1 you get chinese
            case 1:
                print("you want chinese food");
                break;
                //if food equals 2 you get italian
            case 2:
                print("you want italian food");
                break;
                //if food equals 3 you get mexican
            case 3:
                print("you want mexican food");
                break;
                //if food equals 4 you get greek
            case 4:
                print("You want greek food");
                break;
                //if food is another number you get american
            default:
                print("you want american food");
                break;
        }
        //which floor should I go to?
        switch (floor)
            {
            //if input is one you will go to floor one
            case 1:
            print(floorStatement + floor);
                break;
                //if input is two you will go to floor two
            case 2:
                print(floorStatement + floor);
                break;
                //if input is three you will go to floor three
            case 3:
                print(floorStatement + floor);
                break;
                //if input is four you will go to floor four
            case 4:
                print(floorStatement + floor);
                break;
                //if you put in a floor that isnt one of the above
            default:
                print("Thats not a valid floor...");
                break;
            }
        switch (grade)
        {
            //if your grade is a
            case "a":
                print(gradeStatement + grade);
                break;
                //if your grade is b
            case "b":
                print(gradeStatement + grade);
                break;
            //if your grade is c
            case "c":
                print(gradeStatement + grade);
                break;
            //if your grade is d
            case "d":
                print(gradeStatement + grade);
                break;
            //if your grade is f
            case "f":
                print(gradeStatement + grade);
                break;
                //if none of the grades match or didnt put anything in
            default:
                print("Your assignment wasn't turned in. you get an F-");
                break;
        }
        switch (coin)
        {
            //if you enter coin 1
            case 1:
                print("You got a Penny!");
                break;
            //if you enter coin 2
            case 2:
                print("You got a Nickle!");
                break;
            //if you enter coin 3
            case 3:
                print("You got a Dime!");
                break;
            //if you enter coin 4
            case 4:
                print("You got a Quareter!");
                break;
            //if you enter another coin
            default:
                print("Thats a fake coin!!!");
                break;
        }
	}
	
}
