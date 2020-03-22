using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalShop : MonoBehaviour {

	//button not active
	public GameObject fakeButton;
	public GameObject fakeText;

	//button active
	public GameObject realButton;
	public GameObject realText;

	//how many fish you have
	public int currentFish;
	// Shop Price
	public static int shopValue = 30;
	public static bool turnOffButton = false;
	public GameObject shopStats; 
	// count how many shops you purchase
	public static int shopsCount;
	// count how many fishes you shop  per sec
	public static int shopPerSec;

		
	void Update () {
		currentFish = GlobalFishes.FishesCount;	

		//setting of status display;
		shopStats.GetComponent<Text>().text = "Fish Rods:" + shopsCount + " @ " + shopPerSec + " Per Second";

		fakeText.GetComponent<Text>().text = "Buy Fish Rod - " + shopValue + " fishes";
		realText.GetComponent<Text>().text = "Buy Fish Rod - " + shopValue + " fishes";
		
		// button updates
		if(currentFish >= shopValue){
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
