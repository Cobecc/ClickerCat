using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour {

	public GameObject AutoFish;
	public GameObject AutoSell;

	public AudioSource playSound;
	public void StartAutoFish(){
		playSound.Play();
		AutoFish.SetActive(true);
		GlobalFishes.FishesCount -= GlobalFishRod.fishrodValue;
		// increase the value of the FR after purchase it.
		GlobalFishRod.fishrodValue *= 2; 
		GlobalFishRod.turnOffButton = true;
		// count control of the FR to the status display
		GlobalFishRod.frPerSec += 1;
		GlobalFishRod.fishrodCount += 1;
	}

	public void StartAutoSell(){
		playSound.Play();
		AutoSell.SetActive(true);
		GlobalFishes.FishesCount -= GlobalShop.shopValue;
		// increase the value of the FR after purchase it.
		GlobalShop.shopValue *= 2; 
		GlobalShop.turnOffButton = true;
		// count control of the FR to the status display
		GlobalShop.shopPerSec += 1;
		GlobalShop.shopsCount += 1;
	}


}
