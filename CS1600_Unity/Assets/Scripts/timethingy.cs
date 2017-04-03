using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class timethingy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void FindDate () {
        string greeting = "Hello today is: ";
         int day = DateTime.Now.Day;
        print(greeting + day);
	}
}
