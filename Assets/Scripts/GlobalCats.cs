using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCats : MonoBehaviour {

	// static = this is saying we can access this particular variable from any of the script 
	// static (Class variable) It's not change object to object 
	// this variable counts the purrs of cats
	public static int CatCount; 

	//(opt) Access modifier + (opt) Mod + type of variable + name variable
	public GameObject CatDisplay; 
	
	public int InternalPurrs;


	// Update is called once per frame
	void Update () {
		InternalPurrs = CatCount;
		CatDisplay.GetComponent<Text>().text = "Cat's purrs: " + InternalPurrs ;
		
	}
}