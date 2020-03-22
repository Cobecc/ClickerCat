using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalFishes : MonoBehaviour {

	// static = this is saying we can access this particular variable from any of the script 
	// static (Class variable) It's not change object to object 
	// this variable counts the purrs of cats
	public static int FishesCount; 
	//(opt) Access modifier + (opt) Mod + type of variable + name variable
	public GameObject FishesDisplay; 
	public int InternalFishes;


	// Update of fishes you have
	void Update () {
		InternalFishes = FishesCount;
		FishesDisplay.GetComponent<Text>().text = "Fishes: " + InternalFishes ;
		
	}
}