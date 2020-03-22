using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalFishRod : MonoBehaviour {

	//button not active
	public GameObject fakeButton;
	public GameObject fakeText;

	//button active
	public GameObject realButton;
	public GameObject realText;

	//how many fish you have
	public int currentFish;
	// Fishrod Price
	public static int fishrodValue = 10;
	public static bool turnOffButton = false;
	public GameObject fishrodStats; 
	// count how many fishrod you purchase
	public static int fishrodCount;
	// count how many fishes you get per sec
	public static int frPerSec;

		
	void Update () {
		currentFish = GlobalFishes.FishesCount;	

		//setting of status display;
		fishrodStats.GetComponent<Text>().text = "Fish Rods:" + fishrodCount + " @ " + frPerSec + " Per Second";

		fakeText.GetComponent<Text>().text = "Buy Fish Rod - " + fishrodValue + " fishes";
		realText.GetComponent<Text>().text = "Buy Fish Rod - " + fishrodValue + " fishes";
		
		// button updates
		if(currentFish >= fishrodValue){
			fakeButton.SetActive(false);
			realButton.SetActive(true);
		}

		if(turnOffButton == true){
			realButton.SetActive(false);
			fakeButton.SetActive(true);
			turnOffButton = false;
		}
	}
}
