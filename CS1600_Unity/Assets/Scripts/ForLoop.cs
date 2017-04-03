using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    public List<string> animals;
    public List<string> cats;
    public List<string> dogs;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < animals.Count; i++)
        {
            switch (animals[i])
            {
                case "cat":
                    cats.Add(animals[i]);

                    break;
                case "dog":
                    dogs.Add(animals[i]);

                    break;
            }
        }
        foreach (string animal in animals)
        {
            print(animal);
           
        }
        animals.Clear();
            foreach (string cat in cats)
            {
                print(cat);
            }
            foreach (string dog in dogs)
            {
                print(dog);
            }
        }
}
