//list are similar to arrays except they do not have to be declaired a certain size
//list must be declared as a type to tell it what it is going to hold.
//you can add, take away from and change items in your list. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public string animal;
    public List<string> animalsInZoo = new List<string>();
    // Use this for initialization
    void Start()
    {
        //add initial animals
        animalsInZoo.Add("monkey");
        animalsInZoo.Add("elephant");
        animalsInZoo.Add("hippo");

    }
    //adds current string to list
    public void AddAnimal()
    {
        // create catch for blank strings
        if (animal != "")
        {
            //create catch for existing strings
            if (animalsInZoo.Contains(animal))
            {
                print("Animal is already in the zoo...");

            }
            else
                //add animal to zoo using text input
                animalsInZoo.Add(animal);
        }
        else
            print("Please enter an animal into the text box");

    }
    public void ClearAnimal()
    {
        //create option to clear out all of the animals
        animalsInZoo.Clear();
    }
    //removes animal according to name
    public void RemoveAnimal()
    {
        //checks if string is empty
        if (animal != "")
        {
            //checks all eliments in list
            for (int i = 0; i < animalsInZoo.Count; i++)
            {
                //checks for animals that match input
                if (animal == animalsInZoo[i])
                {
                    print("You got rid of the: " + animal);
                    animalsInZoo.Remove(animal);
                }
                //no animals match input
                else
                {
                    print("That animal does not exist");
                }

            }
        }
        //no input print this
        else
            print("Please Input a valid animal you want to get rid of.");
       
    }
    //prints the current animals to the console
    public void PrintAnimals()
    {
        //check if zoo is empty
        if (animalsInZoo.Count == 0)
        {
            print("Your zoo is empty!");
        } else
            print("These are the animals in your zoo: ");
        //Print animals in the zoo
        for (int i = 0; i < animalsInZoo.Count; i++)
        {
            print(animalsInZoo[i]);
        }
    }
}